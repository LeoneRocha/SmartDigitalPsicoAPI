using SmartDigitalPsico.Data.ConfigureFluentAPI.Mock;
using SmartDigitalPsico.Data.Repository.SystemDomains;
using SmartDigitalPsico.Data.Test.Configure;
using SmartDigitalPsico.Data.Tests.Context;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Resiliency;

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

        [Test]
        public async Task FindAll_Success()
        {
            // Arrange
            var mockDataList = OfficeMockData.GetMock().Take(1).AsQueryable();

            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new ApplicationConfigSettingRepository(_mockContext, new PolicyConfig());;

            // Act
            var listResult = await _entityRepository.FindAll();
            var listCount = listResult.Count;

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(listResult, Is.Not.Null);
                Assert.That(listResult, Is.InstanceOf<List<ApplicationConfigSetting>>());
                Assert.That(listResult, Has.Count.EqualTo(1));
                Assert.That(listCount, Is.EqualTo(1));
            });
        }
    }
}