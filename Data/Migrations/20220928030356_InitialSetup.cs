using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace rysaBeauty.Data.Migrations
{
    public partial class InitialSetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Article",
                columns: table => new
                {
                    Numero_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fournisseur = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prix_Gros = table.Column<int>(type: "int", nullable: false),
                    Prix_Vente = table.Column<int>(type: "int", nullable: false),
                    Quantite_Stock = table.Column<int>(type: "int", nullable: false),
                    Quantite_Vendu = table.Column<int>(type: "int", nullable: false),
                    Client = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Article", x => x.Numero_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Article");
        }
    }
}
