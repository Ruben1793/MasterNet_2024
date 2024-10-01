using System.Linq.Expressions;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MasterNet.Application.Core;
using MasterNet.Domain;
using MasterNet.Persistence;
using MediatR;

namespace MasterNet.Application.Instructores.GetInstructores;

public class GetInstructoresQuery
{
    public record GetInstructoresQueryRequest : IRequest<Result<PagedList<InstructorResponse>>>
    {
        public GetInstructoresRequest? InstructoresRequest {get; set;}
    }

    internal class GetInstructoresQueryHandler : IRequestHandler<GetInstructoresQueryRequest, Result<PagedList<InstructorResponse>>>
    {
         private readonly MasterNetDbContext _context;
        private readonly IMapper _mapper;

        public GetInstructoresQueryHandler(MasterNetDbContext context, IMapper mapper)
        {
             _context = context;
            _mapper = mapper;
        }

        public async Task<Result<PagedList<InstructorResponse>>> Handle(GetInstructoresQueryRequest request, CancellationToken cancellationToken)
        {
            IQueryable<Instructor> queryable = _context.Instructores!;
            var predicate = ExpressionBuilder.New<Instructor>();
            if (!string.IsNullOrEmpty(request.InstructoresRequest!.Nombre)){
                predicate =  predicate.And(y => y.Nombre!.Contains(request.InstructoresRequest!.Nombre));
            }
            if (!string.IsNullOrEmpty(request.InstructoresRequest!.Apellido)){
                predicate =  predicate.And(y => y.Apellidos!.Contains(request.InstructoresRequest!.Apellido));
            }
            if (!string.IsNullOrEmpty(request.InstructoresRequest.OrderBy)) {
                Expression<Func<Instructor, object>> orderBySelector = request.InstructoresRequest!.OrderBy!.ToLower() switch
                {
                    "nombre" => instructor => instructor.Nombre!,
                    "apellido" => instructor => instructor.Apellidos!,
                    _ => instructor => instructor.Nombre!,
                };

                bool orderBy = request.InstructoresRequest.OrderAsc.HasValue ? request.InstructoresRequest.OrderAsc.Value : true;
                queryable = orderBy ? queryable.OrderBy(orderBySelector) : queryable.OrderByDescending(orderBySelector);
            }
            queryable.Where(predicate);
            var instructoresQuery = queryable.ProjectTo<InstructorResponse>(_mapper.ConfigurationProvider).AsQueryable();
            var pagination = await PagedList<InstructorResponse>.CreateAsync(instructoresQuery, request.InstructoresRequest.PageNumber, request.InstructoresRequest.PageSize);
            return Result<PagedList<InstructorResponse>>.Success(pagination);
        }
    }
}

public record InstructorResponse(Guid? Id, string? Nombre, string? Apellido, string? Grado)
{
    public InstructorResponse(): this(null, null, null, null) { }
}