using SmartDigitalPsico.Data.Repository.Principals;
using SmartDigitalPsico.Data.Test.Configure;
using SmartDigitalPsico.Data.Test.DataMock;
using SmartDigitalPsico.Data.Tests.Context;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Test.Repository.Principals
{
    [TestFixture]
    public class PatientAdditionalInformationRepositoryTests : BaseTests
    {
        private PatientAdditionalInformationRepository? _entityRepository;
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


            var mockDataPatientRecordlist = PatientAdditionalInformationMockHelper.GetMockFromBogus().Take(totalRegister).AsQueryable().ToList();
            _mockContext.PatientAdditionalInformations.AddRange(mockDataPatientRecordlist);
            _mockContext.SaveChanges();
        }

        [Test]
        public async Task FindAll_Success()
        {
            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new PatientAdditionalInformationRepository(_mockContext);

            // Act
            var listResult = await _entityRepository.FindAll();
            var listCount = _mockContext.PatientAdditionalInformations.ToList().Count;

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(listResult, Is.Not.Null);
                Assert.That(listResult, Is.InstanceOf<List<PatientAdditionalInformation>>());
                Assert.That(listResult, Has.Count.EqualTo(3));
                Assert.That(listCount, Is.EqualTo(3));
            });
        }

        [Test]
        public async Task FindAllByPatient_Success()
        {
            // Arrange 
            var mockDataPatient = PatientMockHelper.GetMock().Take(1).AsQueryable().First();

            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new PatientAdditionalInformationRepository(_mockContext);

            // Act
            var result = await _entityRepository.FindAllByPatient(mockDataPatient.Id);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result, Is.InstanceOf<List<PatientAdditionalInformation>>());
                Assert.That(result, Has.Count.EqualTo(2));
            });
        }

        [Test]
        public async Task FindByID_Success_ReturnsPatientAdditionalInformation()
        {
            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new PatientAdditionalInformationRepository(_mockContext);
            // Arrange 
            var mockData = _mockContext.PatientAdditionalInformations.First();

            // Act
            var result = await _entityRepository.FindByID(mockData.Id);

            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result, Is.InstanceOf<PatientAdditionalInformation>());
                Assert.That(result.Id, Is.EqualTo(mockData.Id));
                Assert.That(result.Patient, Is.Not.Null);
                Assert.That(result.CreatedUser, Is.Not.Null);
                Assert.That(result.Patient?.Medical, Is.Not.Null);
            });
        }
    }
}