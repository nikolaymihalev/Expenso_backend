using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Expenso.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Account identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Account owner"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Account name"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Account type"),
                    Balance = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false, comment: "Account balance"),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Account currency"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Account creation date")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                },
                comment: "Accounts (bank, cash, crypto, etc.)");

            migrationBuilder.CreateTable(
                name: "Budgets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Budget identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "User identifier"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Budget name"),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false, comment: "Budget amount"),
                    Period = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Budget period"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Budget start date"),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Budget end date")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Budgets", x => x.Id);
                },
                comment: "Budget planning and management");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Unique identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Category name"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Category type")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                },
                comment: "Expense/income categories");

            migrationBuilder.CreateTable(
                name: "CurrencyRates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Unique identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BaseCurrency = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Base currency"),
                    TargetCurrency = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Converted currency"),
                    Rate = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false, comment: "Exchange rate"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Last update date")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrencyRates", x => x.Id);
                },
                comment: "Currency rate converter");

            migrationBuilder.CreateTable(
                name: "Investments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Investment identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "User identifier"),
                    AssetType = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Investment asset type"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Investment name"),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false, comment: "Invested amount"),
                    CurrentValue = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false, comment: "Current value")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Investments", x => x.Id);
                },
                comment: "Investment tracking (stocks, cryptocurrencies)");

            migrationBuilder.CreateTable(
                name: "SavingGoals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Saving goal identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "User identifier"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Saving goal name"),
                    TargetAmount = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false, comment: "Saving goal target amount"),
                    CurrentAmount = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false, comment: "Saving goal current amount"),
                    Deadline = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Saving goal deadline")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SavingGoals", x => x.Id);
                },
                comment: "Tracking progress towards a specific financial goal");

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Transaction identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "User identifier"),
                    AccountId = table.Column<int>(type: "int", nullable: false, comment: "Account identifier"),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false, comment: "Transaction amount"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Transaction type"),
                    CategoryId = table.Column<int>(type: "int", nullable: false, comment: "Category identifier"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Transaction date"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Transaction description"),
                    IsRecurring = table.Column<bool>(type: "bit", nullable: false, comment: "Is transaction recurring")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transactions_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transactions_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Tracks income and expenses");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_AccountId",
                table: "Transactions",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_CategoryId",
                table: "Transactions",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Budgets");

            migrationBuilder.DropTable(
                name: "CurrencyRates");

            migrationBuilder.DropTable(
                name: "Investments");

            migrationBuilder.DropTable(
                name: "SavingGoals");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
