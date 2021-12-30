using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RandomNumbers.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NumbersController : ControllerBase
    {
        private readonly HttpClient httpClient;

        public NumbersController(IHttpClientFactory httpClientFactory)
        {
            httpClient = httpClientFactory.CreateClient();
        }

        [HttpGet("random")]
        public List<int> GetRandom(int count = 10)
        {
            var numbers = new List<int>();
            var random = new Random();

            for (int i = 0; i < count; i++)
            {
                numbers.Add(random.Next(0, 100));
            }

            return numbers;
        }

        [HttpGet("lucky/{name}")]
        public async Task<int> GetLuckyAsync(string name)
        {
            var authAddress = Environment.GetEnvironmentVariable("AUTH_ADDRESS");
            if(string.IsNullOrEmpty(authAddress))
            {
                throw new Exception("I don't know the authorization address :-(");
            }

            var address = $"{authAddress}/authorization/check/{name}";
            var response = await httpClient.GetAsync(address);
            var content = await response.Content.ReadAsStreamAsync();
            var canAccess = await JsonSerializer.DeserializeAsync<bool>(content);

            if (canAccess)
            {
                var random = new Random();
                return random.Next(0, 100);
            }
            else
            {
                throw new UnauthorizedAccessException($"{name} can't get lucky number.");
            }
        }
    }
}
