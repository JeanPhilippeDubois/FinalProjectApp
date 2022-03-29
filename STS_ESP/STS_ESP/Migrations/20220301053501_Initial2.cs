using Microsoft.EntityFrameworkCore.Migrations;

namespace STS_ESP.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarteUsagers_Abonnement_AboId",
                table: "CarteUsagers");

            migrationBuilder.DropForeignKey(
                name: "FK_Usager_CarteUsagers_CarteId",
                table: "Usager");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usager",
                table: "Usager");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Abonnement",
                table: "Abonnement");

            migrationBuilder.RenameTable(
                name: "Usager",
                newName: "Usagers");

            migrationBuilder.RenameTable(
                name: "Abonnement",
                newName: "Abonnements");

            migrationBuilder.RenameIndex(
                name: "IX_Usager_CarteId",
                table: "Usagers",
                newName: "IX_Usagers_CarteId");

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Employes",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usagers",
                table: "Usagers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Abonnements",
                table: "Abonnements",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CarteUsagers_Abonnements_AboId",
                table: "CarteUsagers",
                column: "AboId",
                principalTable: "Abonnements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Usagers_CarteUsagers_CarteId",
                table: "Usagers",
                column: "CarteId",
                principalTable: "CarteUsagers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarteUsagers_Abonnements_AboId",
                table: "CarteUsagers");

            migrationBuilder.DropForeignKey(
                name: "FK_Usagers_CarteUsagers_CarteId",
                table: "Usagers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usagers",
                table: "Usagers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Abonnements",
                table: "Abonnements");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Employes");

            migrationBuilder.RenameTable(
                name: "Usagers",
                newName: "Usager");

            migrationBuilder.RenameTable(
                name: "Abonnements",
                newName: "Abonnement");

            migrationBuilder.RenameIndex(
                name: "IX_Usagers_CarteId",
                table: "Usager",
                newName: "IX_Usager_CarteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usager",
                table: "Usager",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Abonnement",
                table: "Abonnement",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CarteUsagers_Abonnement_AboId",
                table: "CarteUsagers",
                column: "AboId",
                principalTable: "Abonnement",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Usager_CarteUsagers_CarteId",
                table: "Usager",
                column: "CarteId",
                principalTable: "CarteUsagers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
