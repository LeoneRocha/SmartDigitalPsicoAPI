using System.Text.Json;
using Newtonsoft.Json;
using SmartDigitalPsico.Core.SDK.Domain.EntityModels.Contracts;
using SmartDigitalPsico.Core.SDK.Domain.Helpers;
using SmartDigitalPsico.Core.SDK.Domain.Helpers.Security;
using SmartDigitalPsico.Core.SDK.Domain.Security;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace SmartDigitalPsico.Core.SDK.Tests.Domain.Helpers;

[TestFixture]
public class RemainingHelpersTests
{
    [Test]
    public void HtmlSanitizer_RemovesUnsafeScript()
    {
        const string html = "<div style='color:red'><strong>safe</strong><script>alert(1)</script></div>";
        var result = HtmlSanitizerHelper.Sanitize(html);
        using (Assert.EnterMultipleScope())
        {
            result.Should().Contain("safe");
            result.Should().NotContain("<script");
        }
    }

    [Test]
    public void ReflectionHelpers_OrderedModel_ReturnsOrderedPropertiesAndLabel()
    {
        var model = new OrderedModel();
        var properties = ReflectionHelpers.GetProperties(model, ["Ignored", "Secret"]).ToList();
        var label = ReflectionHelpers.GetLabelProperty(properties[0]);

        using (Assert.EnterMultipleScope())
        {
            properties.Select(x => x.Name).Should().BeEquivalentTo(["First", "Second"], o => o.WithStrictOrdering());
            label.Should().Be("Nome exibido");
            ReflectionHelpers.GetLabelProperty(typeof(OrderedModel).GetProperty(nameof(OrderedModel.Second))!).Should().Be("Second");
            new SmartDigitalPsico.Core.SDK.Domain.Helpers.OrderAttribute(7).Order.Should().Be(7);
        }
    }

    [Test]
    public void BlobFileHelper_SetsContentType()
    {
        var headers = BlobFileHelper.GetBlobHeadersAzure(new TestFile { FileContentType = "image/png" });
        headers.ContentType.Should().Be("image/png");
    }

    [Test]
    public void EmailHelper_ReplaceTokens_SubstitutesValues()
    {
        var result = EmailHelper.ReplaceTokens("Hello [{Name}]", new Dictionary<string, string> { ["Name"] = "Ana" });
        var unchanged = EmailHelper.ReplaceTokens("plain", null!);
        using (Assert.EnterMultipleScope())
        {
            result.Should().Be("Hello Ana");
            unchanged.Should().Be("plain");
        }
    }

    [Test]
    public void EnumDescriptionConverter_ReadWrite_UsesDescriptionOrName()
    {
        var options = new JsonSerializerOptions();
        options.Converters.Add(new EnumDescriptionConverter<SampleEnum>());

        JsonSerializer.Serialize(SampleEnum.WithDescription, options).Should().Be("\"Friendly\"");
        JsonSerializer.Serialize(SampleEnum.Plain, options).Should().Be("\"Plain\"");
        JsonSerializer.Deserialize<SampleEnum>("\"Friendly\"", options).Should().Be(SampleEnum.WithDescription);
        JsonSerializer.Deserialize<SampleEnum>("\"Plain\"", options).Should().Be(SampleEnum.Plain);
        var act = () => JsonSerializer.Deserialize<SampleEnum>("\"missing\"", options);
        act.Should().Throw<ArgumentException>();
    }

    [Test]
    public void IgnorableSerializerContractResolver_IgnoresConfiguredProperties()
    {
        var resolver = new IgnorableSerializerContractResolver(["Secret"]);
        var settings = new JsonSerializerSettings { ContractResolver = resolver };
        var json = JsonConvert.SerializeObject(new OrderedModel { Secret = "x", First = "a" }, settings);
        json.Should().NotContain("Secret");
        json.Should().Contain("First");

        var property = new Newtonsoft.Json.Serialization.JsonProperty { PropertyName = "Secret" };
        resolver.ApplyIgnoreRulesForTests(property);
        property.ShouldSerialize!(new object()).Should().BeFalse();
    }

    [Test]
    public void SecurityHelper_PasswordAndToken_RoundTrip()
    {
        SecurityHelper.CreatePasswordHash("secret", out var hash, out var salt);
        SecurityHelper.VerifyPasswordHash("secret", hash, salt).Should().BeTrue();
        SecurityHelper.VerifyPasswordHash("wrong", hash, salt).Should().BeFalse();
        SecurityHelper.IsBase64String("").Should().BeFalse();
        SecurityHelper.IsBase64String("YQ==").Should().BeTrue();

        var dto = new SecurityDto
        {
            Name = "Ana",
            Role = "Admin",
            SecurityKeyConfig = "0123456789abcdef0123456789abcdef"
        };
        typeof(SecurityDto).GetProperty(nameof(SecurityDto.Id))!
            .SetValue(dto, "42");
        var token = SecurityHelper.CreateToken(dto);
        token.Should().NotBeNullOrWhiteSpace();
    }

    [Test]
    public void AesKeyGeneratorHelper_GeneratesKeyAndIv()
    {
        AesKeyGeneratorHelper.GenerateKey().Should().NotBeNullOrWhiteSpace();
        AesKeyGeneratorHelper.GenerateIV().Should().NotBeNullOrWhiteSpace();
    }

    private sealed class OrderedModel
    {
        [SmartDigitalPsico.Core.SDK.Domain.Helpers.Order(1)]
        [System.ComponentModel.Description("Nome exibido")]
        public string First { get; set; } = "first";

        [SmartDigitalPsico.Core.SDK.Domain.Helpers.Order(2)]
        public string Second { get; set; } = "second";

        public string Ignored { get; set; } = "ignored";
        public string Secret { get; set; } = "secret";
    }

    private sealed class TestFile : FileBase
    {
    }

    private enum SampleEnum
    {
        [System.ComponentModel.Description("Friendly")]
        WithDescription,
        Plain
    }
}
