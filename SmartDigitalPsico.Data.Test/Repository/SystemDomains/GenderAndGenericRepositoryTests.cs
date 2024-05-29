using Bogus;
using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Data.ConfigureFluentAPI.Mock;
using SmartDigitalPsico.Data.Repository.SystemDomains;
using SmartDigitalPsico.Data.Test.Configure;
using SmartDigitalPsico.Data.Test.DataMock;
using SmartDigitalPsico.Data.Tests.Context;
using SmartDigitalPsico.Domain.ModelEntity;
using System.Linq.Expressions;

namespace SmartDigitalPsico.Data.Test.Repository.SystemDomains
{
    [TestFixture]
    public class GenderAndGenericRepositoryTests : BaseTests
    {
        private GenderRepository? _entityRepository;

        [SetUp]
        public override void Setup()
        {
            var mockData = GenderMockHelper.GetMock().AsQueryable();
            // Arrange 
            SetupContext(mockData);
        }
        private void SetupContext(IQueryable<Gender> mockData)
        {
            var mockDataList = mockData.ToList();
            // Arrange
            _mockContext = new SmartDigitalPsicoDataContextTest();

            _mockContext.Genders.AddRange(mockDataList);
            _mockContext.SaveChanges();
        }

        [Test]
        public async Task Create_Success()
        {
            // Arrange
            var mockFull = GenderMockHelper.GetMock().AsQueryable();
            SetupContext(mockFull);
            var mockData = GenderMockHelper.GetMock().Take(1).AsQueryable().First();
            var data = createNewEntity(mockData);

            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new GenderRepository(_mockContext);

            // Act
            var result = await _entityRepository.Create(data);
            var target = await _mockContext.Genders.FirstAsync(e => e.Description.Equals(data.Description, StringComparison.OrdinalIgnoreCase));

            //Assert  
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.EqualTo(data));
                Assert.That(target, Is.Not.Null);
            });
        }

        [Test]
        public void Create_Error()
        {
            var mockFull = GenderMockHelper.GetMock().AsQueryable();
            SetupContext(mockFull);

            var mockData = GenderMockHelper.GetMock().Take(1).AsQueryable().First();

            var data = createNewEntity(mockData);
            data.Id = 1L;

            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new GenderRepository(_mockContext);

            Assert.ThrowsAsync<InvalidOperationException>(async () =>
            {
                await _entityRepository.Create(data);
            });
        }


        [Test]
        public async Task Create_Success_With_Bogus()
        {
            // Arrange
            var faker = new Faker<Gender>("pt_BR")
                .RuleFor(g => g.Description, f => string.Join(" ", f.Lorem.Words(3))) // Gera uma frase com 7 palavras
                .RuleFor(g => g.Language, f => f.Random.String2(10)); // Respeita o limite de 10 caracteres

            var data = faker.Generate();

            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new GenderRepository(_mockContext);

            // Act
            var result = await _entityRepository.Create(data);

            var target = await _mockContext.Genders.FirstAsync(e => e.Id == data.Id);

            //Assert  
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.EqualTo(data));
                Assert.That(target, Is.Not.Null);
            });
        }

        [Test]
        public async Task FindAll_Success()
        {
            // Arrange
            var mockDataList = GenderMockHelper.GetMock();

            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new GenderRepository(_mockContext);

            // Act
            var listResult = await _entityRepository.FindAll();
            var listCount = listResult.Count;

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(listResult, Is.Not.Null);
                Assert.That(listResult, Is.InstanceOf<List<Gender>>());
                Assert.That(listResult, Has.Count.EqualTo(2));
                Assert.That(listCount, Is.EqualTo(2));
            });
        }

        [Test]
        public async Task FindByID_Success()
        {
            // Arrange
            var mockDataList = GenderMockHelper.GetMock();
            var mockData = mockDataList.Take(1).AsQueryable();
            var idToFind = mockData.First().Id;

            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new GenderRepository(_mockContext);

            // Act
            var result = await _entityRepository.FindByID(idToFind);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Id, Is.EqualTo(idToFind));
            });
        }

        [Test]
        public async Task Update_Success()
        {
            // Arrange
            var mockFull = GenderMockHelper.GetMock().AsQueryable();
            SetupContext(mockFull);

            var mockData = GenderMockHelper.GetMock().Take(1).AsQueryable().First();
            var mockDataUpdate = createNewEntity(mockData);
            mockDataUpdate.Id = mockData.Id;
            mockDataUpdate.Description = "Description teste";

            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new GenderRepository(_mockContext);

            // Act
            var result = await _entityRepository.Update(mockDataUpdate);

            var target = await _mockContext.Genders.FirstOrDefaultAsync(e => e.Id == result.Id);

            //Assert  
            Assert.Multiple(() =>
            {
                Assert.That(target, Is.Not.Null);
                Assert.That(target?.Id, Is.EqualTo(mockDataUpdate.Id));
                Assert.That(mockDataUpdate.Description, Is.EqualTo(target?.Description));
            });
        }

        [Test]
        public void Update_Failure_RegisterNotFound()
        {
            // Arrange
            var mockFull = GenderMockHelper.GetMock().AsQueryable();
            SetupContext(mockFull);

            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new GenderRepository(_mockContext);

            // Arrange
            var nonExistingGender = new Gender { Id = 999, Description = "Non-Existing Gender" };

            // Act & Assert
            Assert.ThrowsAsync<InvalidOperationException>(async () => await _entityRepository.Update(nonExistingGender));
        }

        [Test]
        public async Task Delete_Success()
        {
            // Arrange
            var mockFull = GenderMockHelper.GetMock().AsQueryable();
            SetupContext(mockFull);
            var mockData = GenderMockHelper.GetMock().Take(1).AsQueryable().First();

            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new GenderRepository(_mockContext);

            // Act
            var result = await _entityRepository.Delete(mockData.Id);

            var target = await _mockContext.Genders.FirstOrDefaultAsync(e => e.Id == mockData.Id);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.True);
                Assert.That(target, Is.Null);
            });
        }


        [Test]
        public async Task EnableOrDisable_UpdatesEntityAndReturnsTrue()
        {
            // Arrange
            var mockFull = GenderMockHelper.GetMock().AsQueryable();
            SetupContext(mockFull);
            var mockData = GenderMockHelper.GetMock().Take(1).AsQueryable().First();

            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new GenderRepository(_mockContext);

            // Act
            var result = await _entityRepository.EnableOrDisable(mockData.Id);

            var target = await _mockContext.Genders.FirstOrDefaultAsync(e => e.Id == mockData.Id);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.True);
                Assert.That(mockData.Enable, Is.True);
                Assert.That(target?.Enable, Is.False);
            });
        }

        [Test]
        public async Task Exists_EntityExists_ReturnsTrue()
        {
            // Arrange: Set up your test data and context
            var mockFull = GenderMockHelper.GetMock().AsQueryable();
            SetupContext(mockFull);
            var mockData = GenderMockHelper.GetMock().Take(1).AsQueryable().First();

            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new GenderRepository(_mockContext);

            // Act
            var result = await _entityRepository.Exists(mockData.Id);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public async Task FindExistsByID_EntityExists_ReturnsNoException()
        {
            // Arrange
            var mockFull = GenderMockHelper.GetMock().AsQueryable();
            SetupContext(mockFull);
            var mockData = GenderMockHelper.GetMock().Take(1).AsQueryable().First();

            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new GenderRepository(_mockContext);

            // Act 
            // Assert
            await _entityRepository.FindExistsByID(mockData.Id);
            // Act 
            // Assert
            Assert.DoesNotThrowAsync(async () =>
            {
                await _entityRepository.FindExistsByID(mockData.Id);
            });
        }

        [Test]
        public async Task FindByCustomWhere_Success()
        {
            // Arrange            
            var mockFull = GenderMockHelper.GetMock().AsQueryable();
            SetupContext(mockFull);
            var mockData = GenderMockHelper.GetMock().Take(1).AsQueryable().First();

            // Arrange
            Expression<Func<Gender, bool>> predicate = g => g.Id == 1;

            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new GenderRepository(_mockContext);

            // Act
            var listResult = await _entityRepository.FindByCustomWhere(predicate);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(listResult, Is.Not.Null);
                Assert.That(listResult, Is.InstanceOf<List<Gender>>());
                Assert.That(listResult, Has.Count.EqualTo(1));
            });
        }

        [Test]
        public async Task FindByCustomWhereWithIncludes_Success()
        {
            // Arrange            
            var mockFull = GenderMockHelper.GetMock().AsQueryable();

            mockFull.First().Patients = new List<Patient>() { PatientMockData.GetMock()[0] };

            SetupContext(mockFull);
            var mockData = GenderMockHelper.GetMock().Take(1).AsQueryable().First();

            // Arrange
            Expression<Func<Gender, bool>> predicate = g => g.Id == 1;
            Expression<Func<Gender, object>>[] includeProperties = { g => g.Patients };

            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new GenderRepository(_mockContext);

            // Act
            var listResult = await _entityRepository.FindByCustomWhereWithIncludes(predicate, includeProperties);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(listResult, Is.Not.Null);
                Assert.That(listResult, Is.InstanceOf<List<Gender>>());
                Assert.That(listResult, Has.Count.EqualTo(1));

                Assert.That(listResult.First().Patients, Is.Not.Null);
                Assert.That(listResult.First().Patients.ToList(), Is.InstanceOf<List<Patient>>());
                Assert.That(listResult.First().Patients, Has.Count.EqualTo(1));

            });
        }
        [Test]
        public async Task GetCount_Success()
        {
            // Arrange            
            var mockFull = GenderMockHelper.GetMock().AsQueryable();
            SetupContext(mockFull);

            // Arrange 
            Expression<Func<Gender, bool>> predicate = g => g.Id == 1;

            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new GenderRepository(_mockContext);

            // Act
            var result = await _entityRepository.GetCount(predicate);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.GreaterThanOrEqualTo(0));
                Assert.That(result, Is.EqualTo(1));
            });
        }

        private static Gender createNewEntity(Gender mockData)
        {
            return new Gender()
            {
                Id = int.MaxValue,
                ModifyDate = mockData.ModifyDate,
                CreatedDate = mockData.CreatedDate,
                Description = "New Gender",
                Enable = mockData.Enable,
                Language = mockData.Language,
                LastAccessDate = mockData.LastAccessDate
            };
        }
    }
}