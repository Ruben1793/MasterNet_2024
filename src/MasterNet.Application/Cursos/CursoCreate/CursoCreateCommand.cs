namespace MasterNet.Application.Cursos.CursoCreate;

using MasterNet.Domain;
using MasterNet.Persistence;
using MediatR;


public class CursoCreateCommand 
{
    public record CursoCreateCommandRequest(CursoCreateRequest cursoCreateRequest) : IRequest<Guid>;

    internal class CursoCreateCommandHandler : IRequestHandler<CursoCreateCommandRequest, Guid>
    {
        
        private readonly MasterNetDbContext _context;

        public CursoCreateCommandHandler(MasterNetDbContext context) {
            _context = context;
        }

        public async Task<Guid> Handle(CursoCreateCommandRequest request, CancellationToken cancellationToken) 
        {
           var curso = new Curso {
            Id = Guid.NewGuid(),
            Titulo = request.cursoCreateRequest.Titulo,
            Descripcion = request.cursoCreateRequest.Descripcion,
            FechaPulicacion = DateTime.Now
           };
            _context.Add(curso);
           await _context.SaveChangesAsync(cancellationToken);

           return curso.Id;
        } 
    }
}

