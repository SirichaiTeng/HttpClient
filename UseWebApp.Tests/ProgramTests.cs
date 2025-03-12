using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseWebApp.Tests
{
    public class ProgramTests
    {
        [Fact]
        public async Task MaunTestAsync()
        {
            // Arrange
            var args = new[] { "test" };

            // Act
            await Program.Main(args);

            // Assert
            Assert.Equal(0,Environment.ExitCode);
        }
    }
}
