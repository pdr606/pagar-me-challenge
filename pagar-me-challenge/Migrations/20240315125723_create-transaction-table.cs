using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pagar_me_challenge.Migrations
{
    /// <inheritdoc />
    public partial class createtransactiontable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Card_Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Card_Carrier = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Card_Validate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Card_CVV = table.Column<int>(type: "int", nullable: false),
                    PaymentMethod = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transactions");
        }
    }
}
