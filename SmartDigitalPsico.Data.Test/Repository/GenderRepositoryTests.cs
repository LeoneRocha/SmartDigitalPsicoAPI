using Bogus;
using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Data.Repository.SystemDomains;
using SmartDigitalPsico.Data.Test.Configure;
using SmartDigitalPsico.Data.Test.DataMock;
using SmartDigitalPsico.Data.Tests.Context;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Tests.Repository
{
    [TestFixture]
    public class GenderRepositoryTests : BaseTests
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
            var data = createEntity(mockData);
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();

            // Inicialize  Repository
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
        public async Task Create_Success_With_Bogus()
        {
            // Arrange
            var faker = new Faker<Gender>("pt_BR")  
                .RuleFor(g => g.Description, f => string.Join(" ", f.Lorem.Words(3))) // Gera uma frase com 7 palavras
                .RuleFor(g => g.Language, f => f.Random.String2(10)); // Respeita o limite de 10 caracteres

            var data = faker.Generate();

            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();

            // Inicialize  Repository
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


        private Gender createEntity(Gender mockData)
        {
            return new Gender()
            {
                Id = (long)int.MaxValue,
                ModifyDate = mockData.ModifyDate,
                CreatedDate = mockData.CreatedDate,
                Description = mockData.Description,
                Enable = mockData.Enable,
                Language = mockData.Language,
                LastAccessDate = mockData.LastAccessDate
            };
        }

    }
}
