using SmartDigitalPsico.Data.Context.Mock;
using SmartDigitalPsico.Data.Repository;
using SmartDigitalPsico.Data.Test.Configure;
using SmartDigitalPsico.Data.Tests.Context;

using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Data.Test.Repository.SystemDomains
{
    [TestFixture]
    public class ApplicationConfigSettingRepositoryTests : BaseTests
    {
        private ApplicationConfigSettingRepository? _entityRepository;

        [SetUp]
        public override void Setup()
        {
            var mockData = ApplicationConfigSettingMockData.GetMock().Take(1).AsQueryable();
            // Arrange 
            SetupContext(mockData);
        }
        private void SetupContext(IQueryable<ApplicationConfigSetting> mockData)
        {
            var mockDataList = mockData.ToList();
            // Arrange
            _mockContext = new SmartDigitalPsicoDataContextTest();

            _mockContext.ApplicationConfigSettings.AddRange(mockDataList);
            _mockContext.SaveChanges();
        }

        // Cenário: configuração de aplicação persistida no contexto de teste.
        // Objetivo: garantir que FindAll retorne o registro cadastrado.
        [Test]
        public async Task FindAll_ExistingSettings_ReturnsAllRecords()
        {
            // Arrange
            var mockDataList = OfficeMockData.GetMock().Take(1).AsQueryable();

            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new ApplicationConfigSettingRepository(_mockContext);

            // Act
            var listResult = await _entityRepository.FindAll();
            var listCount = listResult.Count;

            // Assert
            using (Assert.EnterMultipleScope())
            {
                Assert.That(listResult, Is.Not.Null);
                Assert.That(listResult, Is.InstanceOf<List<ApplicationConfigSetting>>());
                Assert.That(listResult, Has.Count.EqualTo(1));
                Assert.That(listCount, Is.EqualTo(1));
            }
        }
    }
}
