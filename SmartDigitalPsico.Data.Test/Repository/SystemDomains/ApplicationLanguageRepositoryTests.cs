using SmartDigitalPsico.Data.Context.Mock;
using SmartDigitalPsico.Data.Repository;
using SmartDigitalPsico.Data.Test.Configure;
using SmartDigitalPsico.Data.Tests.Context;

using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Data.Test.Repository.SystemDomains
{
    [TestFixture]
    public class ApplicationLanguageRepositoryTests : BaseTests
    {
        private ApplicationLanguageRepository? _entityRepository;

        [SetUp]
        public override void Setup()
        {
            var mockData = ApplicationLanguageMockData.GetMock().Take(38).AsQueryable();
            // Arrange 
            SetupContext(mockData);
        }
        private void SetupContext(IQueryable<ApplicationLanguage> mockData)
        {
            var mockDataList = mockData.ToList();
            // Arrange
            _mockContext = new SmartDigitalPsicoDataContextTest();

            _mockContext.ApplicationLanguages.AddRange(mockDataList);
            _mockContext.SaveChanges();
        }

        // Cenário: idiomas de aplicação persistidos no contexto de teste.
        // Objetivo: garantir que FindAll retorne todos os registros cadastrados.
        [Test]
        public async Task FindAll_ExistingLanguages_ReturnsAllRecords()
        {
            // Arrange
            var mockDataList = ApplicationLanguageMockData.GetMock().Take(38).AsQueryable();

            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new ApplicationLanguageRepository(_mockContext);

            // Act
            var listResult = await _entityRepository.FindAll();
            var listCount = listResult.Count;

            // Assert
            using (Assert.EnterMultipleScope())
            {
                Assert.That(listResult, Is.Not.Null);
                Assert.That(listResult, Is.InstanceOf<List<ApplicationLanguage>>());
                Assert.That(listResult, Has.Count.EqualTo(38));
                Assert.That(listCount, Is.EqualTo(38));
            }
        }

        // Cenário: busca por language, languageKey e resourceKey existentes.
        // Objetivo: garantir que Find retorne o registro correspondente.
        [Test]
        public async Task Find_ValidKeys_ReturnsLanguage()
        {
            // Arrange
            var mockData = ApplicationLanguageMockData.GetMock().Take(38).AsQueryable().First();
            // Arrange
            var language = mockData.Language;
            var languageKey = mockData.LanguageKey;
            var resourceKey = mockData.ResourceKey;

            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new ApplicationLanguageRepository(_mockContext);

            // Act
            var result = await _entityRepository.Find(language, languageKey, resourceKey);

            // Assert
            using (Assert.EnterMultipleScope())
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result, Is.InstanceOf<ApplicationLanguage>());
            }
        }
    }
}
