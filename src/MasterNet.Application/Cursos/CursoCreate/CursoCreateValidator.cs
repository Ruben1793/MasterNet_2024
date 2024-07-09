using FluentValidation;

namespace MasterNet.Application.Cursos.CursoCreate;

public class CursoCreateValidator : AbstractValidator<CursoCreateRequest>
{
    public CursoCreateValidator()
    {
        RuleFor(x => x.Titulo).NotEmpty().WithMessage("El titulo no debe ser vacio");
        RuleFor(x => x.Descripcion).NotEmpty().WithMessage("La descripcion no debe ser vacia");;
    }
}