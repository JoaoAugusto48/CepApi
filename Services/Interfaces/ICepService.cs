using CepApi.Data;

namespace CepApi.Services.Interfaces;

public interface ICepService
{
    Task<ViaCepResponse?> GetAddressByCepAsync(string cep);
}
