using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id_category = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id_category);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Contact_category",
                columns: table => new
                {
                    Id_contactCategory = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact_category", x => x.Id_contactCategory);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Contact_type",
                columns: table => new
                {
                    Id_contactType = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact_type", x => x.Id_contactType);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id_country = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id_country);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Document_type",
                columns: table => new
                {
                    Id_Document_type = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document_type", x => x.Id_Document_type);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Medicine_brand",
                columns: table => new
                {
                    Id_Medicine_brand = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicine_brand", x => x.Id_Medicine_brand);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Position",
                columns: table => new
                {
                    Id_Position = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position", x => x.Id_Position);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Presentations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Presentations", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "rol",
                columns: table => new
                {
                    idPk = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    descriptionRole = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rol", x => x.idPk);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "State",
                columns: table => new
                {
                    Id_State = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name_state = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_State", x => x.Id_State);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Type_eps",
                columns: table => new
                {
                    Id_type_eps = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    epstypename = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Type_eps", x => x.Id_type_eps);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Type_person",
                columns: table => new
                {
                    Id_type_person = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    description = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Type_person", x => x.Id_type_person);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Type_provider",
                columns: table => new
                {
                    Id_type_provider = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Providertypename = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Type_provider", x => x.Id_type_provider);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    Id_Department = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id_country = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Id_Department);
                    table.ForeignKey(
                        name: "FK_Department_Country_Id_country",
                        column: x => x.Id_country,
                        principalTable: "Country",
                        principalColumn: "Id_country",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MedicineInfo",
                columns: table => new
                {
                    Id_Position = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Discount = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Need_order = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Id_medicine_name = table.Column<int>(type: "int", nullable: false),
                    Id_Category = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    Id_Presentation = table.Column<int>(type: "int", nullable: false),
                    Id_MedicineBrand = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicineInfo", x => x.Id_Position);
                    table.ForeignKey(
                        name: "FK_MedicineInfo_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id_category");
                    table.ForeignKey(
                        name: "FK_MedicineInfo_Medicine_brand_Id_MedicineBrand",
                        column: x => x.Id_MedicineBrand,
                        principalTable: "Medicine_brand",
                        principalColumn: "Id_Medicine_brand",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicineInfo_Presentations_Id_Presentation",
                        column: x => x.Id_Presentation,
                        principalTable: "Presentations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Eps",
                columns: table => new
                {
                    Id_Eps = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Id_type_eps = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eps", x => x.Id_Eps);
                    table.ForeignKey(
                        name: "FK_Eps_Type_eps_Id_type_eps",
                        column: x => x.Id_type_eps,
                        principalTable: "Type_eps",
                        principalColumn: "Id_type_eps",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id_city = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id_department = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id_city);
                    table.ForeignKey(
                        name: "FK_City_Department_Id_department",
                        column: x => x.Id_department,
                        principalTable: "Department",
                        principalColumn: "Id_Department",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Inventory",
                columns: table => new
                {
                    Id_Inventory = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Ubication = table.Column<int>(type: "int", nullable: false),
                    Stock_total = table.Column<int>(type: "int", nullable: false),
                    Id_medicine_info = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventory", x => x.Id_Inventory);
                    table.ForeignKey(
                        name: "FK_Inventory_MedicineInfo_Id_medicine_info",
                        column: x => x.Id_medicine_info,
                        principalTable: "MedicineInfo",
                        principalColumn: "Id_Position",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Medicine",
                columns: table => new
                {
                    Id_Medicine = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Date_creation = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Date_expiration = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Id_Date_expiration = table.Column<int>(type: "int", nullable: false),
                    Id_medicine_info = table.Column<int>(type: "int", nullable: false),
                    Medicine_InfoId = table.Column<int>(type: "int", nullable: true),
                    Id_Inventory = table.Column<int>(type: "int", nullable: false),
                    Id_estate = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicine", x => x.Id_Medicine);
                    table.ForeignKey(
                        name: "FK_Medicine_Inventory_Id_Inventory",
                        column: x => x.Id_Inventory,
                        principalTable: "Inventory",
                        principalColumn: "Id_Inventory",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Medicine_MedicineInfo_Medicine_InfoId",
                        column: x => x.Medicine_InfoId,
                        principalTable: "MedicineInfo",
                        principalColumn: "Id_Position");
                    table.ForeignKey(
                        name: "FK_Medicine_State_Id_estate",
                        column: x => x.Id_estate,
                        principalTable: "State",
                        principalColumn: "Id_State",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id_Address = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id_City = table.Column<int>(type: "int", nullable: false),
                    Id_person = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id_Address);
                    table.ForeignKey(
                        name: "FK_Address_City_Id_City",
                        column: x => x.Id_City,
                        principalTable: "City",
                        principalColumn: "Id_city",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Buy",
                columns: table => new
                {
                    Id_buy = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Buy_date = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Provider_Id = table.Column<int>(type: "int", nullable: false),
                    Employee_Id = table.Column<int>(type: "int", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buy", x => x.Id_buy);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Detail_Buys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MedicineId = table.Column<int>(type: "int", nullable: false),
                    Buy_Id = table.Column<int>(type: "int", nullable: false),
                    BuyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detail_Buys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Detail_Buys_Buy_BuyId",
                        column: x => x.BuyId,
                        principalTable: "Buy",
                        principalColumn: "Id_buy");
                    table.ForeignKey(
                        name: "FK_Detail_Buys_Medicine_MedicineId",
                        column: x => x.MedicineId,
                        principalTable: "Medicine",
                        principalColumn: "Id_Medicine",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    Id_contact = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id_person = table.Column<int>(type: "int", nullable: false),
                    Id_contact_type = table.Column<int>(type: "int", nullable: false),
                    Id_contact_category = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.Id_contact);
                    table.ForeignKey(
                        name: "FK_Contact_Contact_category_Id_contact_category",
                        column: x => x.Id_contact_category,
                        principalTable: "Contact_category",
                        principalColumn: "Id_contactCategory",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contact_Contact_type_Id_contact_type",
                        column: x => x.Id_contact_type,
                        principalTable: "Contact_type",
                        principalColumn: "Id_contactType",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Detail_Sales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Id_medicine = table.Column<int>(type: "int", nullable: false),
                    MedicineId = table.Column<int>(type: "int", nullable: true),
                    Id_sale = table.Column<int>(type: "int", nullable: false),
                    SaleId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detail_Sales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Detail_Sales_Medicine_MedicineId",
                        column: x => x.MedicineId,
                        principalTable: "Medicine",
                        principalColumn: "Id_Medicine");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id_Employee = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    PositionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id_Employee);
                    table.ForeignKey(
                        name: "FK_Employee_Position_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Position",
                        principalColumn: "Id_Position",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "employee_eps",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    EpsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employee_eps", x => new { x.EpsId, x.EmployeeId });
                    table.ForeignKey(
                        name: "FK_employee_eps_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id_Employee",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_employee_eps_Eps_EpsId",
                        column: x => x.EpsId,
                        principalTable: "Eps",
                        principalColumn: "Id_Eps",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Sale",
                columns: table => new
                {
                    Id_Sale = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Fecha_venta = table.Column<DateTime>(type: "Datetime", nullable: false),
                    Id_person = table.Column<int>(type: "int", nullable: false),
                    Id_Employe = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sale", x => x.Id_Sale);
                    table.ForeignKey(
                        name: "FK_Sale_Employee_Id_Employe",
                        column: x => x.Id_Employe,
                        principalTable: "Employee",
                        principalColumn: "Id_Employee",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id_Order = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Order_Date = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Detail = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Date_expiration = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Id_sale = table.Column<int>(type: "int", nullable: false),
                    EpsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id_Order);
                    table.ForeignKey(
                        name: "FK_Order_Eps_EpsId",
                        column: x => x.EpsId,
                        principalTable: "Eps",
                        principalColumn: "Id_Eps",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_Sale_Id_sale",
                        column: x => x.Id_sale,
                        principalTable: "Sale",
                        principalColumn: "Id_Sale",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id_Person = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Register_date = table.Column<DateTime>(type: "datetime(6)", maxLength: 60, nullable: false),
                    Birth_date = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Id_Employe = table.Column<int>(type: "int", nullable: false),
                    Id_Type_Person = table.Column<int>(type: "int", nullable: false),
                    Type_PersonId = table.Column<int>(type: "int", nullable: true),
                    Id_Document_type = table.Column<int>(type: "int", nullable: false),
                    Id_Sale = table.Column<int>(type: "int", nullable: false),
                    SaleId = table.Column<int>(type: "int", nullable: true),
                    Id_Eps = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id_Person);
                    table.ForeignKey(
                        name: "FK_Person_Document_type_Id_Document_type",
                        column: x => x.Id_Document_type,
                        principalTable: "Document_type",
                        principalColumn: "Id_Document_type",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Person_Eps_Id_Eps",
                        column: x => x.Id_Eps,
                        principalTable: "Eps",
                        principalColumn: "Id_Eps",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Person_Sale_SaleId",
                        column: x => x.SaleId,
                        principalTable: "Sale",
                        principalColumn: "Id_Sale");
                    table.ForeignKey(
                        name: "FK_Person_Type_person_Type_PersonId",
                        column: x => x.Type_PersonId,
                        principalTable: "Type_person",
                        principalColumn: "Id_type_person");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Providers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProviderTypeId = table.Column<int>(type: "int", nullable: false),
                    Type_ProviderId = table.Column<int>(type: "int", nullable: true),
                    PersonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Providers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Providers_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id_Person",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Providers_Type_provider_Type_ProviderId",
                        column: x => x.Type_ProviderId,
                        principalTable: "Type_provider",
                        principalColumn: "Id_type_provider");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    idPk = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    usernameUser = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    passwordUser = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    emailUser = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    accessTokenUser = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    refreshTokenUser = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    PersonId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.idPk);
                    table.ForeignKey(
                        name: "FK_user_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id_Person",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_user_Person_PersonId1",
                        column: x => x.PersonId1,
                        principalTable: "Person",
                        principalColumn: "Id_Person");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Role_user",
                columns: table => new
                {
                    Id_user = table.Column<int>(type: "int", nullable: false),
                    Id_role = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role_user", x => new { x.Id_user, x.Id_role });
                    table.ForeignKey(
                        name: "FK_Role_user_rol_Id_role",
                        column: x => x.Id_role,
                        principalTable: "rol",
                        principalColumn: "idPk",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Role_user_user_Id_user",
                        column: x => x.Id_user,
                        principalTable: "user",
                        principalColumn: "idPk",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "rol",
                columns: new[] { "idPk", "descriptionRole" },
                values: new object[,]
                {
                    { 1, "Administrator" },
                    { 2, "Manager" },
                    { 3, "Employee" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Address_Id_City",
                table: "Address",
                column: "Id_City");

            migrationBuilder.CreateIndex(
                name: "IX_Address_Id_person",
                table: "Address",
                column: "Id_person");

            migrationBuilder.CreateIndex(
                name: "IX_Buy_Employee_Id",
                table: "Buy",
                column: "Employee_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Buy_PersonId",
                table: "Buy",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Buy_Provider_Id",
                table: "Buy",
                column: "Provider_Id");

            migrationBuilder.CreateIndex(
                name: "IX_City_Id_department",
                table: "City",
                column: "Id_department");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_Id_contact_category",
                table: "Contact",
                column: "Id_contact_category");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_Id_contact_type",
                table: "Contact",
                column: "Id_contact_type");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_Id_person",
                table: "Contact",
                column: "Id_person");

            migrationBuilder.CreateIndex(
                name: "IX_Department_Id_country",
                table: "Department",
                column: "Id_country");

            migrationBuilder.CreateIndex(
                name: "IX_Detail_Buys_BuyId",
                table: "Detail_Buys",
                column: "BuyId");

            migrationBuilder.CreateIndex(
                name: "IX_Detail_Buys_MedicineId",
                table: "Detail_Buys",
                column: "MedicineId");

            migrationBuilder.CreateIndex(
                name: "IX_Detail_Sales_MedicineId",
                table: "Detail_Sales",
                column: "MedicineId");

            migrationBuilder.CreateIndex(
                name: "IX_Detail_Sales_SaleId",
                table: "Detail_Sales",
                column: "SaleId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_PersonId",
                table: "Employee",
                column: "PersonId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employee_PositionId",
                table: "Employee",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_employee_eps_EmployeeId",
                table: "employee_eps",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Eps_Id_type_eps",
                table: "Eps",
                column: "Id_type_eps");

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_Id_medicine_info",
                table: "Inventory",
                column: "Id_medicine_info");

            migrationBuilder.CreateIndex(
                name: "IX_Medicine_Id_estate",
                table: "Medicine",
                column: "Id_estate");

            migrationBuilder.CreateIndex(
                name: "IX_Medicine_Id_Inventory",
                table: "Medicine",
                column: "Id_Inventory");

            migrationBuilder.CreateIndex(
                name: "IX_Medicine_Medicine_InfoId",
                table: "Medicine",
                column: "Medicine_InfoId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicineInfo_CategoryId",
                table: "MedicineInfo",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicineInfo_Id_MedicineBrand",
                table: "MedicineInfo",
                column: "Id_MedicineBrand");

            migrationBuilder.CreateIndex(
                name: "IX_MedicineInfo_Id_Presentation",
                table: "MedicineInfo",
                column: "Id_Presentation");

            migrationBuilder.CreateIndex(
                name: "IX_Order_EpsId",
                table: "Order",
                column: "EpsId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_Id_sale",
                table: "Order",
                column: "Id_sale");

            migrationBuilder.CreateIndex(
                name: "IX_Person_Id_Document_type",
                table: "Person",
                column: "Id_Document_type");

            migrationBuilder.CreateIndex(
                name: "IX_Person_Id_Eps",
                table: "Person",
                column: "Id_Eps");

            migrationBuilder.CreateIndex(
                name: "IX_Person_SaleId",
                table: "Person",
                column: "SaleId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_Type_PersonId",
                table: "Person",
                column: "Type_PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Providers_PersonId",
                table: "Providers",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Providers_Type_ProviderId",
                table: "Providers",
                column: "Type_ProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_Role_user_Id_role",
                table: "Role_user",
                column: "Id_role");

            migrationBuilder.CreateIndex(
                name: "IX_Sale_Id_Employe",
                table: "Sale",
                column: "Id_Employe");

            migrationBuilder.CreateIndex(
                name: "IX_user_PersonId",
                table: "user",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_user_PersonId1",
                table: "user",
                column: "PersonId1",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Username_Email",
                table: "user",
                columns: new[] { "usernameUser", "emailUser" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Person_Id_person",
                table: "Address",
                column: "Id_person",
                principalTable: "Person",
                principalColumn: "Id_Person",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Buy_Employee_Employee_Id",
                table: "Buy",
                column: "Employee_Id",
                principalTable: "Employee",
                principalColumn: "Id_Employee",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Buy_Person_PersonId",
                table: "Buy",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "Id_Person");

            migrationBuilder.AddForeignKey(
                name: "FK_Buy_Providers_Provider_Id",
                table: "Buy",
                column: "Provider_Id",
                principalTable: "Providers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_Person_Id_person",
                table: "Contact",
                column: "Id_person",
                principalTable: "Person",
                principalColumn: "Id_Person",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Detail_Sales_Sale_SaleId",
                table: "Detail_Sales",
                column: "SaleId",
                principalTable: "Sale",
                principalColumn: "Id_Sale");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Person_PersonId",
                table: "Employee",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "Id_Person",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Person_PersonId",
                table: "Employee");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "Detail_Buys");

            migrationBuilder.DropTable(
                name: "Detail_Sales");

            migrationBuilder.DropTable(
                name: "employee_eps");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Role_user");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Contact_category");

            migrationBuilder.DropTable(
                name: "Contact_type");

            migrationBuilder.DropTable(
                name: "Buy");

            migrationBuilder.DropTable(
                name: "Medicine");

            migrationBuilder.DropTable(
                name: "rol");

            migrationBuilder.DropTable(
                name: "user");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "Providers");

            migrationBuilder.DropTable(
                name: "Inventory");

            migrationBuilder.DropTable(
                name: "State");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "Type_provider");

            migrationBuilder.DropTable(
                name: "MedicineInfo");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Medicine_brand");

            migrationBuilder.DropTable(
                name: "Presentations");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "Document_type");

            migrationBuilder.DropTable(
                name: "Eps");

            migrationBuilder.DropTable(
                name: "Sale");

            migrationBuilder.DropTable(
                name: "Type_person");

            migrationBuilder.DropTable(
                name: "Type_eps");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Position");
        }
    }
}
