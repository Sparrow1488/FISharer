using Microsoft.EntityFrameworkCore.Migrations;

namespace FISharer.Migrations.FilesDb
{
    public partial class CreateDataInfos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DataInfoJson",
                table: "Files",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "FilesInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Size = table.Column<long>(type: "bigint", nullable: false),
                    ArchiveDataId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilesInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FilesInfos_Files_ArchiveDataId",
                        column: x => x.ArchiveDataId,
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FilesInfos_ArchiveDataId",
                table: "FilesInfos",
                column: "ArchiveDataId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FilesInfos");

            migrationBuilder.DropColumn(
                name: "DataInfoJson",
                table: "Files");
        }
    }
}
