using Alba;
using Alba.Required.Models;

namespace Alba.Required.Tests
{
    public class UnitTest1
    {
        [Fact]
        public async Task Test1()
        {
            // Alba will automatically manage the lifetime of the underlying host
            await using var host = await AlbaHost.For<global::Program>();

            // Arrange
            // Act
            var response = await host.Scenario(_ =>
            {
                _.Get.Url($"/WeatherForecast");
                _.StatusCodeShouldBeOk();
            });

            // Assert
            var result = await response.ReadAsJsonAsync<RequiredModel>();
        }
    }
}