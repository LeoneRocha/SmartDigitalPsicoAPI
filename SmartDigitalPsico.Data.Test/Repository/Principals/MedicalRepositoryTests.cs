using SmartDigitalPsico.Data.ConfigureFluentAPI.Mock;
using SmartDigitalPsico.Data.Repository.Principals;
using SmartDigitalPsico.Data.Test.Configure;
using SmartDigitalPsico.Data.Test.DataMock;
using SmartDigitalPsico.Data.Tests.Context;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Test.Repository.Principals
{
    [TestFixture]
    public class MedicalRepositoryTests : BaseTests
    {
        private MedicalRepository? _entityRepository;
        private static int totalRegister = 3;

        [SetUp]
        public override void Setup()
        {
            // Arrange 
            SetupContext();
        }
        private void SetupContext()
        {
            var mockDataListUser = UserMockHelper.GetMock().AsQueryable();
            var mockDataListMedical = MedicalMockHelper.GetMock().AsQueryable();
            var mockDataListGender = GenderMockHelper.GetMock().AsQueryable();

            var mockDataListOffices = OfficeMockData.GetMock().AsQueryable();
            var mockDataListSpecialty = SpecialtyMockData.GetMock().AsQueryable();
             
            var mockDataList2 = MedicalMockHelper.GetMockFromBogus().Take(3).AsQueryable();
             
            var mockDataListMedicalSpecialties = MedicalSpecialtyMockData.GetMock().Take(3).AsQueryable();
            // Arrange
            _mockContext = new SmartDigitalPsicoDataContextTest();
            _mockContext.Users.AddRange(mockDataListUser);
            _mockContext.Medicals.AddRange(mockDataListMedical);
            _mockContext.Genders.AddRange(mockDataListGender);
              
            _mockContext.Offices.AddRange(mockDataListOffices);
            _mockContext.Specialties.AddRange(mockDataListSpecialty);
            _mockContext.SaveChanges();

            _mockContext.Medicals.AddRange(mockDataList2);
            _mockContext.SaveChanges();

            _mockContext.MedicalSpecialties.AddRange(mockDataListMedicalSpecialties);
            _mockContext.SaveChanges();
        }

        [Test]
        public async Task FindAll_Success()
        {
            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new MedicalRepository(_mockContext);

            // Act
            var listResult = await _entityRepository.FindAll();
            var listCount = listResult.Count;

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(listResult, Is.Not.Null);
                Assert.That(listResult, Is.InstanceOf<List<Medical>>());
                Assert.That(listResult, Has.Count.EqualTo(4));
                Assert.That(listCount, Is.EqualTo(4));
            });
        }

        [Test]
        public async Task Exists_WithExistingAccreditation_ReturnsTrue()
        {
            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new MedicalRepository(_mockContext);

            // Arrange
            var mockData  = MedicalMockHelper.GetMock().AsQueryable().First();
             
            var accreditation = mockData.Accreditation; 

            // Act
            var result = await _entityRepository.Exists(accreditation);

            // Assert
            Assert.That(result, Is.True);  
        }

        [Test]
        public async Task FindByID_Success_ReturnsMedical()
        {
            // Arrange 
            var mockData = MedicalMockHelper.GetMock().AsQueryable().First();

            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new MedicalRepository(_mockContext);

            // Act
            var result = await _entityRepository.FindByID(mockData.Id);

            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result, Is.InstanceOf<Medical>());
                Assert.That(result.Id, Is.EqualTo(mockData.Id)); 
                Assert.That(result.CreatedUser, Is.Not.Null);
                Assert.That(result.Office, Is.Not.Null);
                Assert.That(result.MedicalSpecialties, Is.Not.Null);
                Assert.That(result.MedicalSpecialties, Has.Count.EqualTo(1));
            });
        }

        [Test]
        public async Task FindByAccreditation_Success_ReturnsMedical()
        {
            // Arrange 
            var mockData = MedicalMockHelper.GetMock().AsQueryable().First();

            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new MedicalRepository(_mockContext);

            // Act
            var result = await _entityRepository.FindByAccreditation(mockData.Accreditation);

            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result, Is.InstanceOf<Medical>());
                Assert.That(result?.Id, Is.EqualTo(mockData.Id));
                Assert.That(result?.Accreditation, Is.EqualTo(mockData.Accreditation));
                Assert.That(result?.CreatedUser, Is.Not.Null);
                Assert.That(result?.Office, Is.Not.Null);
                Assert.That(result?.MedicalSpecialties, Is.Not.Null);
                Assert.That(result?.MedicalSpecialties, Has.Count.EqualTo(1));
            });
        }


        [Test]
        public async Task FindByEmail_Success_ReturnsMedical()
        {
            // Arrange 
            var mockData = MedicalMockHelper.GetMock().AsQueryable().First();

            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new MedicalRepository(_mockContext);

            // Act
            var result = await _entityRepository.FindByEmail(mockData.Email);

            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result, Is.InstanceOf<Medical>());
                Assert.That(result?.Id, Is.EqualTo(mockData.Id));
                Assert.That(result?.Email, Is.EqualTo(mockData.Email)); 
            });
        }


    }
}
