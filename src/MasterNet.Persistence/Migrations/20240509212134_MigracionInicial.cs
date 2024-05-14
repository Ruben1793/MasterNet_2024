using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MasterNet.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class MigracionInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cursos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Titulo = table.Column<string>(type: "TEXT", nullable: true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true),
                    FechaPulicacion = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cursos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "instructores",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true),
                    Apellidos = table.Column<string>(type: "TEXT", nullable: true),
                    Grado = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_instructores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "precios",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Nombre = table.Column<string>(type: "VARCHAR", maxLength: 250, nullable: true),
                    PrecioActual = table.Column<decimal>(type: "TEXT", precision: 10, scale: 2, nullable: true),
                    PrecioPromocion = table.Column<decimal>(type: "TEXT", precision: 10, scale: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_precios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "calificacion",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Alumno = table.Column<string>(type: "TEXT", nullable: true),
                    Puntaje = table.Column<int>(type: "INTEGER", nullable: false),
                    Comentario = table.Column<string>(type: "TEXT", nullable: true),
                    CursoId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_calificacion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_calificacion_cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "imagenes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: true),
                    CursoId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_imagenes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_imagenes_cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cursos_instructores",
                columns: table => new
                {
                    CursoId = table.Column<Guid>(type: "TEXT", nullable: false),
                    InstructorId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cursos_instructores", x => new { x.InstructorId, x.CursoId });
                    table.ForeignKey(
                        name: "FK_cursos_instructores_cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cursos_instructores_instructores_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "instructores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cursos_precios",
                columns: table => new
                {
                    CursoId = table.Column<Guid>(type: "TEXT", nullable: false),
                    PrecioId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cursos_precios", x => new { x.PrecioId, x.CursoId });
                    table.ForeignKey(
                        name: "FK_cursos_precios_cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cursos_precios_precios_PrecioId",
                        column: x => x.PrecioId,
                        principalTable: "precios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "cursos",
                columns: new[] { "Id", "Descripcion", "FechaPulicacion", "Titulo" },
                values: new object[,]
                {
                    { new Guid("0cbce446-414a-4fec-91e2-4dcd6665d176"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new DateTime(2024, 5, 9, 15, 21, 34, 359, DateTimeKind.Local).AddTicks(6800), "Tasty Granite Computer" },
                    { new Guid("2323ced8-6d79-4aa0-a2d6-7b86b47a0195"), "The Football Is Good For Training And Recreational Purposes", new DateTime(2024, 5, 9, 15, 21, 34, 359, DateTimeKind.Local).AddTicks(6885), "Awesome Fresh Chips" },
                    { new Guid("34858352-ac85-4971-92a4-4e88d42561b9"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new DateTime(2024, 5, 9, 15, 21, 34, 359, DateTimeKind.Local).AddTicks(6782), "Intelligent Metal Car" },
                    { new Guid("6f2faf78-dc69-4206-a73f-f8d31d407b88"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new DateTime(2024, 5, 9, 15, 21, 34, 359, DateTimeKind.Local).AddTicks(6909), "Rustic Metal Sausages" },
                    { new Guid("76390a1a-c075-43f6-b4c3-23400b2cf77f"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new DateTime(2024, 5, 9, 15, 21, 34, 359, DateTimeKind.Local).AddTicks(6925), "Gorgeous Plastic Mouse" },
                    { new Guid("7e4e0d83-3f62-4dd9-9eba-5ba9fb6ee8d3"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new DateTime(2024, 5, 9, 15, 21, 34, 359, DateTimeKind.Local).AddTicks(6851), "Licensed Metal Bacon" },
                    { new Guid("ab978782-7a60-4d2e-9d5e-10b5112b77e1"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new DateTime(2024, 5, 9, 15, 21, 34, 359, DateTimeKind.Local).AddTicks(6868), "Licensed Frozen Shoes" },
                    { new Guid("da315308-c277-4ea4-814b-ef5ef0231201"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new DateTime(2024, 5, 9, 15, 21, 34, 359, DateTimeKind.Local).AddTicks(6724), "Practical Cotton Mouse" },
                    { new Guid("f8dfd787-f9c1-4b5c-8f1a-59d535217f17"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new DateTime(2024, 5, 9, 15, 21, 34, 359, DateTimeKind.Local).AddTicks(6817), "Unbranded Steel Shirt" }
                });

            migrationBuilder.InsertData(
                table: "instructores",
                columns: new[] { "Id", "Apellidos", "Grado", "Nombre" },
                values: new object[,]
                {
                    { new Guid("09285e18-d0c2-4543-bc07-1a2c063a5e9d"), "Klein", "Regional Tactics Strategist", "Ewald" },
                    { new Guid("168a059c-591a-4b17-ba07-add6c60f147a"), "Grady", "Regional Paradigm Technician", "Cameron" },
                    { new Guid("47542d32-08f7-4805-9c1c-5528b3c633a0"), "O'Reilly", "Internal Solutions Liaison", "Art" },
                    { new Guid("919b0584-4891-4fe3-a199-f5723b0d12dd"), "Homenick", "Corporate Paradigm Producer", "Terrance" },
                    { new Guid("9517ece1-2922-4af2-817a-29cd2f5a31b3"), "Sawayn", "Internal Intranet Executive", "Curtis" },
                    { new Guid("974be9c1-0887-4372-b712-804b58e209c5"), "Heathcote", "Direct Mobility Assistant", "Zachery" },
                    { new Guid("c497f33e-07a8-4e0a-8359-71a4092efbf6"), "Ritchie", "Direct Applications Executive", "Caterina" },
                    { new Guid("cad838b8-7265-4e03-bddd-40be360587f2"), "Howe", "National Configuration Analyst", "Evalyn" },
                    { new Guid("da0bdc2c-44ac-4357-a4ea-36279efa2cdb"), "Dickens", "Product Accountability Supervisor", "Lily" },
                    { new Guid("e49859c1-123d-4c8a-97c7-f9505bfb3d67"), "Lubowitz", "Product Creative Planner", "Estelle" }
                });

            migrationBuilder.InsertData(
                table: "precios",
                columns: new[] { "Id", "Nombre", "PrecioActual", "PrecioPromocion" },
                values: new object[] { new Guid("efd92fc1-1991-4137-b945-dc49c86fdba2"), "Precio Regular", 10.0m, 8.0m });

            migrationBuilder.CreateIndex(
                name: "IX_calificacion_CursoId",
                table: "calificacion",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_cursos_instructores_CursoId",
                table: "cursos_instructores",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_cursos_precios_CursoId",
                table: "cursos_precios",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_imagenes_CursoId",
                table: "imagenes",
                column: "CursoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "calificacion");

            migrationBuilder.DropTable(
                name: "cursos_instructores");

            migrationBuilder.DropTable(
                name: "cursos_precios");

            migrationBuilder.DropTable(
                name: "imagenes");

            migrationBuilder.DropTable(
                name: "instructores");

            migrationBuilder.DropTable(
                name: "precios");

            migrationBuilder.DropTable(
                name: "cursos");
        }
    }
}
