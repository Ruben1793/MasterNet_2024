namespace MasterNet.Persistence;

using Bogus;
using MasterNet.Domain;
using Microsoft.EntityFrameworkCore;

public class MasterNetDbContext : DbContext {

    public DbSet<Curso>? Cursos{ get; set; }
    public DbSet<Instructor>? Instructores {get; set; }
    public DbSet<Precio>? PrecioS { get; set; }
    public DbSet<Calificacion>? CalificacioneS { get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
       optionsBuilder.UseSqlite("Data Source=LocalDatabase.db")
       .LogTo(Console.WriteLine, new[] {DbLoggerCategory.Database.Command.Name}, Microsoft.Extensions.Logging.LogLevel.Information)
       .EnableSensitiveDataLogging();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        //Table names
        modelBuilder.Entity<Curso>().ToTable("cursos");
        modelBuilder.Entity<Instructor>().ToTable("instructores");
        modelBuilder.Entity<CursoInstructor>().ToTable("cursos_instructores");
        modelBuilder.Entity<Precio>().ToTable("precios");
        modelBuilder.Entity<CursoPrecio>().ToTable("cursos_precios");
        modelBuilder.Entity<Calificacion>().ToTable("calificacion");
        modelBuilder.Entity<Photo>().ToTable("imagenes");

        //Column properties
        modelBuilder.Entity<Precio>().Property(b => b.PrecioActual).HasPrecision(10,2);
        modelBuilder.Entity<Precio>().Property(b => b.PrecioPromocion).HasPrecision(10,2);
        modelBuilder.Entity<Precio>().Property(b => b.Nombre).HasColumnType("VARCHAR").HasMaxLength(250);

        //One to Many relationships 
        modelBuilder.Entity<Curso>().HasMany(m => m.Photos).WithOne(m => m.Curso).HasForeignKey(m => m.CursoId).IsRequired().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<Curso>().HasMany(m => m.Calificaciones).WithOne(m => m.Curso).HasForeignKey(M => M.CursoId).OnDelete(DeleteBehavior.Restrict);

        //Many to Many relationships
        modelBuilder.Entity<Curso>().HasMany(m => m.Precios).WithMany(m => m.Cursos)
                                                                    .UsingEntity<CursoPrecio>(
                                                                        j => j.HasOne(p => p.Precio).WithMany(p => p.CursosPrecios).HasForeignKey(p => p.PrecioId), 
                                                                        j => j.HasOne(p => p.Curso) .WithMany(p => p.CursoPrecios).HasForeignKey(p => p.CursoId), 
                                                                         j => { 
                                                                                j.HasKey( t => new { t.PrecioId, t.CursoId}); 
                                                                            } 
                                                                    ); 
        modelBuilder.Entity<Curso>().HasMany(m => m.Instructores).WithMany(m => m.Cursos)
                                                                    .UsingEntity<CursoInstructor>(
                                                                        j => j.HasOne(p => p.Instructor).WithMany(m => m.CursosInstructores).HasForeignKey(p => p.InstructorId),
                                                                        j => j.HasOne(p => p.Curso).WithMany(m => m.CursoInstructores).HasForeignKey(p => p.CursoId),
                                                                        j => {
                                                                            j.HasKey(t => new {t.InstructorId, t.CursoId});
                                                                        }
                                                                    );
        
        modelBuilder.Entity<Curso>().HasData(DataMaster().Item1);
        modelBuilder.Entity<Precio>().HasData(DataMaster().Item2);
        modelBuilder.Entity<Instructor>().HasData(DataMaster().Item3);   

    }

    public Tuple<Curso[], Precio[], Instructor[]> DataMaster() 
    {
        var cursos = new List<Curso>();
        var faker = new Faker();
        for (int i = 1; i<10; i++){
            var cursoId = Guid.NewGuid();
            cursos.Add(new Curso{
                Id = cursoId,
                Descripcion = faker.Commerce.ProductDescription(),
                Titulo = faker.Commerce.ProductName(),
                FechaPulicacion = DateTime.Now,
            });
        }
        var precioId = Guid.NewGuid();
        var precio = new Precio{
            Id = precioId,
            PrecioActual = 10.0m,
            PrecioPromocion = 8.0m,
            Nombre = "Precio Regular"
        };
        var precios = new List<Precio>{
            precio
        };
        var fakerInstructor = new Faker<Instructor>()
                                .RuleFor(t => t.Id, _ => Guid.NewGuid())
                                .RuleFor(t => t.Nombre, f=> f.Name.FirstName())
                                .RuleFor(t => t.Apellidos, f=> f.Name.LastName())
                                .RuleFor(t => t.Grado, f=> f.Name.JobTitle());
        var instructores = fakerInstructor.Generate(10);
        return Tuple.Create(cursos.ToArray(), precios.ToArray(), instructores.ToArray());
    }
}