using System;

using Xunit;

namespace Acdcat.TestProject.UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void ShouldPass()
        {
            var x = 5 * 2;

            Assert.Equal(10, x);
        }

        [Fact]
        public void ShouldFail()
        {
            var y = 6 * 2;

            Assert.NotEqual(10, y);

        }
    }
}
