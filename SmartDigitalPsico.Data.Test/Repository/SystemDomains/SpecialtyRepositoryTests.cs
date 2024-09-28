using SmartDigitalPsico.Data.Context.Configure.Mock;
using SmartDigitalPsico.Data.Repository.SystemDomains;
using SmartDigitalPsico.Data.Test.Configure;
using SmartDigitalPsico.Data.Tests.Context;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Resiliency;

namespace SmartDigitalPsico.Data.Test.Repository.SystemDomains
{
    [TestFixture]
    public class SpecialtyRepositoryTests : BaseTests
    {
        private SpecialtyRepository? _entityRepository;
        private static int totalRegister = 7;
        [SetUp]
        public override void Setup()
        {
            var mockData = SpecialtyMockData.GetMock().Take(totalRegister).AsQueryable();
            // Arrange 
            SetupContext(mockData);
        }
        private void SetupContext(IQueryable<Specialty> mockData)
        {
            var mockDataList = mockData.ToList();
            // Arrange
            _mockContext = new SmartDigitalPsicoDataContextTest();

            _mockContext.Specialties.AddRange(mockDataList);
            _mockContext.SaveChanges();
        }

        [Test]
        public async Task FindAll_Success()
        {
            // Arrange
            var mockDataList = SpecialtyMockData.GetMock().Take(totalRegister).AsQueryable();

            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new SpecialtyRepository(_mockContext);

            // Act
            var listResult = await _entityRepository.FindAll();
            var listCount = listResult.Count;

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(listResult, Is.Not.Null);
                Assert.That(listResult, Is.InstanceOf<List<Specialty>>());
                Assert.That(listResult, Has.Count.EqualTo(7));
                Assert.That(listCount, Is.EqualTo(7));
            });
        }

        [Test]
        public async Task FindByIDs_Success()
        {
            // Arrange
            var SpecialtyIds = new List<long> { 1, 2, 3 };

            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new SpecialtyRepository(_mockContext);

            // Act
            var result = await _entityRepository.FindByIDs(SpecialtyIds);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result, Is.InstanceOf<List<Specialty>>());
                Assert.That(result, Has.Count.EqualTo(3));
            });
        }
    }
}