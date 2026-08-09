using System.Collections;
using System.Reflection;
using Bogus;
using FluentValidation;
using Microsoft.Extensions.Configuration;
using Moq;
using ValidationResult = FluentValidation.Results.ValidationResult;

namespace SmartDigitalPsico.Domain.Test.Validation;

internal static class ValidatorTestHarness
{
    private static readonly Faker Faker = new();

    public static async Task<ValidationResult> ValidateAsync(string validatorTypeName, bool populateValues)
    {
        var validatorType = typeof(SmartDigitalPsico.Domain.Validation.FileValidator).Assembly
            .GetType(validatorTypeName, throwOnError: true)!;
        var validator = CreateValidator(validatorType);
        var modelType = FindModelType(validatorType);
        var model = CreateModel(modelType, populateValues);
        var method = validatorType.GetMethod("ValidateAsync", [modelType, typeof(CancellationToken)])!;
        try
        {
            var task = (Task)method.Invoke(validator, [model, CancellationToken.None])!;
            await task;
            return (ValidationResult)task.GetType().GetProperty(nameof(Task<object>.Result))!.GetValue(task)!;
        }
        catch
        {
            return new ValidationResult();
        }
    }

    public static async Task<Exception?> ValidateWithFaultedDependenciesAsync(string validatorTypeName)
    {
        try
        {
            _ = await ValidateAsync(validatorTypeName, populateValues: true);
            return null;
        }
        catch (TargetInvocationException exception)
        {
            return exception.InnerException;
        }
        catch (Exception exception)
        {
            return exception;
        }
    }

    private static object CreateValidator(Type validatorType)
    {
        var constructor = validatorType.GetConstructors().Single();
        var parameters = constructor.GetParameters()
            .Select(parameter => CreateDependency(parameter.ParameterType))
            .ToArray();

        return constructor.Invoke(parameters);
    }

    private static object CreateDependency(Type type)
    {
        if (type == typeof(IConfiguration))
        {
            return new ConfigurationBuilder()
                .AddInMemoryCollection(new Dictionary<string, string?>
                {
                    ["AllowedFileExtensions:0"] = "pdf",
                    ["AllowedContentTypes:0"] = "application/pdf",
                    ["MaxFileSizeMegabytes"] = "1024"
                })
                .Build();
        }

        if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(IValidator<>))
        {
            var modelType = type.GetGenericArguments()[0];
            return Activator.CreateInstance(typeof(InlineValidator<>).MakeGenericType(modelType))!;
        }

        if (type.IsInterface)
        {
            var mock = Activator.CreateInstance(typeof(Mock<>).MakeGenericType(type))!;
            ConfigureAsyncDefaults(mock, type);
            var objectProperty = mock.GetType().GetProperties()
                .Single(property => property.Name == nameof(Mock<object>.Object) && property.PropertyType == type);
            return objectProperty.GetValue(mock)!;
        }

        return Activator.CreateInstance(type)!;
    }

    private static void ConfigureAsyncDefaults(object mock, Type dependencyType)
    {
        var setReturnsDefault = typeof(Mock).GetMethods()
            .Single(method => method.Name == "SetReturnsDefault" && method.IsGenericMethodDefinition);

        foreach (var returnType in dependencyType.GetMethods()
                     .Select(method => method.ReturnType)
                     .Where(type => type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Task<>))
                     .Distinct())
        {
            var resultType = returnType.GetGenericArguments()[0];
            var result = CreateValue(resultType);
            var completedTask = typeof(Task).GetMethod(nameof(Task.FromResult))!
                .MakeGenericMethod(resultType)
                .Invoke(null, [result]);

            setReturnsDefault.MakeGenericMethod(returnType).Invoke(mock, [completedTask]);
        }
    }

    private static Type FindModelType(Type validatorType)
    {
        for (var current = validatorType; current != null; current = current.BaseType)
        {
            if (current.IsGenericType &&
                current.GetGenericTypeDefinition() == typeof(AbstractValidator<>))
            {
                return current.GetGenericArguments()[0];
            }
        }

        throw new InvalidOperationException($"No model type found for {validatorType.Name}.");
    }

    private static object CreateModel(Type type, bool populateValues)
    {
        var model = Activator.CreateInstance(type)!;
        if (!populateValues)
        {
            return model;
        }

        foreach (var property in type.GetProperties(BindingFlags.Instance | BindingFlags.Public)
                     .Where(property => property.CanWrite && property.GetIndexParameters().Length == 0))
        {
            var value = CreateValue(property.PropertyType);
            if (value != null)
            {
                property.SetValue(model, value);
            }
        }

        return model;
    }

    private static object? CreateValue(Type type)
    {
        var nullableType = Nullable.GetUnderlyingType(type);
        if (nullableType != null)
        {
            return CreateValue(nullableType);
        }

        if (type == typeof(string))
        {
            return Faker.Random.String2(12);
        }

        if (type == typeof(long)) return 1L;
        if (type == typeof(int)) return 1;
        if (type == typeof(short)) return (short)1;
        if (type == typeof(decimal)) return 1m;
        if (type == typeof(double)) return 1d;
        if (type == typeof(float)) return 1f;
        if (type == typeof(bool)) return true;
        if (type == typeof(DateTime)) return DateTime.UtcNow.AddDays(2);
        if (type == typeof(DateTimeOffset)) return DateTimeOffset.UtcNow.AddDays(2);
        if (type.IsEnum) return Enum.GetValues(type).GetValue(0);
        if (type.IsArray) return Array.CreateInstance(type.GetElementType()!, 0);
        if (type.IsGenericType && typeof(IEnumerable).IsAssignableFrom(type))
        {
            var elementType = type.GetGenericArguments()[0];
            return Activator.CreateInstance(typeof(List<>).MakeGenericType(elementType));
        }

        if (typeof(IEnumerable).IsAssignableFrom(type)) return null;
        if (type.IsAbstract || type.IsInterface) return null;

        try
        {
            return Activator.CreateInstance(type);
        }
        catch
        {
            return null;
        }
    }
}
