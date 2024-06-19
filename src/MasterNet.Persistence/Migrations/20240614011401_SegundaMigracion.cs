using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MasterNet.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class SegundaMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_calificacion_cursos_CursoId",
                table: "calificacion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_calificacion",
                table: "calificacion");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a977e07-a257-44c9-886f-fd6403888020");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad6c2a90-f6da-4d64-96c3-ab1f0c38d96d");

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("3c2b51ec-b1f2-46db-af60-7e9662e191db"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("45867903-7f6f-4e00-ab1f-d65a085f1312"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("6824e892-b461-4556-b5e5-e0b0e7099039"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("6b07a0cc-f8f1-43b8-b17f-e6b217443ade"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("82111fb4-b0f3-40cd-a1dd-5542b6f44e73"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("9f102b1d-c0a5-4693-a92a-8d2c8aa4a45d"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("a010f105-c86b-40f9-963f-db096a5555ad"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("a1a7f0ed-1d5c-4392-8a63-d112ba006cf0"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("de1ef256-d2b2-416f-b082-86ae66b4e2d1"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("02ce2ece-491a-4400-b2c8-d24992bab593"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("12bc591b-64d5-4fe2-b9b7-b3679ce33351"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("38b0b4e8-40c1-4f39-88b5-570ded413ece"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("4d96de25-8cc9-49e2-bad9-de6a20849f58"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("59d7e758-6c8e-40a0-b91c-afc8ef6157e6"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("97b3161f-9290-4582-a223-eb5e1346fd75"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("9fb1bffc-238a-4034-8462-8882b7500112"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("ad5d6cef-0d63-44b1-ab51-c3c1d25130b5"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("c35b9822-3b53-4ff6-b452-e6fcfb0660b1"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("f0c7aff0-0988-4b89-be9a-3432598c0287"));

            migrationBuilder.DeleteData(
                table: "precios",
                keyColumn: "Id",
                keyValue: new Guid("3a390a7c-e008-43c8-9dff-c3a126af5250"));

            migrationBuilder.RenameTable(
                name: "calificacion",
                newName: "calificaciones");

            migrationBuilder.RenameIndex(
                name: "IX_calificacion_CursoId",
                table: "calificaciones",
                newName: "IX_calificaciones_CursoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_calificaciones",
                table: "calificaciones",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "RoleId",
                value: "7d7a87a4-e583-4930-a98c-c6846c42d1a8");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "RoleId",
                value: "7d7a87a4-e583-4930-a98c-c6846c42d1a8");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "RoleId",
                value: "7d7a87a4-e583-4930-a98c-c6846c42d1a8");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 4,
                column: "RoleId",
                value: "7d7a87a4-e583-4930-a98c-c6846c42d1a8");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 5,
                column: "RoleId",
                value: "7d7a87a4-e583-4930-a98c-c6846c42d1a8");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 6,
                column: "RoleId",
                value: "7d7a87a4-e583-4930-a98c-c6846c42d1a8");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 7,
                column: "RoleId",
                value: "7d7a87a4-e583-4930-a98c-c6846c42d1a8");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 8,
                column: "RoleId",
                value: "7d7a87a4-e583-4930-a98c-c6846c42d1a8");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 9,
                column: "RoleId",
                value: "7d7a87a4-e583-4930-a98c-c6846c42d1a8");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 10,
                column: "RoleId",
                value: "7d7a87a4-e583-4930-a98c-c6846c42d1a8");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 11,
                column: "RoleId",
                value: "2ee0c5c3-38d6-4773-9839-3ae5229099a0");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 12,
                column: "RoleId",
                value: "2ee0c5c3-38d6-4773-9839-3ae5229099a0");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 13,
                column: "RoleId",
                value: "2ee0c5c3-38d6-4773-9839-3ae5229099a0");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 14,
                column: "RoleId",
                value: "2ee0c5c3-38d6-4773-9839-3ae5229099a0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2ee0c5c3-38d6-4773-9839-3ae5229099a0", null, "CLIENT", "CLIENT" },
                    { "7d7a87a4-e583-4930-a98c-c6846c42d1a8", null, "ADMIN", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "cursos",
                columns: new[] { "Id", "Descripcion", "FechaPulicacion", "Titulo" },
                values: new object[,]
                {
                    { new Guid("43b8cd84-b029-49e8-9dda-7305e6970c44"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new DateTime(2024, 6, 13, 19, 14, 1, 91, DateTimeKind.Local).AddTicks(6115), "Practical Frozen Sausages" },
                    { new Guid("49e03add-cd8b-41c2-8adc-92142af69430"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new DateTime(2024, 6, 13, 19, 14, 1, 91, DateTimeKind.Local).AddTicks(6044), "Handcrafted Fresh Pizza" },
                    { new Guid("5613b2d9-7b83-4482-ba5b-a19089f4c772"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new DateTime(2024, 6, 13, 19, 14, 1, 91, DateTimeKind.Local).AddTicks(6003), "Tasty Plastic Gloves" },
                    { new Guid("5d650719-1100-4f2a-acc8-28f828d81ea0"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new DateTime(2024, 6, 13, 19, 14, 1, 91, DateTimeKind.Local).AddTicks(6133), "Refined Plastic Keyboard" },
                    { new Guid("6e0626b4-566d-437d-a649-75c89c89c5f8"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new DateTime(2024, 6, 13, 19, 14, 1, 91, DateTimeKind.Local).AddTicks(6091), "Unbranded Concrete Table" },
                    { new Guid("6ee4ed3e-2e61-4d80-8022-dc15cb55a714"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new DateTime(2024, 6, 13, 19, 14, 1, 91, DateTimeKind.Local).AddTicks(6183), "Unbranded Fresh Salad" },
                    { new Guid("98033876-bfaa-4c80-be6c-743033df50c1"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new DateTime(2024, 6, 13, 19, 14, 1, 91, DateTimeKind.Local).AddTicks(5967), "Fantastic Steel Car" },
                    { new Guid("be3dae41-a69f-4912-bf35-cc6a2cf08817"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new DateTime(2024, 6, 13, 19, 14, 1, 91, DateTimeKind.Local).AddTicks(6024), "Refined Granite Towels" },
                    { new Guid("d965025b-99ec-4229-ba3b-00ffef8e3e13"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new DateTime(2024, 6, 13, 19, 14, 1, 91, DateTimeKind.Local).AddTicks(6166), "Sleek Granite Towels" }
                });

            migrationBuilder.InsertData(
                table: "instructores",
                columns: new[] { "Id", "Apellidos", "Grado", "Nombre" },
                values: new object[,]
                {
                    { new Guid("090bf260-6762-4b56-8d57-34315fa2b93a"), "Wolf", "Principal Security Facilitator", "Raegan" },
                    { new Guid("0a60ff92-d478-4a31-b6b6-322bd09959fe"), "Kovacek", "Corporate Research Planner", "Brandi" },
                    { new Guid("2291bd74-7133-48ea-970e-a01f69d6da35"), "Stracke", "Legacy Accounts Facilitator", "Jed" },
                    { new Guid("5d21ff10-2dbd-45b7-b941-15814781bfc7"), "Walsh", "Chief Communications Consultant", "Vern" },
                    { new Guid("6e4938ce-e434-4bee-a9d1-d797c9b279f1"), "Murray", "Product Data Specialist", "Stefan" },
                    { new Guid("7cd0b0e8-4504-449d-848e-2d86c1e930c3"), "Greenholt", "Product Directives Assistant", "Sanford" },
                    { new Guid("7d12aa40-005c-4f16-a803-b5a8fe6a8253"), "Turcotte", "Global Response Supervisor", "Dino" },
                    { new Guid("88b239b8-fbf0-4923-a3b6-721df70b6980"), "Ortiz", "Forward Branding Orchestrator", "Flavio" },
                    { new Guid("a72112e0-6ee5-4032-b0b6-51756b50dc51"), "Toy", "Principal Marketing Designer", "Vita" },
                    { new Guid("fb3b88c8-aa25-45eb-933e-2ac33c5a9b84"), "Strosin", "Future Functionality Manager", "Layla" }
                });

            migrationBuilder.InsertData(
                table: "precios",
                columns: new[] { "Id", "Nombre", "PrecioActual", "PrecioPromocion" },
                values: new object[] { new Guid("0b2a909d-5d78-4df1-ba91-d2f0c92c5d2f"), "Precio Regular", 10.0m, 8.0m });

            migrationBuilder.AddForeignKey(
                name: "FK_calificaciones_cursos_CursoId",
                table: "calificaciones",
                column: "CursoId",
                principalTable: "cursos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_calificaciones_cursos_CursoId",
                table: "calificaciones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_calificaciones",
                table: "calificaciones");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2ee0c5c3-38d6-4773-9839-3ae5229099a0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7d7a87a4-e583-4930-a98c-c6846c42d1a8");

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("43b8cd84-b029-49e8-9dda-7305e6970c44"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("49e03add-cd8b-41c2-8adc-92142af69430"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("5613b2d9-7b83-4482-ba5b-a19089f4c772"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("5d650719-1100-4f2a-acc8-28f828d81ea0"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("6e0626b4-566d-437d-a649-75c89c89c5f8"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("6ee4ed3e-2e61-4d80-8022-dc15cb55a714"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("98033876-bfaa-4c80-be6c-743033df50c1"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("be3dae41-a69f-4912-bf35-cc6a2cf08817"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("d965025b-99ec-4229-ba3b-00ffef8e3e13"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("090bf260-6762-4b56-8d57-34315fa2b93a"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("0a60ff92-d478-4a31-b6b6-322bd09959fe"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("2291bd74-7133-48ea-970e-a01f69d6da35"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("5d21ff10-2dbd-45b7-b941-15814781bfc7"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("6e4938ce-e434-4bee-a9d1-d797c9b279f1"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("7cd0b0e8-4504-449d-848e-2d86c1e930c3"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("7d12aa40-005c-4f16-a803-b5a8fe6a8253"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("88b239b8-fbf0-4923-a3b6-721df70b6980"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("a72112e0-6ee5-4032-b0b6-51756b50dc51"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("fb3b88c8-aa25-45eb-933e-2ac33c5a9b84"));

            migrationBuilder.DeleteData(
                table: "precios",
                keyColumn: "Id",
                keyValue: new Guid("0b2a909d-5d78-4df1-ba91-d2f0c92c5d2f"));

            migrationBuilder.RenameTable(
                name: "calificaciones",
                newName: "calificacion");

            migrationBuilder.RenameIndex(
                name: "IX_calificaciones_CursoId",
                table: "calificacion",
                newName: "IX_calificacion_CursoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_calificacion",
                table: "calificacion",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "RoleId",
                value: "4a977e07-a257-44c9-886f-fd6403888020");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "RoleId",
                value: "4a977e07-a257-44c9-886f-fd6403888020");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "RoleId",
                value: "4a977e07-a257-44c9-886f-fd6403888020");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 4,
                column: "RoleId",
                value: "4a977e07-a257-44c9-886f-fd6403888020");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 5,
                column: "RoleId",
                value: "4a977e07-a257-44c9-886f-fd6403888020");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 6,
                column: "RoleId",
                value: "4a977e07-a257-44c9-886f-fd6403888020");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 7,
                column: "RoleId",
                value: "4a977e07-a257-44c9-886f-fd6403888020");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 8,
                column: "RoleId",
                value: "4a977e07-a257-44c9-886f-fd6403888020");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 9,
                column: "RoleId",
                value: "4a977e07-a257-44c9-886f-fd6403888020");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 10,
                column: "RoleId",
                value: "4a977e07-a257-44c9-886f-fd6403888020");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 11,
                column: "RoleId",
                value: "ad6c2a90-f6da-4d64-96c3-ab1f0c38d96d");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 12,
                column: "RoleId",
                value: "ad6c2a90-f6da-4d64-96c3-ab1f0c38d96d");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 13,
                column: "RoleId",
                value: "ad6c2a90-f6da-4d64-96c3-ab1f0c38d96d");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 14,
                column: "RoleId",
                value: "ad6c2a90-f6da-4d64-96c3-ab1f0c38d96d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4a977e07-a257-44c9-886f-fd6403888020", null, "ADMIN", "ADMIN" },
                    { "ad6c2a90-f6da-4d64-96c3-ab1f0c38d96d", null, "CLIENT", "CLIENT" }
                });

            migrationBuilder.InsertData(
                table: "cursos",
                columns: new[] { "Id", "Descripcion", "FechaPulicacion", "Titulo" },
                values: new object[,]
                {
                    { new Guid("3c2b51ec-b1f2-46db-af60-7e9662e191db"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new DateTime(2024, 6, 10, 20, 20, 25, 235, DateTimeKind.Local).AddTicks(6484), "Handmade Rubber Gloves" },
                    { new Guid("45867903-7f6f-4e00-ab1f-d65a085f1312"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new DateTime(2024, 6, 10, 20, 20, 25, 235, DateTimeKind.Local).AddTicks(6442), "Generic Granite Car" },
                    { new Guid("6824e892-b461-4556-b5e5-e0b0e7099039"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new DateTime(2024, 6, 10, 20, 20, 25, 235, DateTimeKind.Local).AddTicks(6324), "Sleek Metal Salad" },
                    { new Guid("6b07a0cc-f8f1-43b8-b17f-e6b217443ade"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new DateTime(2024, 6, 10, 20, 20, 25, 235, DateTimeKind.Local).AddTicks(6401), "Awesome Wooden Towels" },
                    { new Guid("82111fb4-b0f3-40cd-a1dd-5542b6f44e73"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new DateTime(2024, 6, 10, 20, 20, 25, 235, DateTimeKind.Local).AddTicks(6233), "Licensed Concrete Hat" },
                    { new Guid("9f102b1d-c0a5-4693-a92a-8d2c8aa4a45d"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new DateTime(2024, 6, 10, 20, 20, 25, 235, DateTimeKind.Local).AddTicks(6359), "Refined Cotton Mouse" },
                    { new Guid("a010f105-c86b-40f9-963f-db096a5555ad"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new DateTime(2024, 6, 10, 20, 20, 25, 235, DateTimeKind.Local).AddTicks(6304), "Sleek Cotton Mouse" },
                    { new Guid("a1a7f0ed-1d5c-4392-8a63-d112ba006cf0"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new DateTime(2024, 6, 10, 20, 20, 25, 235, DateTimeKind.Local).AddTicks(6463), "Practical Rubber Pizza" },
                    { new Guid("de1ef256-d2b2-416f-b082-86ae66b4e2d1"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new DateTime(2024, 6, 10, 20, 20, 25, 235, DateTimeKind.Local).AddTicks(6380), "Generic Frozen Chair" }
                });

            migrationBuilder.InsertData(
                table: "instructores",
                columns: new[] { "Id", "Apellidos", "Grado", "Nombre" },
                values: new object[,]
                {
                    { new Guid("02ce2ece-491a-4400-b2c8-d24992bab593"), "Predovic", "Corporate Implementation Analyst", "Hollis" },
                    { new Guid("12bc591b-64d5-4fe2-b9b7-b3679ce33351"), "Cremin", "Lead Assurance Agent", "Melvin" },
                    { new Guid("38b0b4e8-40c1-4f39-88b5-570ded413ece"), "Graham", "Direct Interactions Associate", "Samantha" },
                    { new Guid("4d96de25-8cc9-49e2-bad9-de6a20849f58"), "Wolf", "Customer Group Director", "Novella" },
                    { new Guid("59d7e758-6c8e-40a0-b91c-afc8ef6157e6"), "Hessel", "Future Data Liaison", "Olin" },
                    { new Guid("97b3161f-9290-4582-a223-eb5e1346fd75"), "McCullough", "Product Configuration Agent", "Rowland" },
                    { new Guid("9fb1bffc-238a-4034-8462-8882b7500112"), "King", "Corporate Interactions Assistant", "Destany" },
                    { new Guid("ad5d6cef-0d63-44b1-ab51-c3c1d25130b5"), "Gottlieb", "International Directives Developer", "Loraine" },
                    { new Guid("c35b9822-3b53-4ff6-b452-e6fcfb0660b1"), "Zboncak", "Senior Web Strategist", "Loyce" },
                    { new Guid("f0c7aff0-0988-4b89-be9a-3432598c0287"), "Leuschke", "Product Accounts Coordinator", "Ambrose" }
                });

            migrationBuilder.InsertData(
                table: "precios",
                columns: new[] { "Id", "Nombre", "PrecioActual", "PrecioPromocion" },
                values: new object[] { new Guid("3a390a7c-e008-43c8-9dff-c3a126af5250"), "Precio Regular", 10.0m, 8.0m });

            migrationBuilder.AddForeignKey(
                name: "FK_calificacion_cursos_CursoId",
                table: "calificacion",
                column: "CursoId",
                principalTable: "cursos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
