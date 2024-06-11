using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class init_update_hepsi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Portfolios_PortfolioDetailss_PortfolioDetailsId",
                table: "Portfolios");

            migrationBuilder.DropIndex(
                name: "IX_Portfolios_PortfolioDetailsId",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "PortfolioDetailsId",
                table: "Portfolios");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PortfolioDetailsId",
                table: "Portfolios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Portfolios_PortfolioDetailsId",
                table: "Portfolios",
                column: "PortfolioDetailsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Portfolios_PortfolioDetailss_PortfolioDetailsId",
                table: "Portfolios",
                column: "PortfolioDetailsId",
                principalTable: "PortfolioDetailss",
                principalColumn: "PortfolioDetailsId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
