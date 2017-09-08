using Nancy;
using Nancy.Testing;
using webapi;
using Xunit;
using Xunit.Abstractions;

namespace webapitests
{
    public class HomeModuleTests
    {
        private readonly ITestOutputHelper output;

        public HomeModuleTests(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void Should_return_status_ok_when_route_exists()
        {
            // Given
            var browser = new Browser(with => with.Module(new HomeModule()));
            // When
            var response = browser.Get("/", with =>
            {
                with.HttpRequest();
            });
            
            Assert.Equal(HttpStatusCode.OK, response.Result.StatusCode);
        }
    }
}