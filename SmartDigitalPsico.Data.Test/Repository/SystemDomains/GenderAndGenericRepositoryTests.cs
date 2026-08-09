using Bogus;
using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Data.Context.Configure.Mock;
using SmartDigitalPsico.Data.Repository.SystemDomains;
using SmartDigitalPsico.Data.Test.Configure;
using SmartDigitalPsico.Data.Test.DataMock;
using SmartDigitalPsico.Data.Tests.Context;
using System.Linq.Expressions;

using SmartDigitalPsico.Domain.EntityModels;

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

        // Cenário: criação de um novo gênero com dados válidos.
        // Objetivo: garantir que Create persista a entidade no contexto.
        [Test]
        public async Task Create_ValidGender_PersistsEntity()
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

            // Assert
            using (Assert.EnterMultipleScope())
            {
                Assert.That(result, Is.EqualTo(data));
                Assert.That(target, Is.Not.Null);
            }
        }

        // Cenário: tentativa de criar gênero com Id já existente.
        // Objetivo: garantir que Create lance InvalidOperationException.
        [Test]
        public void Create_DuplicateId_ThrowsInvalidOperationException()
        {
            // Arrange
            var mockFull = GenderMockHelper.GetMock().AsQueryable();
            SetupContext(mockFull);

            var mockData = GenderMockHelper.GetMock().Take(1).AsQueryable().First();

            var data = createNewEntity(mockData);
            data.Id = 1L;

            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new GenderRepository(_mockContext);

            // Act
            // Assert
            Assert.ThrowsAsync<InvalidOperationException>(async () =>
            {
                await _entityRepository.Create(data);
            });
        }

        // Cenário: criação de gênero com dados gerados por Bogus.
        // Objetivo: garantir que Create persista entidade gerada dinamicamente.
        [Test]
        public async Task Create_BogusGeneratedGender_PersistsEntity()
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

            // Assert
            using (Assert.EnterMultipleScope())
            {
                Assert.That(result, Is.EqualTo(data));
                Assert.That(target, Is.Not.Null);
            }
        }

        // Cenário: gêneros persistidos no contexto de teste.
        // Objetivo: garantir que FindAll retorne todos os registros cadastrados.
        [Test]
        public async Task FindAll_ExistingGenders_ReturnsAllRecords()
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
            using (Assert.EnterMultipleScope())
            {
                Assert.That(listResult, Is.Not.Null);
                Assert.That(listResult, Is.InstanceOf<List<Gender>>());
                Assert.That(listResult, Has.Count.EqualTo(2));
                Assert.That(listCount, Is.EqualTo(2));
            }
        }

        // Cenário: busca por Id de gênero existente.
        // Objetivo: garantir que FindByID retorne a entidade correspondente.
        [Test]
        public async Task FindByID_ExistingId_ReturnsGender()
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
            using (Assert.EnterMultipleScope())
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Id, Is.EqualTo(idToFind));
            }
        }

        // Cenário: atualização de descrição de um gênero existente.
        // Objetivo: garantir que Update persista as alterações corretamente.
        [Test]
        public async Task Update_ExistingGender_UpdatesDescription()
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

            // Assert
            using (Assert.EnterMultipleScope())
            {
                Assert.That(target, Is.Not.Null);
                Assert.That(target?.Id, Is.EqualTo(mockDataUpdate.Id));
                Assert.That(mockDataUpdate.Description, Is.EqualTo(target?.Description));
            }
        }

        // Cenário: atualização de gênero inexistente.
        // Objetivo: garantir que Update lance InvalidOperationException.
        [Test]
        public void Update_NonExistingGender_ThrowsInvalidOperationException()
        {
            // Arrange
            var mockFull = GenderMockHelper.GetMock().AsQueryable();
            SetupContext(mockFull);

            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new GenderRepository(_mockContext);

            var nonExistingGender = new Gender { Id = 999, Description = "Non-Existing Gender" };

            // Act
            // Assert
            Assert.ThrowsAsync<InvalidOperationException>(async () => await _entityRepository.Update(nonExistingGender));
        }

        // Cenário: exclusão de um gênero existente por Id.
        // Objetivo: garantir que Delete remova a entidade do contexto.
        [Test]
        public async Task Delete_ExistingId_RemovesEntity()
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
            using (Assert.EnterMultipleScope())
            {
                Assert.That(result, Is.True);
                Assert.That(target, Is.Null);
            }
        }

        // Cenário: alternância de Enable em um gênero existente.
        // Objetivo: garantir que EnableOrDisable inverta o estado e retorne true.
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
            using (Assert.EnterMultipleScope())
            {
                Assert.That(result, Is.True);
                Assert.That(mockData.Enable, Is.True);
                Assert.That(target?.Enable, Is.False);
            }
        }

        // Cenário: verificação de existência de gênero já cadastrado.
        // Objetivo: garantir que Exists retorne true para Id válido.
        [Test]
        public async Task Exists_EntityExists_ReturnsTrue()
        {
            // Arrange
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

        // Cenário: verificação de existência por Id de gênero cadastrado.
        // Objetivo: garantir que FindExistsByID não lance exceção.
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
            await _entityRepository.FindExistsByID(mockData.Id);

            // Assert
            Assert.DoesNotThrowAsync(async () =>
            {
                await _entityRepository.FindExistsByID(mockData.Id);
            });
        }

        // Cenário: filtro customizado por predicado de Id.
        // Objetivo: garantir que FindByCustomWhere retorne a lista filtrada.
        [Test]
        public async Task FindByCustomWhere_MatchingPredicate_ReturnsFilteredList()
        {
            // Arrange
            var mockFull = GenderMockHelper.GetMock().AsQueryable();
            SetupContext(mockFull);
            var mockData = GenderMockHelper.GetMock().Take(1).AsQueryable().First();

            Expression<Func<Gender, bool>> predicate = g => g.Id == 1;

            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new GenderRepository(_mockContext);

            // Act
            var listResult = await _entityRepository.FindByCustomWhere(predicate);

            // Assert
            using (Assert.EnterMultipleScope())
            {
                Assert.That(listResult, Is.Not.Null);
                Assert.That(listResult, Is.InstanceOf<List<Gender>>());
                Assert.That(listResult, Has.Count.EqualTo(1));
            }
        }

        // Cenário: filtro customizado com includes de Patients.
        // Objetivo: garantir que FindByCustomWhereWithIncludes carregue as navegações.
        [Test]
        public async Task FindByCustomWhereWithIncludes_MatchingPredicate_ReturnsListWithIncludes()
        {
            // Arrange
            var mockFull = GenderMockHelper.GetMock().AsQueryable();

            mockFull.First().Patients = new List<Patient>() { PatientMockData.GetMock()[0] };

            SetupContext(mockFull);
            var mockData = GenderMockHelper.GetMock().Take(1).AsQueryable().First();

            Expression<Func<Gender, bool>> predicate = g => g.Id == 1;
            Expression<Func<Gender, object>>[] includeProperties = { g => g.Patients };

            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new GenderRepository(_mockContext);

            // Act
            var listResult = await _entityRepository.FindByCustomWhereWithIncludes(predicate, includeProperties);

            // Assert
            using (Assert.EnterMultipleScope())
            {
                Assert.That(listResult, Is.Not.Null);
                Assert.That(listResult, Is.InstanceOf<List<Gender>>());
                Assert.That(listResult, Has.Count.EqualTo(1));

                Assert.That(listResult.First().Patients, Is.Not.Null);
                Assert.That(listResult.First().Patients.ToList(), Is.InstanceOf<List<Patient>>());
                Assert.That(listResult.First().Patients, Has.Count.EqualTo(1));

            }
        }

        // Cenário: contagem de gêneros que satisfazem um predicado.
        // Objetivo: garantir que GetCount retorne a quantidade esperada.
        [Test]
        public async Task GetCount_MatchingPredicate_ReturnsExpectedCount()
        {
            // Arrange
            var mockFull = GenderMockHelper.GetMock().AsQueryable();
            SetupContext(mockFull);

            Expression<Func<Gender, bool>> predicate = g => g.Id == 1;

            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new GenderRepository(_mockContext);

            // Act
            var result = await _entityRepository.GetCount(predicate);

            // Assert
            using (Assert.EnterMultipleScope())
            {
                Assert.That(result, Is.GreaterThanOrEqualTo(0));
                Assert.That(result, Is.EqualTo(1));
            }
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
