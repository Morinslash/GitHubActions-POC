using System.Net.Http;
using System.Threading.Tasks;
using GitHubActions_POC;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace GitHubAction_POC.Integration.Test
{
    [Trait("Category","IntegrationTest")]
    public class HelloWorldTest :IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly HttpClient _httpClient;

        public HelloWorldTest(WebApplicationFactory<Startup> factory)
        {
            _httpClient = factory.CreateDefaultClient();
        }

        [Fact]
        public async Task HelloWorld_ReturnsOK()
        {
            var httpResponseMessage = await _httpClient.GetAsync("/");

            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
} 