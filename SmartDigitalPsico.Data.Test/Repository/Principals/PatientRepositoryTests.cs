using SmartDigitalPsico.Data.Repository.Principals;
using SmartDigitalPsico.Data.Test.Configure;
using SmartDigitalPsico.Data.Test.DataMock;
using SmartDigitalPsico.Data.Tests.Context;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Resiliency;

namespace SmartDigitalPsico.Data.Test.Repository.Principals
{
    [TestFixture]
    public class PatientRepositoryTests : BaseTests
    {
        private PatientRepository? _entityRepository;
        private static int totalRegister = 1;

        [SetUp]
        public override void Setup()
        {
            // Arrange 
            SetupContext();
        }
        private void SetupContext()
        {
            var mockData = PatientMockHelper.GetMock().Take(totalRegister).AsQueryable();
            var mockDataList = mockData.ToList();
            var mockDataList2 = PatientMockHelper.GetMockFromBogus().Take(3).AsQueryable();

            var mockDataListUser = UserMockHelper.GetMock().AsQueryable();
            var mockDataListMedical = MedicalMockHelper.GetMock().AsQueryable();
            var mockDataListGender = GenderMockHelper.GetMock().AsQueryable();

            // Arrange
            _mockContext = new SmartDigitalPsicoDataContextTest();
            _mockContext.Users.AddRange(mockDataListUser);
            _mockContext.Medicals.AddRange(mockDataListMedical);
            _mockContext.Genders.AddRange(mockDataListGender);
            _mockContext.Patients.AddRange(mockDataList);
            _mockContext.SaveChanges();

            _mockContext.Patients.AddRange(mockDataList2);

            _mockContext.SaveChanges();
        }

        [Test]
        public async Task FindAll_Success()
        {
            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new PatientRepository(_mockContext, new PolicyConfig());

            // Act
            var listResult = await _entityRepository.FindAll();
            var listCount = listResult.Count;

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(listResult, Is.Not.Null);
                Assert.That(listResult, Is.InstanceOf<List<Patient>>());
                Assert.That(listResult, Has.Count.EqualTo(4));
                Assert.That(listCount, Is.EqualTo(4));
            });
        }

        [Test]
        public async Task FindByPatient_By_CPF_Success_ReturnsPatient()
        {
            // Arrange 
            var mockData = PatientMockHelper.GetMock().Take(totalRegister).AsQueryable().First();

            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new PatientRepository(_mockContext, new PolicyConfig());

            var patientFind = new Patient
            {
                Cpf = mockData.Cpf
            };

            // Act
            var result = await _entityRepository.FindByPatient(patientFind);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result, Is.InstanceOf<Patient>());
                Assert.That(result.Cpf, Is.EqualTo(mockData.Cpf));
            });
        }
        [Test]
        public async Task FindByPatient_By_Rg_Success_ReturnsPatient()
        {
            // Arrange 
            var mockData = PatientMockHelper.GetMock().Take(totalRegister).AsQueryable().First();

            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new PatientRepository(_mockContext, new PolicyConfig());

            var patientFind = new Patient
            {
                Rg = mockData.Rg
            };

            // Act
            var result = await _entityRepository.FindByPatient(patientFind);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result, Is.InstanceOf<Patient>());
                Assert.That(result.Cpf, Is.EqualTo(mockData.Cpf));
            });
        }
        [Test]
        public async Task FindByPatient_By_Email_Success_ReturnsPatient()
        {
            // Arrange 
            var mockData = PatientMockHelper.GetMock().Take(totalRegister).AsQueryable().First();

            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new PatientRepository(_mockContext, new PolicyConfig());

            var patientFind = new Patient
            {
                Email = mockData.Email
            };

            // Act
            var result = await _entityRepository.FindByPatient(patientFind);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result, Is.InstanceOf<Patient>());
                Assert.That(result.Cpf, Is.EqualTo(mockData.Cpf));
            });
        }

        [Test]
        public async Task FindByID_Success_ReturnsPatient()
        {
            // Arrange 
            var mockData = PatientMockHelper.GetMock().Take(totalRegister).AsQueryable().First();

            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new PatientRepository(_mockContext, new PolicyConfig());

            // Act
            var result = await _entityRepository.FindByID(mockData.Id);

            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result, Is.InstanceOf<Patient>());
                Assert.That(result.Id, Is.EqualTo(mockData.Id));
                Assert.That(result.Medical, Is.Not.Null);
                Assert.That(result.Gender, Is.Not.Null);
                Assert.That(result.CreatedUser, Is.Not.Null);
            });
        }
        [Test]
        public async Task FindByEmail_Success_ReturnsPatient()
        {
            // Arrange 
            var mockData = PatientMockHelper.GetMock().Take(totalRegister).AsQueryable().First();

            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new PatientRepository(_mockContext, new PolicyConfig());

            // Act
            var result = await _entityRepository.FindByEmail(mockData.Email);

            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result, Is.InstanceOf<Patient>());
                Assert.That(result?.Email, Is.EqualTo(mockData.Email));
            });
        }
        [Test]
        public async Task FindAllByMedicalId_Success_ReturnsPatient()
        {
            // Arrange 
            var mockData = PatientMockHelper.GetMock().Take(totalRegister).AsQueryable().First();

            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new PatientRepository(_mockContext, new PolicyConfig());

            // Act
            var listResult = await _entityRepository.FindAllByMedicalId(mockData.MedicalId);

            Assert.Multiple(() =>
            {
                Assert.That(listResult, Is.Not.Null);
                Assert.That(listResult, Is.InstanceOf<List<Patient>>()); 
                Assert.That(listResult, Has.Count.EqualTo(4)); 
                Assert.That(listResult[0].MedicalId, Is.EqualTo(mockData.MedicalId));
                Assert.That(listResult[0].Medical, Is.Not.Null);
                Assert.That(listResult[0].Gender, Is.Not.Null);
                Assert.That(listResult[0].CreatedUser, Is.Not.Null);
            });
        }
    }
}
