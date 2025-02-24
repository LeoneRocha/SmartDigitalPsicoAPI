using SmartDigitalPsico.Data.Repository.Principals;
using SmartDigitalPsico.Data.Test.Configure;
using SmartDigitalPsico.Data.Test.DataMock;
using SmartDigitalPsico.Data.Tests.Context;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Resiliency;

namespace SmartDigitalPsico.Data.Test.Repository.Principals
{
    [TestFixture]
    public class MedicalFileRepositoryTests : BaseTests
    {
        private MedicalFileRepository? _entityRepository;
        private static int totalRegister = 3;
        [SetUp]
        public override void Setup()
        {
            var mockData = MedicalFileMockHelper.GetMockFromBogus().Take(totalRegister).AsQueryable();
            // Arrange 
            SetupContext(mockData);
        }
        private void SetupContext(IQueryable<MedicalFile> mockData)
        {
            var mockDataListUser = UserMockHelper.GetMock().AsQueryable().ToList();
            var mockDataListUser2 = UserMockHelper.GetMockFromBogus().AsQueryable().ToList();
             
            var mockDataListMedical = MedicalMockHelper.GetMock().AsQueryable().ToList();
            var mockDataListMedical2 = MedicalMockHelper.GetMockFromBogus().Take(3).AsQueryable().ToList();
             
            var mockDataList = mockData.ToList();
            // Arrange
            _mockContext = new SmartDigitalPsicoDataContextTest();
            _mockContext.Users.AddRange(mockDataListUser);
            _mockContext.Medicals.AddRange(mockDataListMedical);
            _mockContext.SaveChanges();

            _mockContext.Users.AddRange(mockDataListUser2);
            _mockContext.Medicals.AddRange(mockDataListMedical2); 
            _mockContext.SaveChanges();

            _mockContext.MedicalFiles.AddRange(mockDataList);
            _mockContext.SaveChanges();
        }

        [Test]
        public async Task FindAll_Success()
        {
            // Arrange
            var mockDataList = MedicalFileMockHelper.GetMockFromBogus().Take(totalRegister).AsQueryable();
            SetupContext(mockDataList);

            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new MedicalFileRepository(_mockContext);

            // Act
            var listResult = await _entityRepository.FindAll(); 

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(listResult, Is.Not.Null);
                Assert.That(listResult, Is.InstanceOf<List<MedicalFile>>());
                Assert.That(listResult, Has.Count.GreaterThanOrEqualTo(1)); 
            });
        }
        [Test]
        public async Task FindAllByMedical_Success()
        {
            // Arrange 
            var mockDataList = MedicalFileMockHelper.GetMockFromBogus().Take(totalRegister).AsQueryable().ToList();
            SetupContext(mockDataList.AsQueryable());

            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new MedicalFileRepository(_mockContext);

            // Act
            var listResult = await _entityRepository.FindAllByMedical(mockDataList[0].MedicalId);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(listResult, Is.Not.Null);
                Assert.That(listResult, Is.InstanceOf<List<MedicalFile>>());
                Assert.That(listResult, Has.Count.EqualTo(2));
                Assert.That(listResult.All(f => f.MedicalId == mockDataList[0].MedicalId), Is.True);
            });
        }

        [Test]
        public async Task FindByID_Success()
        {
            // Arrange 
            var mockDataList = MedicalFileMockHelper.GetMockFromBogus().Take(totalRegister).AsQueryable().ToList();
            SetupContext(mockDataList.AsQueryable());

            var mockData = mockDataList[0];

            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new MedicalFileRepository(_mockContext);

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