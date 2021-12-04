using Microsoft.EntityFrameworkCore.Migrations;

namespace FISharer.Migrations.FilesDb
{
    public partial class ArchiveDataId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FilesInfos_Files_ArchiveDataId",
                table: "FilesInfos");

            migrationBuilder.AddForeignKey(
                name: "FK_FilesInfos_Files_ArchiveDataId",
                table: "FilesInfos",
                column: "ArchiveDataId",
                principalTable: "Files",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FilesInfos_Files_ArchiveDataId",
                table: "FilesInfos");

            migrationBuilder.AddForeignKey(
                name: "FK_FilesInfos_Files_ArchiveDataId",
                table: "FilesInfos",
                column: "ArchiveDataId",
                principalTable: "Files",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
