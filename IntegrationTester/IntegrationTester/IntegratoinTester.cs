using System;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace IntegrationTester
{
    public class IntegratoinTester
    {
        [Fact]
        public async Task ApiIsOk()
        {
            using (var client = new HttpClient())
            {
               var result = await client.GetAsync("https://localhost:44395/CalculaJuros?valorinicial=100&meses=5");
                result.EnsureSuccessStatusCode();
                Assert.Equal(System.Net.HttpStatusCode.OK,result.StatusCode);
            }
        }
    }
}
