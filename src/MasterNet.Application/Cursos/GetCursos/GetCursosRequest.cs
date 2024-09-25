namespace MasterNet.Application.Core;

public class GetCursosRequest : PagingParams
{
    public string? Titulo {get; set;}
    public string? Descripcion {get;}
}