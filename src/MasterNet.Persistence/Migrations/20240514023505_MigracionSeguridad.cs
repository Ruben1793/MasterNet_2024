using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MasterNet.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class MigracionSeguridad : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("0cbce446-414a-4fec-91e2-4dcd6665d176"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("2323ced8-6d79-4aa0-a2d6-7b86b47a0195"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("34858352-ac85-4971-92a4-4e88d42561b9"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("6f2faf78-dc69-4206-a73f-f8d31d407b88"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("76390a1a-c075-43f6-b4c3-23400b2cf77f"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("7e4e0d83-3f62-4dd9-9eba-5ba9fb6ee8d3"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("ab978782-7a60-4d2e-9d5e-10b5112b77e1"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("da315308-c277-4ea4-814b-ef5ef0231201"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("f8dfd787-f9c1-4b5c-8f1a-59d535217f17"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("09285e18-d0c2-4543-bc07-1a2c063a5e9d"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("168a059c-591a-4b17-ba07-add6c60f147a"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("47542d32-08f7-4805-9c1c-5528b3c633a0"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("919b0584-4891-4fe3-a199-f5723b0d12dd"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("9517ece1-2922-4af2-817a-29cd2f5a31b3"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("974be9c1-0887-4372-b712-804b58e209c5"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("c497f33e-07a8-4e0a-8359-71a4092efbf6"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("cad838b8-7265-4e03-bddd-40be360587f2"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("da0bdc2c-44ac-4357-a4ea-36279efa2cdb"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("e49859c1-123d-4c8a-97c7-f9505bfb3d67"));

            migrationBuilder.DeleteData(
                table: "precios",
                keyColumn: "Id",
                keyValue: new Guid("efd92fc1-1991-4137-b945-dc49c86fdba2"));

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2fc1bb30-1904-472a-a7bb-a9bb5211e1a1", null, "ADMIN", "ADMIN" },
                    { "a7bc9c69-b639-4384-8144-fb5552a94f4b", null, "CLIENT", "CLIENT" }
                });

            migrationBuilder.InsertData(
                table: "cursos",
                columns: new[] { "Id", "Descripcion", "FechaPulicacion", "Titulo" },
                values: new object[,]
                {
                    { new Guid("33ca89f3-718a-413f-94bb-685981f9a65c"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new DateTime(2024, 5, 13, 20, 35, 4, 811, DateTimeKind.Local).AddTicks(3748), "Rustic Plastic Car" },
                    { new Guid("39c101d6-8eb8-41c5-b134-16f8835b427d"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new DateTime(2024, 5, 13, 20, 35, 4, 811, DateTimeKind.Local).AddTicks(3513), "Sleek Concrete Chair" },
                    { new Guid("5495a02e-0c37-4a5f-8160-b2a72a8de52c"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new DateTime(2024, 5, 13, 20, 35, 4, 811, DateTimeKind.Local).AddTicks(3765), "Tasty Concrete Chicken" },
                    { new Guid("5b37b2e8-fcac-4bf8-8174-97999e6d2c88"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new DateTime(2024, 5, 13, 20, 35, 4, 811, DateTimeKind.Local).AddTicks(3700), "Refined Granite Soap" },
                    { new Guid("76787692-b469-492d-b605-ed977f48edfd"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new DateTime(2024, 5, 13, 20, 35, 4, 811, DateTimeKind.Local).AddTicks(3733), "Unbranded Plastic Chips" },
                    { new Guid("8e80c873-cb17-436b-b53e-cec206e3ee31"), "The Football Is Good For Training And Recreational Purposes", new DateTime(2024, 5, 13, 20, 35, 4, 811, DateTimeKind.Local).AddTicks(3605), "Refined Cotton Sausages" },
                    { new Guid("9128175c-6cd2-44b3-ba14-7155dc785f96"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new DateTime(2024, 5, 13, 20, 35, 4, 811, DateTimeKind.Local).AddTicks(3684), "Generic Rubber Mouse" },
                    { new Guid("b120d574-47dd-45df-9602-1e457699a26f"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new DateTime(2024, 5, 13, 20, 35, 4, 811, DateTimeKind.Local).AddTicks(3717), "Gorgeous Fresh Pizza" },
                    { new Guid("d7941117-dfdc-4909-8446-a63ce8cfeac3"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new DateTime(2024, 5, 13, 20, 35, 4, 811, DateTimeKind.Local).AddTicks(3665), "Small Cotton Towels" }
                });

            migrationBuilder.InsertData(
                table: "instructores",
                columns: new[] { "Id", "Apellidos", "Grado", "Nombre" },
                values: new object[,]
                {
                    { new Guid("0a056047-aee5-427e-bb0e-c99d50c679e8"), "Heller", "Regional Paradigm Coordinator", "Abbey" },
                    { new Guid("21292226-befb-44ea-93a0-a66187a3d89b"), "Boehm", "Chief Accounts Manager", "Duane" },
                    { new Guid("3ae89695-b965-4fe4-84d1-d04bd759a493"), "Medhurst", "Future Research Strategist", "Harold" },
                    { new Guid("3b955d2b-4cd3-49e1-967e-b112592dbf3a"), "Kuhic", "District Factors Technician", "Carlos" },
                    { new Guid("464570d3-e331-47e6-93d5-815be65ee64c"), "Swaniawski", "Direct Solutions Orchestrator", "Gene" },
                    { new Guid("607de5d5-a1c4-46d3-9557-4cfd62492983"), "Koelpin", "Lead Interactions Facilitator", "Devin" },
                    { new Guid("7bfcaa67-b4be-4b30-932a-816df4ce535b"), "Rodriguez", "Dynamic Directives Developer", "Kelsi" },
                    { new Guid("85a8b3c0-2603-4b3e-9f7d-e8e9b44a632c"), "Wyman", "Future Brand Liaison", "Louvenia" },
                    { new Guid("8e70370c-5331-4fc1-857e-724c65a932c5"), "Conn", "National Configuration Agent", "Gladyce" },
                    { new Guid("cede83f3-7aee-41a7-80b1-01e923f39a3e"), "Koch", "Principal Markets Architect", "Reid" }
                });

            migrationBuilder.InsertData(
                table: "precios",
                columns: new[] { "Id", "Nombre", "PrecioActual", "PrecioPromocion" },
                values: new object[] { new Guid("6f3b0099-7b2c-49b5-87ec-b51059ef319e"), "Precio Regular", 10.0m, 8.0m });

            migrationBuilder.InsertData(
                table: "AspNetRoleClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "RoleId" },
                values: new object[,]
                {
                    { 1, "POLICIES", "CURSO_READ", "2fc1bb30-1904-472a-a7bb-a9bb5211e1a1" },
                    { 2, "POLICIES", "CURSO_UPDATE", "2fc1bb30-1904-472a-a7bb-a9bb5211e1a1" },
                    { 3, "POLICIES", "CURSO_WRITE", "2fc1bb30-1904-472a-a7bb-a9bb5211e1a1" },
                    { 4, "POLICIES", "CURSO_DELETE", "2fc1bb30-1904-472a-a7bb-a9bb5211e1a1" },
                    { 5, "POLICIES", "INSTRUCTOR_CREATE", "2fc1bb30-1904-472a-a7bb-a9bb5211e1a1" },
                    { 6, "POLICIES", "INSTRUCTOR_READ", "2fc1bb30-1904-472a-a7bb-a9bb5211e1a1" },
                    { 7, "POLICIES", "INSTRUCTOR_UPDATE", "2fc1bb30-1904-472a-a7bb-a9bb5211e1a1" },
                    { 8, "POLICIES", "COMENTARIO_READ", "2fc1bb30-1904-472a-a7bb-a9bb5211e1a1" },
                    { 9, "POLICIES", "COMENTARIO_DELETE", "2fc1bb30-1904-472a-a7bb-a9bb5211e1a1" },
                    { 10, "POLICIES", "COMENTARIO_CREATE", "2fc1bb30-1904-472a-a7bb-a9bb5211e1a1" },
                    { 11, "POLICIES", "CURSO_READ", "a7bc9c69-b639-4384-8144-fb5552a94f4b" },
                    { 12, "POLICIES", "INSTRUCTOR_READ", "a7bc9c69-b639-4384-8144-fb5552a94f4b" },
                    { 13, "POLICIES", "COMENTARIO_READ", "a7bc9c69-b639-4384-8144-fb5552a94f4b" },
                    { 14, "POLICIES", "COMENTARIO_CREATE", "a7bc9c69-b639-4384-8144-fb5552a94f4b" }
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
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("33ca89f3-718a-413f-94bb-685981f9a65c"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("39c101d6-8eb8-41c5-b134-16f8835b427d"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("5495a02e-0c37-4a5f-8160-b2a72a8de52c"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("5b37b2e8-fcac-4bf8-8174-97999e6d2c88"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("76787692-b469-492d-b605-ed977f48edfd"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("8e80c873-cb17-436b-b53e-cec206e3ee31"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("9128175c-6cd2-44b3-ba14-7155dc785f96"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("b120d574-47dd-45df-9602-1e457699a26f"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("d7941117-dfdc-4909-8446-a63ce8cfeac3"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("0a056047-aee5-427e-bb0e-c99d50c679e8"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("21292226-befb-44ea-93a0-a66187a3d89b"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("3ae89695-b965-4fe4-84d1-d04bd759a493"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("3b955d2b-4cd3-49e1-967e-b112592dbf3a"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("464570d3-e331-47e6-93d5-815be65ee64c"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("607de5d5-a1c4-46d3-9557-4cfd62492983"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("7bfcaa67-b4be-4b30-932a-816df4ce535b"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("85a8b3c0-2603-4b3e-9f7d-e8e9b44a632c"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("8e70370c-5331-4fc1-857e-724c65a932c5"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("cede83f3-7aee-41a7-80b1-01e923f39a3e"));

            migrationBuilder.DeleteData(
                table: "precios",
                keyColumn: "Id",
                keyValue: new Guid("6f3b0099-7b2c-49b5-87ec-b51059ef319e"));

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
        }
    }
}
