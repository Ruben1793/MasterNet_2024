namespace MasterNet.Application.Cursos.CursoCreate;

using MasterNet.Application.Core;
using MasterNet.Domain;
using MasterNet.Persistence;
using MediatR;


public class CursoCreateCommand 
{
    public record CursoCreateCommandRequest(CursoCreateRequest cursoCreateRequest) : IRequest<Result<Guid>>;

    internal class CursoCreateCommandHandler : IRequestHandler<CursoCreateCommandRequest, Result<Guid>>
    {
        private readonly MasterNetDbContext _context;

        public CursoCreateCommandHandler(MasterNetDbContext context) {
            _context = context;
        }

        public async Task<Result<Guid>> Handle(CursoCreateCommandRequest request, CancellationToken cancellationToken) 
        {
           var curso = new Curso {
            Id = Guid.NewGuid(),
            Titulo = request.cursoCreateRequest.Titulo,
            Descripcion = request.cursoCreateRequest.Descripcion,
            FechaPulicacion = DateTime.Now
           };
            _context.Add(curso);
            var resultado = await _context.SaveChangesAsync(cancellationToken) > 0;
            return resultado ? Result<Guid>.Success(curso.Id) : Result<Guid>.Failure("No se pudo crear el curso") ;
        } 
    }
}

