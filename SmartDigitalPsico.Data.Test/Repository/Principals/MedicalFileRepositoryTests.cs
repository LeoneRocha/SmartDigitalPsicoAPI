using SmartDigitalPsico.Data.Repository.Principals;
using SmartDigitalPsico.Data.Test.Configure;
using SmartDigitalPsico.Data.Test.DataMock;
using SmartDigitalPsico.Data.Tests.Context;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;

using SmartDigitalPsico.Domain.ModelEntity;

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

        // Cenário: existem arquivos de médico persistidos no contexto.
        // Objetivo: retornar os MedicalFile cadastrados.
        [Test]
        public async Task FindAll_ExistingRecords_ReturnsAllRecords()
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
            using (Assert.EnterMultipleScope())
            {
                Assert.That(listResult, Is.Not.Null);
                Assert.That(listResult, Is.InstanceOf<List<MedicalFile>>());
                Assert.That(listResult, Has.Count.GreaterThanOrEqualTo(1)); 
            }
        }

        // Cenário: existe um médico com arquivos associados.
        // Objetivo: retornar apenas os MedicalFile do médico informado.
        [Test]
        public async Task FindAllByMedical_ExistingMedical_ReturnsMatchingRecords()
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
            using (Assert.EnterMultipleScope())
            {
                Assert.That(listResult, Is.Not.Null);
                Assert.That(listResult, Is.InstanceOf<List<MedicalFile>>());
                Assert.That(listResult, Has.Count.EqualTo(2));
                Assert.That(listResult.All(f => f.MedicalId == mockDataList[0].MedicalId), Is.True);
            }
        }

        // Cenário: existe um MedicalFile com ID conhecido.
        // Objetivo: retornar o arquivo correspondente ao ID informado.
        [Test]
        public async Task FindByID_ExistingId_ReturnsMedicalFile()
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
            using (Assert.EnterMultipleScope())
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Id, Is.EqualTo(mockData.Id));

            }
        }
    }
}
