using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Run();
        }
        private IConfigurationRoot _configuration { get; set; }
        private HttpClient _client { get; set; }
        public void Run()
        {
            Init();
            GetHelloFromApi().Wait();
        }
        private void Init()
        {
            BuildConfiguration();
            BuildClient();
        }
        private void BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            _configuration = builder.Build();
        }
        private void BuildClient()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(_configuration["ApiUrl"]);
            _client.DefaultRequestHeaders.Accept.Clear();
        }
        private async Task GetHelloFromApi()
        {
            var response = await _client.GetStringAsync("/api/HelloWorld");
            Console.WriteLine(response);
        }
    }
}
