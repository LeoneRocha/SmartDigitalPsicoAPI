
using SmartDigitalPsico.Domain.Helpers;

namespace SmartDigitalPsico.Tests
{
    [TestFixture] 
    public class ApplicationLanguageHelperTests
    {
        [Test]
        public void ReplaceTokensInMessage_ShouldReplaceTokensCorrectly()
        {
            // Arrange
            var message = "IntervalInMinutes_Validator_InclusiveBetween_Key|{0} must be between {1} and {2}.|Interval In Minutes|15|1440";
            var expected = "IntervalInMinutes_Validator_InclusiveBetween_Key|Interval In Minutes must be between 15 and 1440.";

            // Act
            var result = ApplicationLanguageHelper.ReplaceTokensInMessage(message);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result, Is.InstanceOf<string>());
                Assert.That(result, Is.EqualTo(expected));
            });
        }

        [Test]
        public void ReplaceTokensInMessage_ShouldReturnOriginalMessage_IfNoTokens()
        {
            // Arrange
            var message = "Simple_Message_Key|This is a simple message.";
            var expected = message;

            // Act
            var result = ApplicationLanguageHelper.ReplaceTokensInMessage(message);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result, Is.InstanceOf<string>());
                Assert.That(result, Is.EqualTo(expected));
            });
        }

        [Test]
        public void ReplaceTokens_ShouldReplaceAllTokens()
        {
            // Arrange
            var template = "{0} must be between {1} and {2}.";
            var values = new[] { "Field", "MinValue", "MaxValue" };
            var expected = "Field must be between MinValue and MaxValue.";

            // Act
            var result = ApplicationLanguageHelper.ReplaceTokens(template, values);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result, Is.InstanceOf<string>());
                Assert.That(result, Is.EqualTo(expected));
            });
        }

        [Test]
        public void ReplaceTokens_ShouldReturnTemplate_IfNoValues()
        {
            // Arrange
            var template = "This is a template.";
            var expected = template;

            // Act
            var result = ApplicationLanguageHelper.ReplaceTokens(template);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result, Is.InstanceOf<string>());
                Assert.That(result, Is.EqualTo(expected));
            });
        }
    }
} 