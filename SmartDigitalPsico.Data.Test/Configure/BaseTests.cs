using SmartDigitalPsico.Data.Tests.Context;

namespace SmartDigitalPsico.Data.Test.Configure
{ 
    public class BaseTests
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
                _mockContext.Dispose();
            }
        } 
    }
}
