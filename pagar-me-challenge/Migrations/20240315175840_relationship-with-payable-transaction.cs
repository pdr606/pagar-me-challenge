using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pagar_me_challenge.Migrations
{
    /// <inheritdoc />
    public partial class relationshipwithpayabletransaction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "PayableId",
                table: "Transactions",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<decimal>(
                name: "Total",
                table: "Transactions",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_PayableId",
                table: "Transactions",
                column: "PayableId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Payables_PayableId",
                table: "Transactions",
                column: "PayableId",
                principalTable: "Payables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Payables_PayableId",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_PayableId",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "PayableId",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "Transactions");
        }
    }
}
