using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RetailShops.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DiscountType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    DiscountTypeName = table.Column<string>(nullable: true),
                    Rate = table.Column<int>(nullable: false),
                    IsPercentage = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscountType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false),
                    UserType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    TypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    InvoiceSerialNumber = table.Column<string>(nullable: false),
                    OrderTotal = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Invoices_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceDetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    ProductPrice = table.Column<decimal>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    DiscountPrice = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    InvoiceId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InvoiceDetail_Invoices_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "Invoices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "DiscountType",
                columns: new[] { "Id", "CreatedDate", "DiscountTypeName", "IsPercentage", "Rate" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AffiliateStore", true, 10 },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee", true, 30 },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Customer", true, 30 },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Discount", false, 5 }
                });

            migrationBuilder.InsertData(
                table: "UserType",
                columns: new[] { "Id", "CreatedDate", "TypeName" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Customer" },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee" },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AffiliateStore" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "Email", "LastName", "Name", "PhoneNumber", "UserType" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 2, 5, 19, 15, 24, 770, DateTimeKind.Local).AddTicks(3626), "sezer.darendeli@gmail.com", "Darendeli", "Sezer", "055533322", 1 },
                    { 2, new DateTime(2022, 2, 5, 19, 15, 24, 770, DateTimeKind.Local).AddTicks(3714), "simith.johnson@gmail.com", "Johnson", "Smith", "055533322", 3 },
                    { 3, new DateTime(2022, 2, 5, 19, 15, 24, 770, DateTimeKind.Local).AddTicks(3717), "williams.brown@gmail.com", "Brown", "Williams", "055533322", 2 }
                });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "Id", "CreatedDate", "InvoiceSerialNumber", "OrderTotal", "Total", "UserId" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A0001", 0m, 1000m, 1 });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "Id", "CreatedDate", "InvoiceSerialNumber", "OrderTotal", "Total", "UserId" },
                values: new object[] { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A0002", 0m, 1000m, 2 });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "Id", "CreatedDate", "InvoiceSerialNumber", "OrderTotal", "Total", "UserId" },
                values: new object[] { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A0003", 0m, 1000m, 3 });

            migrationBuilder.InsertData(
                table: "InvoiceDetail",
                columns: new[] { "Id", "CreatedDate", "DiscountPrice", "InvoiceId", "ProductId", "ProductName", "ProductPrice", "Quantity" },
                values: new object[] { 1, new DateTime(2022, 2, 5, 19, 15, 24, 772, DateTimeKind.Local).AddTicks(7589), 0m, 1, 2, "HP Pavilion", 500m, 2 });

            migrationBuilder.InsertData(
                table: "InvoiceDetail",
                columns: new[] { "Id", "CreatedDate", "DiscountPrice", "InvoiceId", "ProductId", "ProductName", "ProductPrice", "Quantity" },
                values: new object[] { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 2, 2, "HP Pavilion", 500m, 2 });

            migrationBuilder.InsertData(
                table: "InvoiceDetail",
                columns: new[] { "Id", "CreatedDate", "DiscountPrice", "InvoiceId", "ProductId", "ProductName", "ProductPrice", "Quantity" },
                values: new object[] { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 3, 2, "HP Pavilion", 500m, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceDetail_InvoiceId",
                table: "InvoiceDetail",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_UserId",
                table: "Invoices",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiscountType");

            migrationBuilder.DropTable(
                name: "InvoiceDetail");

            migrationBuilder.DropTable(
                name: "UserType");

            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
