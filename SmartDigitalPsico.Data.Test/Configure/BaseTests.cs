using SmartDigitalPsico.Data.Tests.Context;

using SmartDigitalPsico.Data.Repository;
using SmartDigitalPsico.Data.Context.Configure;
namespace SmartDigitalPsico.Data.Test.Configure
{
    public abstract class BaseTests
    {
        protected SmartDigitalPsicoDataContextTest? _mockContext;

        [SetUp]
        public virtual void Setup()
        {
            // Arrange
            _mockContext = new SmartDigitalPsicoDataContextTest();
        }

        [TearDown]
        public void TearDown()
        {
            if (_mockContext != null)
            {
                _mockContext.Database.EnsureDeleted();
                _mockContext.Dispose();
            }
        }
    }
}
