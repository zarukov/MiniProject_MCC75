using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MiniProject_MCC75.Migrations
{
    /// <inheritdoc />
    public partial class InitialCommit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_nha_office",
                columns: table => new
                {
                    code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    city = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    phone_number = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    address1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    address2 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    state = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    country = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    postal_code = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    territory = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_nha_office", x => x.code);
                });

            migrationBuilder.CreateTable(
                name: "tb_nha_productline",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_nha_productline", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tb_nha_roles",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_nha_roles", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tb_nha_employee",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    office_code = table.Column<int>(type: "int", nullable: false),
                    reports_to = table.Column<int>(type: "int", nullable: false),
                    first_name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    last_name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    job_title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_nha_employee", x => x.id);
                    table.ForeignKey(
                        name: "FK_tb_nha_employee_tb_nha_employee_reports_to",
                        column: x => x.reports_to,
                        principalTable: "tb_nha_employee",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_tb_nha_employee_tb_nha_office_office_code",
                        column: x => x.office_code,
                        principalTable: "tb_nha_office",
                        principalColumn: "code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_nha_product",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productline_id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    scale = table.Column<int>(type: "int", nullable: false),
                    vendor = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    pdt_description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    qtyinstock = table.Column<int>(type: "int", nullable: false),
                    buyprice = table.Column<int>(type: "int", nullable: false),
                    msrp = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_nha_product", x => x.id);
                    table.ForeignKey(
                        name: "FK_tb_nha_product_tb_nha_productline_productline_id",
                        column: x => x.productline_id,
                        principalTable: "tb_nha_productline",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_nha_accounts",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    password = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_nha_accounts", x => x.id);
                    table.ForeignKey(
                        name: "FK_tb_nha_accounts_tb_nha_employee_id",
                        column: x => x.id,
                        principalTable: "tb_nha_employee",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_nha_customer",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    employee_id = table.Column<int>(type: "int", nullable: false),
                    first_name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    last_name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    phone_number = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    address1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    address2 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    city = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    state = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    postal_code = table.Column<int>(type: "int", maxLength: 255, nullable: false),
                    country = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    credit_limit = table.Column<int>(type: "int", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_nha_customer", x => x.id);
                    table.ForeignKey(
                        name: "FK_tb_nha_customer_tb_nha_employee_employee_id",
                        column: x => x.employee_id,
                        principalTable: "tb_nha_employee",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_nha_accountroles",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    account_id = table.Column<int>(type: "int", nullable: false),
                    role_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_nha_accountroles", x => x.id);
                    table.ForeignKey(
                        name: "FK_tb_nha_accountroles_tb_nha_accounts_account_id",
                        column: x => x.account_id,
                        principalTable: "tb_nha_accounts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_nha_accountroles_tb_nha_roles_role_id",
                        column: x => x.role_id,
                        principalTable: "tb_nha_roles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_nha_order",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customer_id = table.Column<int>(type: "int", nullable: false),
                    order_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    required_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    shipped_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    comment = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_nha_order", x => x.id);
                    table.ForeignKey(
                        name: "FK_tb_nha_order_tb_nha_customer_customer_id",
                        column: x => x.customer_id,
                        principalTable: "tb_nha_customer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_nha_payment",
                columns: table => new
                {
                    check_num = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    customer_id = table.Column<int>(type: "int", nullable: false),
                    payment_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_nha_payment", x => x.check_num);
                    table.ForeignKey(
                        name: "FK_tb_nha_payment_tb_nha_customer_customer_id",
                        column: x => x.customer_id,
                        principalTable: "tb_nha_customer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_nha_orderproduct",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    order_id = table.Column<int>(type: "int", nullable: false),
                    product_id = table.Column<int>(type: "int", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    price_each = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_nha_orderproduct", x => x.id);
                    table.ForeignKey(
                        name: "FK_tb_nha_orderproduct_tb_nha_order_order_id",
                        column: x => x.order_id,
                        principalTable: "tb_nha_order",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_nha_orderproduct_tb_nha_product_product_id",
                        column: x => x.product_id,
                        principalTable: "tb_nha_product",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "tb_nha_roles",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "User" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_nha_accountroles_account_id",
                table: "tb_nha_accountroles",
                column: "account_id");

            migrationBuilder.CreateIndex(
                name: "IX_tb_nha_accountroles_role_id",
                table: "tb_nha_accountroles",
                column: "role_id");

            migrationBuilder.CreateIndex(
                name: "IX_tb_nha_customer_employee_id",
                table: "tb_nha_customer",
                column: "employee_id");

            migrationBuilder.CreateIndex(
                name: "IX_tb_nha_customer_phone_number",
                table: "tb_nha_customer",
                column: "phone_number",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tb_nha_employee_email",
                table: "tb_nha_employee",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tb_nha_employee_office_code",
                table: "tb_nha_employee",
                column: "office_code");

            migrationBuilder.CreateIndex(
                name: "IX_tb_nha_employee_reports_to",
                table: "tb_nha_employee",
                column: "reports_to");

            migrationBuilder.CreateIndex(
                name: "IX_tb_nha_office_phone_number",
                table: "tb_nha_office",
                column: "phone_number",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tb_nha_order_customer_id",
                table: "tb_nha_order",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_tb_nha_orderproduct_order_id",
                table: "tb_nha_orderproduct",
                column: "order_id");

            migrationBuilder.CreateIndex(
                name: "IX_tb_nha_orderproduct_product_id",
                table: "tb_nha_orderproduct",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_tb_nha_payment_customer_id",
                table: "tb_nha_payment",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_tb_nha_product_productline_id",
                table: "tb_nha_product",
                column: "productline_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_nha_accountroles");

            migrationBuilder.DropTable(
                name: "tb_nha_orderproduct");

            migrationBuilder.DropTable(
                name: "tb_nha_payment");

            migrationBuilder.DropTable(
                name: "tb_nha_accounts");

            migrationBuilder.DropTable(
                name: "tb_nha_roles");

            migrationBuilder.DropTable(
                name: "tb_nha_order");

            migrationBuilder.DropTable(
                name: "tb_nha_product");

            migrationBuilder.DropTable(
                name: "tb_nha_customer");

            migrationBuilder.DropTable(
                name: "tb_nha_productline");

            migrationBuilder.DropTable(
                name: "tb_nha_employee");

            migrationBuilder.DropTable(
                name: "tb_nha_office");
        }
    }
}
