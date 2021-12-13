using Microsoft.EntityFrameworkCore.Migrations;

namespace PS.Template.AccessData.Migrations
{
    public partial class version2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Especialidad",
                columns: table => new
                {
                    EspecialidadId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Especialidad_desc = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especialidad", x => x.EspecialidadId);
                });

            migrationBuilder.CreateTable(
                name: "Partido",
                columns: table => new
                {
                    PartidoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Partido_desc = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partido", x => x.PartidoId);
                });

            migrationBuilder.CreateTable(
                name: "Clinica",
                columns: table => new
                {
                    ClinicaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Clinica_desc = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Clinica_direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PartidoId = table.Column<int>(type: "int", nullable: false),
                    Imagen = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clinica", x => x.ClinicaId);
                    table.ForeignKey(
                        name: "FK_Clinica_Partido_PartidoId",
                        column: x => x.PartidoId,
                        principalTable: "Partido",
                        principalColumn: "PartidoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Medico",
                columns: table => new
                {
                    MedicoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Apellido = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    DNI = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    PartidoId = table.Column<int>(type: "int", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Matricula = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    EspecialidadId = table.Column<int>(type: "int", nullable: false),
                    ClinicaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medico", x => x.MedicoId);
                    table.ForeignKey(
                        name: "FK_Medico_Clinica_ClinicaId",
                        column: x => x.ClinicaId,
                        principalTable: "Clinica",
                        principalColumn: "ClinicaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Medico_Especialidad_EspecialidadId",
                        column: x => x.EspecialidadId,
                        principalTable: "Especialidad",
                        principalColumn: "EspecialidadId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Medico_Partido_PartidoId",
                        column: x => x.PartidoId,
                        principalTable: "Partido",
                        principalColumn: "PartidoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Especialidad",
                columns: new[] { "EspecialidadId", "Especialidad_desc" },
                values: new object[,]
                {
                    { 1, "Traumatología" },
                    { 2, "Cardiología" },
                    { 3, "Dermatología" }
                });

            migrationBuilder.InsertData(
                table: "Partido",
                columns: new[] { "PartidoId", "Partido_desc" },
                values: new object[,]
                {
                    { 1, "Florencio Varela" },
                    { 2, "Quilmes" },
                    { 3, "Berazategui" }
                });

            migrationBuilder.InsertData(
                table: "Clinica",
                columns: new[] { "ClinicaId", "Clinica_desc", "Clinica_direccion", "Imagen", "PartidoId" },
                values: new object[,]
                {
                    { 1, "Hospital Interzonal El Cruce", null, "https://bit.ly/3w1u9nf", 1 },
                    { 5, "Clinica Ranelagh", null, "https://bit.ly/3ExrkgD", 1 },
                    { 2, "Clinica Modelo Quilmes", null, "https://bit.ly/3pUaCUF", 2 },
                    { 4, "Clinica Monte Grande", null, "https://bit.ly/3w66TEO", 2 },
                    { 3, "Hospital Evita Pueblo", null, "https://bit.ly/3jTVMJU", 3 },
                    { 6, "Sanatorio Modelo Adrogue", null, "https://bit.ly/3GGkRSH", 3 }
                });

            migrationBuilder.InsertData(
                table: "Medico",
                columns: new[] { "MedicoId", "Apellido", "ClinicaId", "DNI", "Email", "EspecialidadId", "Matricula", "Nombre", "PartidoId", "Telefono", "UsuarioId" },
                values: new object[] { 1, "Perez", 1, "11111111", "doctor1@gmail.com", 1, "123564", "Juan", 1, "123456789", 0 });

            migrationBuilder.InsertData(
                table: "Medico",
                columns: new[] { "MedicoId", "Apellido", "ClinicaId", "DNI", "Email", "EspecialidadId", "Matricula", "Nombre", "PartidoId", "Telefono", "UsuarioId" },
                values: new object[] { 2, "Medic", 1, "11111123", "doctor2@gmail.com", 2, "120000", "Tito", 3, "123456666", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Clinica_PartidoId",
                table: "Clinica",
                column: "PartidoId");

            migrationBuilder.CreateIndex(
                name: "IX_Medico_ClinicaId",
                table: "Medico",
                column: "ClinicaId");

            migrationBuilder.CreateIndex(
                name: "IX_Medico_EspecialidadId",
                table: "Medico",
                column: "EspecialidadId");

            migrationBuilder.CreateIndex(
                name: "IX_Medico_PartidoId",
                table: "Medico",
                column: "PartidoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Medico");

            migrationBuilder.DropTable(
                name: "Clinica");

            migrationBuilder.DropTable(
                name: "Especialidad");

            migrationBuilder.DropTable(
                name: "Partido");
        }
    }
}
