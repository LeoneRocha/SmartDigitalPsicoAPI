using SmartDigitalPsico.Data.ConfigureFluentAPI.Mock;
using SmartDigitalPsico.Data.Repository.Principals;
using SmartDigitalPsico.Data.Test.Configure;
using SmartDigitalPsico.Data.Test.DataMock;
using SmartDigitalPsico.Data.Tests.Context;
using SmartDigitalPsico.Domain.ModelEntity;

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

            var mockDataListRoleGroup = RoleGroupMockData.GetMock().Take(6).AsQueryable().ToList();

            var mockDataListRoleGroupUsers = RoleGroupUserMockData.GetMockUnitTest().Take(3).AsQueryable().ToList();

            var mockDataListUser2 = UserMockHelper.GetMockFromBogus().AsQueryable().ToList();

            // Arrange
            _mockContext = new SmartDigitalPsicoDataContextTest();
            _mockContext.RoleGroups.AddRange(mockDataListRoleGroup);
            _mockContext.Users.AddRange(mockDataListUser);
            _mockContext.Medicals.AddRange(mockDataListMedical);

            _mockContext.SaveChanges();
            _mockContext.Medicals.AddRange(mockDataListMedical2);
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
    }
}
