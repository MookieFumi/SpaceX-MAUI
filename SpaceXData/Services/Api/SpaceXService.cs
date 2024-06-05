using System.Text.Json;
using SpaceXData.Services.Dtos;

namespace SpaceXData.Services
{
    public class SpaceXService
    {
        private const string BaseUrl = "https://api.spacexdata.com/v3/";
        private const string LaunchesEndpoint = "launches";

        public async Task<List<GetLaunchesResponse>> GetLaunches()
        {
            var clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

            var client = new HttpClient(clientHandler) { BaseAddress = new Uri(BaseUrl) };
            var request = new HttpRequestMessage(HttpMethod.Get, LaunchesEndpoint);
            var response = await client.SendAsync(request);

            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();

            var launches = JsonSerializer.Deserialize<List<Launch>>(content);

            return launches
                .GroupBy(l => l.LaunchDateUtc.Year)
                .Select(p => new GetLaunchesResponse(p.Key, p.ToList()))
                .OrderByDescending(p => p.Year)
                .ToList();
        }
    }
}