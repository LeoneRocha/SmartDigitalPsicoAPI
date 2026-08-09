using SmartDigitalPsico.Data.Context.Mock;
using SmartDigitalPsico.Data.Repository;
using SmartDigitalPsico.Data.Test.Configure;
using SmartDigitalPsico.Data.Test.DataMock;
using SmartDigitalPsico.Data.Tests.Context;

using SmartDigitalPsico.Domain.EntityModels;

using SmartDigitalPsico.Data.Context.Configure;
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

        // Cenário: usuários persistidos no contexto de teste.
        // Objetivo: garantir que FindAll retorne todos os registros cadastrados.
        [Test]
        public async Task FindAll_ExistingUsers_ReturnsAllRecords()
        {
            // Arrange
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new UserRepository(_mockContext);

            // Act
            var listResult = await _entityRepository.FindAll();
            var listCount = listResult.Count;

            // Assert
            using (Assert.EnterMultipleScope())
            {
                Assert.That(listResult, Is.Not.Null);
                Assert.That(listResult, Is.InstanceOf<List<User>>());
                Assert.That(listResult, Has.Count.EqualTo(5));
                Assert.That(listCount, Is.EqualTo(5));
            }
        }

        // Cenário: busca por login de usuário administrador.
        // Objetivo: garantir que FindByLogin retorne o usuário sem Medical.
        [Test]
        public async Task FindByLogin_AdminUser_ReturnsUserWithoutMedical()
        {
            // Arrange
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new UserRepository(_mockContext);

            var mockDataUser = UserMockHelper.GetMock().AsQueryable().ToList()[0];

            // Act
            var result = await _entityRepository.FindByLogin(mockDataUser.Login);

            // Assert
            using (Assert.EnterMultipleScope())
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result?.Login, Is.EqualTo(mockDataUser.Login));
                Assert.That(result?.UserRoleGroups, Is.Not.Null);
                Assert.That(result?.Medical, Is.Null);
            }
        }

        // Cenário: busca por login de usuário médico.
        // Objetivo: garantir que FindByLogin retorne o usuário com Medical.
        [Test]
        public async Task FindByLogin_MedicalUser_ReturnsUserWithMedical()
        {
            // Arrange
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new UserRepository(_mockContext);

            var mockDataUser = UserMockHelper.GetMock().AsQueryable().ToList()[1];

            // Act
            var result = await _entityRepository.FindByLogin(mockDataUser.Login);

            // Assert
            using (Assert.EnterMultipleScope())
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result?.Login, Is.EqualTo(mockDataUser.Login));
                Assert.That(result?.UserRoleGroups, Is.Not.Null);
                Assert.That(result?.Medical, Is.Not.Null);
            }
        }

        // Cenário: verificação de existência por login cadastrado.
        // Objetivo: garantir que UserExists retorne true.
        [Test]
        public async Task UserExists_ExistingLogin_ReturnsTrue()
        {
            // Arrange
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new UserRepository(_mockContext);

            var mockDataUser = UserMockHelper.GetMock().AsQueryable().ToList()[0];

            // Act
            var result = await _entityRepository.UserExists(mockDataUser.Login);

            // Assert
            Assert.That(result, Is.True);
        }

        // Cenário: busca por Id de usuário existente.
        // Objetivo: garantir que FindByID retorne o usuário com RoleGroups.
        [Test]
        public async Task FindByID_ExistingId_ReturnsUser()
        {
            // Arrange
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new UserRepository(_mockContext);

            var mockDataUser = UserMockHelper.GetMock().AsQueryable().ToList()[0];

            // Act
            var result = await _entityRepository.FindByID(mockDataUser.Id);

            // Assert
            using (Assert.EnterMultipleScope())
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Id, Is.EqualTo(mockDataUser.Id));
                Assert.That(result.UserRoleGroups, Is.Not.Null);
                Assert.That(result.Medical, Is.Null);
            }
        }

        // Cenário: busca por e-mail de usuário existente.
        // Objetivo: garantir que FindByEmail retorne o usuário correspondente.
        [Test]
        public async Task FindByEmail_ExistingEmail_ReturnsUser()
        {
            // Arrange
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new UserRepository(_mockContext);

            var mockDataUser = UserMockHelper.GetMock().AsQueryable().ToList()[0];

            // Act
            var result = await _entityRepository.FindByEmail(mockDataUser.Email);

            // Assert
            using (Assert.EnterMultipleScope())
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result?.Id, Is.EqualTo(mockDataUser.Id));
                Assert.That(result?.UserRoleGroups, Is.Not.Null);
                Assert.That(result?.Medical, Is.Null);
            }
        }

        // Cenário: atualização de informações de usuário existente.
        // Objetivo: garantir que RefreshUserInfo persista o nome atualizado.
        [Test]
        public async Task RefreshUserInfo_UserExists_ReturnsUpdatedUser()
        {
            // Arrange
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new UserRepository(_mockContext);

            var mockDataUser = UserMockHelper.GetMock().AsQueryable().ToList()[1];

            mockDataUser.Name = "Updated Medical";

            // Act
            var result = await _entityRepository.RefreshUserInfo(mockDataUser);

            // Assert
            using (Assert.EnterMultipleScope())
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Id, Is.EqualTo(mockDataUser.Id));
                Assert.That(result.Name, Is.EqualTo(mockDataUser.Name));
            }
        }
    }
}
