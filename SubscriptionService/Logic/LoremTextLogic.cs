using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SubscriptionService.Logic
{
    public static class LoremTextLogic
    {
        private static readonly HttpClient Client = new HttpClient();

        public static async Task<string> GetWord()
        {
            var body = await GetBody("word");
            if (body == "word")
            {
                return "Subscription";
            }
            return body;
        }

        private static async Task<string> GetBody(string type)
        {
            string uri = "https://reviews-of-company.azurewebsites.net/api/HttpTrigger-GetLoremAPIBody?code=6naM1qKKh9DgSK6ntkdYaKanZoYAJLagr7ynT4uFVu2XzivEF3/KRQ==";
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(uri),
                Content = new StringContent($"{{\"type\":\"{type}\"}}", Encoding.UTF8, "application/json")
            };
            using var response = await Client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}
