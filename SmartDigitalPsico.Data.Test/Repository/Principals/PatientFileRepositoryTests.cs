using SmartDigitalPsico.Data.Repository.Principals;
using SmartDigitalPsico.Data.Test.Configure;
using SmartDigitalPsico.Data.Test.DataMock;
using SmartDigitalPsico.Data.Tests.Context;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Resiliency;

namespace SmartDigitalPsico.Data.Test.Repository.Principals
{
    [TestFixture]
    public class PatientFileRepositoryTests : BaseTests
    {
        private PatientFileRepository? _entityRepository;
        private static int totalRegister = 3;
        [SetUp]
        public override void Setup()
        {
            var mockData = PatientFileMockHelper.GetMockFromBogus().Take(totalRegister).AsQueryable();
            // Arrange 
            SetupContext(mockData);
        }
        private void SetupContext(IQueryable<PatientFile> mockData)
        {
            var mockDataListUser = UserMockHelper.GetMock().AsQueryable().ToList();
            var mockDataListUser2 = UserMockHelper.GetMockFromBogus().AsQueryable().ToList();

            var mockDataListMedical = MedicalMockHelper.GetMock().AsQueryable().ToList();
            var mockDataListMedical2 = MedicalMockHelper.GetMockFromBogus().Take(3).AsQueryable().ToList();

            var mockDataListPatient = PatientMockHelper.GetMock().AsQueryable().ToList();
            var mockDataListPatient2 = PatientMockHelper.GetMockFromBogus().AsQueryable().ToList();
            
            var mockDataList = mockData.ToList();
            // Arrange
            _mockContext = new SmartDigitalPsicoDataContextTest();
            _mockContext.Users.AddRange(mockDataListUser);
            _mockContext.Medicals.AddRange(mockDataListMedical);
            _mockContext.Patients.AddRange(mockDataListPatient);
            _mockContext.SaveChanges();

            _mockContext.Users.AddRange(mockDataListUser2);
            _mockContext.Medicals.AddRange(mockDataListMedical2);
            _mockContext.Patients.AddRange(mockDataListPatient2);
            _mockContext.SaveChanges();
            
            _mockContext.PatientFiles.AddRange(mockDataList);
            _mockContext.SaveChanges();
        }

        [Test]
        public async Task FindAll_Success()
        {
            // Arrange
            var mockDataList = PatientFileMockHelper.GetMockFromBogus().Take(totalRegister).AsQueryable();
            SetupContext(mockDataList);

            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new PatientFileRepository(_mockContext, new PolicyConfig());

            // Act
            var listResult = await _entityRepository.FindAll();
            var listCount = listResult.Count;

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(listResult, Is.Not.Null);
                Assert.That(listResult, Is.InstanceOf<List<PatientFile>>());
                Assert.That(listResult, Has.Count.EqualTo(3));
                Assert.That(listCount, Is.EqualTo(3));
            });
        }
        [Test]
        public async Task FindAllByPatient_Success()
        {
            // Arrange 
            var mockDataList = PatientFileMockHelper.GetMockFromBogus().Take(totalRegister).AsQueryable().ToList();
            SetupContext(mockDataList.AsQueryable());

            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new PatientFileRepository(_mockContext, new PolicyConfig());

            // Act
            var listResult = await _entityRepository.FindAllByPatient(mockDataList[0].PatientId);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(listResult, Is.Not.Null);
                Assert.That(listResult, Is.InstanceOf<List<PatientFile>>());
                Assert.That(listResult, Has.Count.EqualTo(2));
                Assert.That(listResult.All(f => f.PatientId == mockDataList[0].PatientId), Is.True);
            });
        }
        [Test]
        public async Task FindByID_Success()
        {
            // Arrange 
            var mockDataList = PatientFileMockHelper.GetMockFromBogus().Take(totalRegister).AsQueryable().ToList();
            SetupContext(mockDataList.AsQueryable());

            var mockData = mockDataList[0];
            
            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new PatientFileRepository(_mockContext, new PolicyConfig());

            // Act
            var result = await _entityRepository.FindByID(mockData.Id);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Id, Is.EqualTo(mockData.Id));

            });
        } 
    }
}