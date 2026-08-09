using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Data.Repository;
using SmartDigitalPsico.Data.Test.Configure;
using SmartDigitalPsico.Data.Test.DataMock;
using SmartDigitalPsico.Data.Tests.Context;
using SmartDigitalPsico.Domain.EntityModels;
namespace SmartDigitalPsico.Data.Test.Repository.Principals
{
    [TestFixture]
    public class PatientMedicationInformationRepositoryTests : BaseTests
    {
        private PatientMedicationInformationRepository? _entityRepository;
        private static int totalRegister = 3;

        [SetUp]
        public override void Setup()
        {
            // Arrange 
            SetupContext();
        }
        private void SetupContext()
        {
            var mockDataPatient = PatientMockHelper.GetMock().Take(totalRegister).AsQueryable();
            var mockDataPatientList = mockDataPatient.ToList();
            var mockDataPatientList2 = PatientMockHelper.GetMockFromBogus().Take(totalRegister).AsQueryable().ToList();

            var mockDataListUser = UserMockHelper.GetMock().AsQueryable();
            var mockDataListMedical = MedicalMockHelper.GetMock().AsQueryable();
            var mockDataListGender = GenderMockHelper.GetMock().AsQueryable();

            // Arrange
            _mockContext = new SmartDigitalPsicoDataContextTest();
            _mockContext.Users.AddRange(mockDataListUser);
            _mockContext.Medicals.AddRange(mockDataListMedical);
            _mockContext.Genders.AddRange(mockDataListGender);
            _mockContext.SaveChanges();
            _mockContext.Patients.AddRange(mockDataPatientList);
            _mockContext.SaveChanges();
            _mockContext.Patients.AddRange(mockDataPatientList2);
            _mockContext.SaveChanges();

            var mockDataPatientRecordlist = PatientMedicationInformationMockHelper.GetMockFromBogus().Take(totalRegister).AsQueryable().ToList();
            _mockContext.PatientMedicationInformations.AddRange(mockDataPatientRecordlist);
            _mockContext.SaveChanges();
        }

        // Cenário: existem informações de medicação persistidas no contexto.
        // Objetivo: retornar todas as PatientMedicationInformation cadastradas.
        [Test]
        public async Task FindAll_ExistingRecords_ReturnsAllRecords()
        {
            // Arrange
            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new PatientMedicationInformationRepository(_mockContext);

            // Act
            var listResult = await _entityRepository.FindAll();
            var listCount = _mockContext.PatientMedicationInformations.ToList().Count;

            // Assert
            using (Assert.EnterMultipleScope())
            {
                Assert.That(listResult, Is.Not.Null);
                Assert.That(listResult, Is.InstanceOf<List<PatientMedicationInformation>>());
                Assert.That(listResult, Has.Count.EqualTo(3));
                Assert.That(listCount, Is.EqualTo(3));
            }
        }

        // Cenário: existe um paciente com informações de medicação associadas.
        // Objetivo: retornar apenas as PatientMedicationInformation do paciente informado.
        [Test]
        public async Task FindAllByPatient_ExistingPatient_ReturnsMatchingRecords()
        {
            // Arrange 
            var mockDataPatient = PatientMockHelper.GetMock().Take(1).AsQueryable().First();

            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new PatientMedicationInformationRepository(_mockContext);

            // Act
            var result = await _entityRepository.FindAllByPatient(mockDataPatient.Id);

            // Assert
            using (Assert.EnterMultipleScope())
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result, Is.InstanceOf<List<PatientMedicationInformation>>());
                Assert.That(result, Has.Count.EqualTo(2));
            }
        }

        // Cenário: existe uma PatientMedicationInformation com paciente, médico e usuário criador.
        // Objetivo: retornar o registro pelo ID com navegação carregada.
        [Test]
        public async Task FindByID_ExistingId_ReturnsPatientMedicationInformation()
        {
            // Arrange
            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new PatientMedicationInformationRepository(_mockContext);
            var mockData = _mockContext.PatientMedicationInformations
                .Include(e => e.Patient)
                .ThenInclude(e => e!.Medical)
                .ThenInclude(e => e!.User)
                .Include(e => e.CreatedUser)
                .First();

            // Act
            var result = await _entityRepository.FindByID(mockData.Id);

            // Assert
            using (Assert.EnterMultipleScope())
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result, Is.InstanceOf<PatientMedicationInformation>());
                Assert.That(result.Id, Is.EqualTo(mockData.Id));
                Assert.That(result.Patient, Is.Not.Null);
                Assert.That(result.CreatedUser, Is.Not.Null);
                Assert.That(result.Patient?.Medical, Is.Not.Null);
            }
        }
    }
}
