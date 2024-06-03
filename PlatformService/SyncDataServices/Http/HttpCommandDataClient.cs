using System.Text;
using System.Text.Json;
using PlatformService.Dtos;

namespace PlatformService.SyncDataServices.Http
{
    public class HttpCommandDataClient(HttpClient httpClient, IConfiguration config) : ICommandDataClient
    {
        private readonly HttpClient _httpClient = httpClient;

        private readonly IConfiguration _config = config;

        public async Task SendPlatformCommand(PlatformReadDto readDto)
        {
            var httpContent = new StringContent(
                JsonSerializer.Serialize(readDto),
                Encoding.UTF8,
                "application/json");

            var response = await _httpClient.PostAsync($"{_config["CommandService"]}", httpContent);

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("--> Sync POST to CommandService was OK!");
            } else {
                Console.WriteLine("--> Sync POST to CommandService was not OK!");
            }
        }
    }
}