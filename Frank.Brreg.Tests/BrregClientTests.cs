using Newtonsoft.Json;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Frank.Brreg.Tests
{
    public class BrregClientTests
    {
        private readonly ITestOutputHelper _outputHelper;

        public BrregClientTests(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }

        [Fact]
        public async Task GetOrganizationTypesAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var brregClient = new BrregClient();

            // Act
            var result = await brregClient.GetOrganizationTypesAsync();

            // Assert
            _outputHelper.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
        }
    }
}
