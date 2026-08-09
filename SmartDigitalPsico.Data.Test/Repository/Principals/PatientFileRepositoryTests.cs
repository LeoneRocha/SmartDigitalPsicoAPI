using SmartDigitalPsico.Data.Repository;
using SmartDigitalPsico.Data.Test.Configure;
using SmartDigitalPsico.Data.Test.DataMock;
using SmartDigitalPsico.Data.Tests.Context;
using SmartDigitalPsico.Domain.EntityModels;
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

        // Cenário: existem arquivos de paciente persistidos no contexto.
        // Objetivo: retornar todos os PatientFile cadastrados.
        [Test]
        public async Task FindAll_ExistingRecords_ReturnsAllRecords()
        {
            // Arrange
            var mockDataList = PatientFileMockHelper.GetMockFromBogus().Take(totalRegister).AsQueryable();
            SetupContext(mockDataList);

            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new PatientFileRepository(_mockContext);

            // Act
            var listResult = await _entityRepository.FindAll();
            var listCount = listResult.Count;

            // Assert
            using (Assert.EnterMultipleScope())
            {
                Assert.That(listResult, Is.Not.Null);
                Assert.That(listResult, Is.InstanceOf<List<PatientFile>>());
                Assert.That(listResult, Has.Count.EqualTo(3));
                Assert.That(listCount, Is.EqualTo(3));
            }
        }

        // Cenário: existe um paciente com arquivos associados.
        // Objetivo: retornar apenas os PatientFile do paciente informado.
        [Test]
        public async Task FindAllByPatient_ExistingPatient_ReturnsMatchingRecords()
        {
            // Arrange 
            var mockDataList = PatientFileMockHelper.GetMockFromBogus().Take(totalRegister).AsQueryable().ToList();
            SetupContext(mockDataList.AsQueryable());

            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new PatientFileRepository(_mockContext);

            // Act
            var listResult = await _entityRepository.FindAllByPatient(mockDataList[0].PatientId);

            // Assert
            using (Assert.EnterMultipleScope())
            {
                Assert.That(listResult, Is.Not.Null);
                Assert.That(listResult, Is.InstanceOf<List<PatientFile>>());
                Assert.That(listResult, Has.Count.EqualTo(2));
                Assert.That(listResult.All(f => f.PatientId == mockDataList[0].PatientId), Is.True);
            }
        }

        // Cenário: existe um PatientFile com ID conhecido.
        // Objetivo: retornar o arquivo correspondente ao ID informado.
        [Test]
        public async Task FindByID_ExistingId_ReturnsPatientFile()
        {
            // Arrange 
            var mockDataList = PatientFileMockHelper.GetMockFromBogus().Take(totalRegister).AsQueryable().ToList();
            SetupContext(mockDataList.AsQueryable());

            var mockData = mockDataList[0];

            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new PatientFileRepository(_mockContext);

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
