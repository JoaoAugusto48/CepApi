using CepApi.Models;

namespace CepApi.Services.Interfaces;

public interface ICepService
{
    Task<ViaCepResponse?> GetAddressByCepAsync(string cep);
}
