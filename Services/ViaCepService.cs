using CepApi.Models;
using CepApi.Services.Interfaces;
using System.Text.Json;

namespace CepApi.Services;

public class ViaCepService : ICepService
{
    private readonly HttpClient _httpClient;

    public ViaCepService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<ViaCepResponse?> GetAddressByCepAsync(string cep)
    {
        var response = await _httpClient.GetAsync($"{cep}/json/");

        if (!response.IsSuccessStatusCode)
        {
            return null;
        }

        var json = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<ViaCepResponse>(json, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        });
    }
}
