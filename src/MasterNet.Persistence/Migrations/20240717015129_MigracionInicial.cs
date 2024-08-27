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
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    NombreCompleto = table.Column<string>(type: "TEXT", nullable: true),
                    Carerra = table.Column<string>(type: "TEXT", nullable: true),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "cursos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Titulo = table.Column<string>(type: "TEXT", nullable: true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true),
                    FechaPublicacion = table.Column<DateTime>(type: "TEXT", nullable: true)
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
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "calificaciones",
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
                    table.PrimaryKey("PK_calificaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_calificaciones_cursos_CursoId",
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
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "17413a6f-8689-4caf-bc9c-f6c0776ac1dd", null, "CLIENT", "CLIENT" },
                    { "1c95a471-4dfa-45b7-a73f-38e2fc0d87f0", null, "ADMIN", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "cursos",
                columns: new[] { "Id", "Descripcion", "FechaPublicacion", "Titulo" },
                values: new object[,]
                {
                    { new Guid("029df3e7-5c6b-4e20-a866-a3e37ff09a10"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new DateTime(2024, 7, 16, 19, 51, 28, 584, DateTimeKind.Local).AddTicks(7906), "Gorgeous Granite Bacon" },
                    { new Guid("0742ae48-f6a0-4692-8372-49ff0f174c43"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new DateTime(2024, 7, 16, 19, 51, 28, 584, DateTimeKind.Local).AddTicks(7847), "Fantastic Wooden Pizza" },
                    { new Guid("355717d2-5b8b-4dd1-a85d-7ce3bb9c4b30"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new DateTime(2024, 7, 16, 19, 51, 28, 584, DateTimeKind.Local).AddTicks(7929), "Sleek Plastic Pizza" },
                    { new Guid("55c3b082-9596-42ee-b8ab-e8db113dca21"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new DateTime(2024, 7, 16, 19, 51, 28, 584, DateTimeKind.Local).AddTicks(7971), "Small Steel Soap" },
                    { new Guid("6e3dfadc-4fd9-4d43-9364-6310a725d874"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new DateTime(2024, 7, 16, 19, 51, 28, 584, DateTimeKind.Local).AddTicks(8025), "Sleek Wooden Shirt" },
                    { new Guid("7712ec8f-b5b9-499f-b4d1-8b6baffebe39"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new DateTime(2024, 7, 16, 19, 51, 28, 584, DateTimeKind.Local).AddTicks(7884), "Handcrafted Rubber Pizza" },
                    { new Guid("85cf239b-a387-461b-853c-e3b83b6be424"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new DateTime(2024, 7, 16, 19, 51, 28, 584, DateTimeKind.Local).AddTicks(8099), "Handmade Fresh Shoes" },
                    { new Guid("9babdf79-213b-41a8-b1a1-7329077d45a6"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new DateTime(2024, 7, 16, 19, 51, 28, 584, DateTimeKind.Local).AddTicks(8007), "Refined Steel Fish" },
                    { new Guid("c2d5dff8-c4ba-49d8-88c5-f76b449909cb"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new DateTime(2024, 7, 16, 19, 51, 28, 584, DateTimeKind.Local).AddTicks(7949), "Refined Metal Car" }
                });

            migrationBuilder.InsertData(
                table: "instructores",
                columns: new[] { "Id", "Apellidos", "Grado", "Nombre" },
                values: new object[,]
                {
                    { new Guid("13af121d-1c54-4631-8ac6-a4ad12eb3f64"), "Kuhn", "Legacy Marketing Agent", "Laverne" },
                    { new Guid("187c9942-a05e-4b5e-906f-b16daee57c90"), "Jaskolski", "Chief Infrastructure Strategist", "Lysanne" },
                    { new Guid("5f281d67-b72d-4c2e-9407-4aada86e29be"), "Fisher", "District Solutions Architect", "Ramona" },
                    { new Guid("9240db9e-5891-4965-98a9-da6dbb64b654"), "Grady", "Legacy Tactics Developer", "Ellie" },
                    { new Guid("ad9007df-0ddf-492f-8707-a9157075af12"), "Schumm", "Direct Metrics Coordinator", "Bernadette" },
                    { new Guid("b3cc997d-02a0-4ef5-ad3a-12a841fc1076"), "Gleichner", "Senior Integration Executive", "Trinity" },
                    { new Guid("d001ad18-b855-43dd-ba15-ae10b2bb4ed9"), "Smitham", "Dynamic Configuration Technician", "Josefa" },
                    { new Guid("d0e3ef34-e4eb-48c9-846c-310416024c05"), "Kilback", "Forward Accountability Director", "Raleigh" },
                    { new Guid("dbbcdd9b-cba5-463b-9cbb-0587cabea11c"), "Friesen", "Dynamic Usability Liaison", "Jovan" },
                    { new Guid("dd874c1b-603b-4d36-8c17-0496fd85980d"), "Harber", "Chief Accountability Architect", "Vella" }
                });

            migrationBuilder.InsertData(
                table: "precios",
                columns: new[] { "Id", "Nombre", "PrecioActual", "PrecioPromocion" },
                values: new object[] { new Guid("59f3a9d8-50c6-4e65-bff9-b03d8d9d75ae"), "Precio Regular", 10.0m, 8.0m });

            migrationBuilder.InsertData(
                table: "AspNetRoleClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "RoleId" },
                values: new object[,]
                {
                    { 1, "POLICIES", "CURSO_READ", "1c95a471-4dfa-45b7-a73f-38e2fc0d87f0" },
                    { 2, "POLICIES", "CURSO_UPDATE", "1c95a471-4dfa-45b7-a73f-38e2fc0d87f0" },
                    { 3, "POLICIES", "CURSO_WRITE", "1c95a471-4dfa-45b7-a73f-38e2fc0d87f0" },
                    { 4, "POLICIES", "CURSO_DELETE", "1c95a471-4dfa-45b7-a73f-38e2fc0d87f0" },
                    { 5, "POLICIES", "INSTRUCTOR_CREATE", "1c95a471-4dfa-45b7-a73f-38e2fc0d87f0" },
                    { 6, "POLICIES", "INSTRUCTOR_READ", "1c95a471-4dfa-45b7-a73f-38e2fc0d87f0" },
                    { 7, "POLICIES", "INSTRUCTOR_UPDATE", "1c95a471-4dfa-45b7-a73f-38e2fc0d87f0" },
                    { 8, "POLICIES", "COMENTARIO_READ", "1c95a471-4dfa-45b7-a73f-38e2fc0d87f0" },
                    { 9, "POLICIES", "COMENTARIO_DELETE", "1c95a471-4dfa-45b7-a73f-38e2fc0d87f0" },
                    { 10, "POLICIES", "COMENTARIO_CREATE", "1c95a471-4dfa-45b7-a73f-38e2fc0d87f0" },
                    { 11, "POLICIES", "CURSO_READ", "17413a6f-8689-4caf-bc9c-f6c0776ac1dd" },
                    { 12, "POLICIES", "INSTRUCTOR_READ", "17413a6f-8689-4caf-bc9c-f6c0776ac1dd" },
                    { 13, "POLICIES", "COMENTARIO_READ", "17413a6f-8689-4caf-bc9c-f6c0776ac1dd" },
                    { 14, "POLICIES", "COMENTARIO_CREATE", "17413a6f-8689-4caf-bc9c-f6c0776ac1dd" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_calificaciones_CursoId",
                table: "calificaciones",
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
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "calificaciones");

            migrationBuilder.DropTable(
                name: "cursos_instructores");

            migrationBuilder.DropTable(
                name: "cursos_precios");

            migrationBuilder.DropTable(
                name: "imagenes");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "instructores");

            migrationBuilder.DropTable(
                name: "precios");

            migrationBuilder.DropTable(
                name: "cursos");
        }
    }
}
