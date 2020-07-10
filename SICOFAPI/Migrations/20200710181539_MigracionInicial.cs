using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SICOFAPI.Migrations
{
    public partial class MigracionInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "taskEntities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Estado = table.Column<int>(nullable: false),
                    fechaCreacion = table.Column<DateTime>(nullable: false),
                    UsuarioCrea = table.Column<string>(nullable: true),
                    fechaEdicion = table.Column<DateTime>(nullable: false),
                    usuarioModifica = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_taskEntities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Version",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Estado = table.Column<int>(nullable: false),
                    fechaCreacion = table.Column<DateTime>(nullable: false),
                    UsuarioCrea = table.Column<string>(nullable: true),
                    fechaEdicion = table.Column<DateTime>(nullable: false),
                    usuarioModifica = table.Column<string>(nullable: true),
                    Nombre_Plataforma = table.Column<string>(maxLength: 255, nullable: true),
                    Fecha_Publicacion = table.Column<DateTime>(nullable: false),
                    Numero_Version = table.Column<string>(maxLength: 20, nullable: true),
                    Ambiente = table.Column<string>(maxLength: 20, nullable: true),
                    Rama_Origen = table.Column<string>(maxLength: 20, nullable: true),
                    Descripcion = table.Column<string>(maxLength: 1500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Version", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "taskEntities");

            migrationBuilder.DropTable(
                name: "Version");
        }
    }
}
