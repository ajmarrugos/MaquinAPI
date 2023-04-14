using System.Net.Http;
using System.Text.Json;

namespace MaquinAPI.Services
{
    public class ExternalApiService
    {
        private readonly HttpClient _httpClient;

        public ExternalApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<User> GetUserAsync(int id)
        {
            var response = await _httpClient.GetAsync($"https://jsonplaceholder.typicode.com/{id}");
            response.EnsureSuccessStatusCode();
            var responseStream = await response.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<User>(responseStream);
        }
    }
}
