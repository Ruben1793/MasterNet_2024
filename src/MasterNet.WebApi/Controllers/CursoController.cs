using MasterNet.Application.Cursos.CursoCreate;
using MasterNet.Application.Cursos.CursoReporteExcel;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using static MasterNet.Application.Cursos.CursoCreate.CursoCreateCommand;
using static MasterNet.Application.Cursos.CursoReporteExcel.CursoReporteExcel;

namespace MasterNet.WebApi.Controllers;

[ApiController]
[Route("api/cursos")]
public class CursoController : ControllerBase {
    private readonly ISender _sender;

    public CursoController(ISender sender) {
        _sender = sender;
    }

    [HttpPost("create")]
    public async Task<ActionResult<Guid>> CursoCreate([FromForm] CursoCreateRequest request, CancellationToken cancellationToken) {
        var command = new CursoCreateCommandRequest(request);
        var resultado = await _sender.Send(command);
        return Ok(resultado);
    }

    [HttpGet("report")]
    public async Task<IActionResult> ReporteCSV(CancellationToken cancellationToken)
    {
        var query = new CursoReporteExcelQueryRequest();
        var resultado = await _sender.Send(query, cancellationToken);
        byte[] excelBytes = resultado.ToArray();
        return File(excelBytes, "text/csv", "cursos.csv");
    }
}