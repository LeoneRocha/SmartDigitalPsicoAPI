using SmartDigitalPsico.Data.ConfigureFluentAPI.Mock;
using SmartDigitalPsico.Data.Repository.Principals;
using SmartDigitalPsico.Data.Test.Configure;
using SmartDigitalPsico.Data.Test.DataMock;
using SmartDigitalPsico.Data.Tests.Context;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Resiliency;

namespace SmartDigitalPsico.Data.Test.Repository.Principals
{
    [TestFixture]
    public class UserRepositoryTests : BaseTests
    {
        private UserRepository? _entityRepository;

        [SetUp]
        public override void Setup()
        {
            // Arrange 
            SetupContext();
        }
        private void SetupContext()
        {
            var mockDataListUser = UserMockHelper.GetMock().AsQueryable().ToList();
            var mockDataListMedical = MedicalMockHelper.GetMock().AsQueryable().ToList();
            var mockDataListMedical2 = MedicalMockHelper.GetMockFromBogus().Take(3).AsQueryable().ToList();

            var mockDataListPatient = PatientMockHelper.GetMock().AsQueryable().ToList();
            var mockDataListPatient2 = PatientMockHelper.GetMockFromBogus().AsQueryable().ToList();

            var mockDataListRoleGroup = RoleGroupMockData.GetMock().Take(6).AsQueryable().ToList();

            var mockDataListRoleGroupUsers = RoleGroupUserMockData.GetMockUnitTest().Take(3).AsQueryable().ToList();

            var mockDataListUser2 = UserMockHelper.GetMockFromBogus().AsQueryable().ToList();

            // Arrange
            _mockContext = new SmartDigitalPsicoDataContextTest();
            _mockContext.RoleGroups.AddRange(mockDataListRoleGroup);
            _mockContext.Users.AddRange(mockDataListUser);
            _mockContext.Medicals.AddRange(mockDataListMedical);
            _mockContext.Patients.AddRange(mockDataListPatient);
             

            _mockContext.SaveChanges();
            _mockContext.Medicals.AddRange(mockDataListMedical2);
            _mockContext.Patients.AddRange(mockDataListPatient2);
            _mockContext.SaveChanges();

            _mockContext.Users.AddRange(mockDataListUser2);
            _mockContext.SaveChanges();

            _mockContext.RoleGroupUsers.AddRange(mockDataListRoleGroupUsers);
            _mockContext.SaveChanges();
        }

        [Test]
        public async Task FindAll_Success()
        {
            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new UserRepository(_mockContext);

            // Act
            var listResult = await _entityRepository.FindAll();
            var listCount = listResult.Count;

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(listResult, Is.Not.Null);
                Assert.That(listResult, Is.InstanceOf<List<User>>());
                Assert.That(listResult, Has.Count.EqualTo(5));
                Assert.That(listCount, Is.EqualTo(5));
            });
        }

        [Test]
        public async Task FindByLogin_Success_Admin()
        {
            // Arrange
            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new UserRepository(_mockContext);

            var mockDataUser = UserMockHelper.GetMock().AsQueryable().ToList()[0];

            // Act
            var result = await _entityRepository.FindByLogin(mockDataUser.Login);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result?.Login, Is.EqualTo(mockDataUser.Login));
                Assert.That(result?.UserRoleGroups, Is.Not.Null);
                Assert.That(result?.Medical, Is.Null);
            });
        }

        [Test]
        public async Task FindByLogin_Success_Medical()
        {
            // Arrange
            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new UserRepository(_mockContext);

            var mockDataUser = UserMockHelper.GetMock().AsQueryable().ToList()[1];

            // Act
            var result = await _entityRepository.FindByLogin(mockDataUser.Login);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result?.Login, Is.EqualTo(mockDataUser.Login));
                Assert.That(result?.UserRoleGroups, Is.Not.Null);
                Assert.That(result?.Medical, Is.Not.Null);
            });
        }

        [Test]
        public async Task UserExists_Success_ReturnsTrue()
        {
            // Arrange
            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new UserRepository(_mockContext);

            var mockDataUser = UserMockHelper.GetMock().AsQueryable().ToList()[0];

            // Act
            var result = await _entityRepository.UserExists(mockDataUser.Login);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public async Task FindByID_Success_ReturnsUser()
        {
            // Arrange
            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new UserRepository(_mockContext);

            var mockDataUser = UserMockHelper.GetMock().AsQueryable().ToList()[0];

            // Act
            var result = await _entityRepository.FindByID(mockDataUser.Id);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Id, Is.EqualTo(mockDataUser.Id));
                Assert.That(result.UserRoleGroups, Is.Not.Null);
                Assert.That(result.Medical, Is.Null);
            });
        }

        [Test]
        public async Task FindByEmail_Success_ReturnsUser()
        {
            // Arrange
            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new UserRepository(_mockContext);

            var mockDataUser = UserMockHelper.GetMock().AsQueryable().ToList()[0];

            // Act
            var result = await _entityRepository.FindByEmail(mockDataUser.Email);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result?.Id, Is.EqualTo(mockDataUser.Id));
                Assert.That(result?.UserRoleGroups, Is.Not.Null);
                Assert.That(result?.Medical, Is.Null);
            });
        }

        [Test]
        public async Task RefreshUserInfo_UserExists_ReturnsUpdatedUser()
        {
            // Arrange
            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new UserRepository(_mockContext);

            var mockDataUser = UserMockHelper.GetMock().AsQueryable().ToList()[1];

            mockDataUser.Name = "Updated Medical";

            // Act
            var result = await _entityRepository.RefreshUserInfo(mockDataUser);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Id, Is.EqualTo(mockDataUser.Id));
                Assert.That(result.Name, Is.EqualTo(mockDataUser.Name));
            });
        }
    }
}