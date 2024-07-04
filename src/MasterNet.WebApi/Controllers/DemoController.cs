using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;

namespace MasterNet.WebApi.Controllers;

[ApiController]
[Route("Demo")]
public class DemoController : ControllerBase {

    private readonly IConfiguration _configuration;

    private readonly IHostEnvironment _enviroment;

    public DemoController(IConfiguration configuration, IHostEnvironment enviroment)
    {
        _configuration = configuration;
        _enviroment = enviroment;
    }

    [HttpGet("getstring")]
        public string GetNombre() {
            return "Ruben";
        }

        [HttpGet("ambiente")]
        public IActionResult GetAmbiente() {
            var mensaje = _configuration.GetValue<string>("MiVariable");
            var ambiente = _enviroment.EnvironmentName;
            return Ok(new { Ambiente = ambiente, Mensaje = mensaje});
        }
        
}