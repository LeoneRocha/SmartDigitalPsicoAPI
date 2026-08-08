using AutoMapper;
using Microsoft.Extensions.Logging.Abstractions;
using SmartDigitalPsico.Domain.DTO.Gender.GET;
using SmartDigitalPsico.Domain.DTO.Office.GET;
using SmartDigitalPsico.Domain.DTO.RoleGroup.GET;
using SmartDigitalPsico.Domain.DTO.Leaves.GET;
using SmartDigitalPsico.Domain.DTO.Specialty.GET;
using SmartDigitalPsico.Domain.DTO.Notification.GET;
using SmartDigitalPsico.Domain.DTO.Application.GET;
using SmartDigitalPsico.Domain.DTO.Audit.GET;
using SmartDigitalPsico.Domain.Mapper;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Test.Mapper;

[TestFixture]
public class AutoMapperProfileTests
{
    private static MapperConfiguration CreateConfiguration() =>
        new(config => config.AddProfile<AutoMapperProfile>(), NullLoggerFactory.Instance);

    [Test]
    public void AutoMapperProfile_RegisteredProfile_CreatesMapper()
    {
        // Cenário: o perfil registra todos os mapas de domínio.
        // Objetivo: criar o mapper para os caminhos de mapeamento exercitados.
        // Arrange
        var configuration = CreateConfiguration();

        // Act
        var mapper = configuration.CreateMapper();

        // Assert
        mapper.Should().NotBeNull();
    }

    [Test]
    public void Map_GenderToGetGenderDto_MapsSharedProperties()
    {
        // Cenário: uma entidade Gender possui propriedades de base preenchidas.
        // Objetivo: projetar a entidade para DTO de leitura.
        // Arrange
        var mapper = CreateConfiguration().CreateMapper();
        var source = new Gender { Id = 42, Enable = true };

        // Act
        var result = mapper.Map<GetGenderDto>(source);

        // Assert
        result.Id.Should().Be(42);
        result.Enable.Should().BeTrue();
    }

    [Test]
    public void Map_GetGenderDtoToGender_MapsSharedProperties()
    {
        // Cenário: um DTO de leitura possui propriedades de base preenchidas.
        // Objetivo: projetar o DTO de volta para entidade.
        // Arrange
        var mapper = CreateConfiguration().CreateMapper();
        var source = new GetGenderDto { Id = 7, Enable = false };

        // Act
        var result = mapper.Map<Gender>(source);

        // Assert
        result.Id.Should().Be(7);
        result.Enable.Should().BeFalse();
    }
}
