using CepApi.Services.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace CepApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CepController : ControllerBase
{
    private readonly ICepService _cepService;

    public CepController(ICepService cepService)
    {
        _cepService = cepService;
    }

    [HttpGet("{cep}")]
    public async Task<IActionResult> Get(string cep)
    {
        var result = await _cepService.GetAddressByCepAsync(cep);

        if (result == null)
            return NotFound("CEP não encontrado");

        return Ok(result);
    }
}
