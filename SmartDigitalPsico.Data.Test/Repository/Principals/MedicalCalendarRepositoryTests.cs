using SmartDigitalPsico.Data.Repository.Principals;
using SmartDigitalPsico.Data.Test.Configure;
using SmartDigitalPsico.Data.Test.DataMock;
using SmartDigitalPsico.Data.Tests.Context;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Resiliency;

namespace SmartDigitalPsico.Data.Test.Repository.Principals
{
    [TestFixture]
    public class MedicalCalendarRepositoryTests : BaseTests
    {
        private MedicalCalendarRepository? _entityRepository;
        private static int totalRegister = 3;
        [SetUp]
        public override void Setup()
        {
            var mockData = MedicalCalendarMockHelper.GetMockFromBogus().Take(totalRegister).AsQueryable();
            // Arrange 
            SetupContext(mockData);
        }
        private void SetupContext(IQueryable<MedicalCalendar> mockData)
        {
            var mockDataList = mockData.ToList();
            // Arrange
            _mockContext = new SmartDigitalPsicoDataContextTest();

            _mockContext.MedicalCalendars.AddRange(mockDataList);
            _mockContext.SaveChanges();
        } 

        [Test]
        public async Task FindAll_Success()
        { 
            // Arrange
            var mockDataList = MedicalCalendarMockHelper.GetMockFromBogus().Take(totalRegister).AsQueryable();
            SetupContext(mockDataList);
             
            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new MedicalCalendarRepository(_mockContext);

            // Act
            var listResult = await _entityRepository.FindAll();
            var listCount = listResult.Count;

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(listResult, Is.Not.Null);
                Assert.That(listResult, Is.InstanceOf<List<MedicalCalendar>>());
                Assert.That(listResult, Has.Count.EqualTo(3));
                Assert.That(listCount, Is.EqualTo(3));
            });
        }

    }
}