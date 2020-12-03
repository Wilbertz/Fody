using FodyCourse;
using Xunit;

namespace Fody.Test
{
    public class ToStringTests
    {
        [Fact]
        public void ToString_Should_Work()
        {
            // Arrange 
            var unitUnderTest = new ManualToString {Name = "Harald", HomeTown = "Berlin", Age = 59, Password = "SuperSecret"};

            // Act
            var result = unitUnderTest.ToString();

            // Assert

        }
    }
}
