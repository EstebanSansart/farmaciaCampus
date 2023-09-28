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
                    Name = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position", x => x.Id_Position);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Presentation",
                columns: table => new
                {
                    Id_Presentation = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Presentation", x => x.Id_Presentation);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    idPk = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.idPk);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "State",
                columns: table => new
                {
                    Id_State = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
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
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
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
                    Description = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
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
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
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
                    Description = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Discount = table.Column<int>(type: "int", nullable: false),
                    Need_Order = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Id_Category = table.Column<int>(type: "int", nullable: false),
                    Id_Presentation = table.Column<int>(type: "int", nullable: false),
                    Id_MedicineBrand = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicineInfo", x => x.Id_Position);
                    table.ForeignKey(
                        name: "FK_MedicineInfo_Category_Id_Category",
                        column: x => x.Id_Category,
                        principalTable: "Category",
                        principalColumn: "Id_category",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicineInfo_Medicine_brand_Id_MedicineBrand",
                        column: x => x.Id_MedicineBrand,
                        principalTable: "Medicine_brand",
                        principalColumn: "Id_Medicine_brand",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicineInfo_Presentation_Id_Presentation",
                        column: x => x.Id_Presentation,
                        principalTable: "Presentation",
                        principalColumn: "Id_Presentation",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id_Person = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Register_Date = table.Column<DateTime>(type: "datetime(6)", maxLength: 60, nullable: false),
                    Birth_Date = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Id_Type_Person = table.Column<int>(type: "int", nullable: false),
                    Id_Document_type = table.Column<int>(type: "int", nullable: false)
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
                        name: "FK_Person_Type_person_Id_Type_Person",
                        column: x => x.Id_Type_Person,
                        principalTable: "Type_person",
                        principalColumn: "Id_type_person",
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
                    Name_medicine = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Ubication = table.Column<int>(type: "int", nullable: false),
                    Total_Stock = table.Column<int>(type: "int", nullable: false),
                    Id_MedicineInfo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventory", x => x.Id_Inventory);
                    table.ForeignKey(
                        name: "FK_Inventory_MedicineInfo_Id_MedicineInfo",
                        column: x => x.Id_MedicineInfo,
                        principalTable: "MedicineInfo",
                        principalColumn: "Id_Position",
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
                    table.ForeignKey(
                        name: "FK_Contact_Person_Id_person",
                        column: x => x.Id_person,
                        principalTable: "Person",
                        principalColumn: "Id_Person",
                        onDelete: ReferentialAction.Cascade);
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
                        name: "FK_Employee_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id_Person",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employee_Position_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Position",
                        principalColumn: "Id_Position",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Eps",
                columns: table => new
                {
                    Id_Eps = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Id_type_eps = table.Column<int>(type: "int", nullable: false),
                    Id_Person = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eps", x => x.Id_Eps);
                    table.ForeignKey(
                        name: "FK_Eps_Person_Id_Person",
                        column: x => x.Id_Person,
                        principalTable: "Person",
                        principalColumn: "Id_Person",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Eps_Type_eps_Id_type_eps",
                        column: x => x.Id_type_eps,
                        principalTable: "Type_eps",
                        principalColumn: "Id_type_eps",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Provider",
                columns: table => new
                {
                    Id_Provider = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderTypeId = table.Column<int>(type: "int", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provider", x => x.Id_Provider);
                    table.ForeignKey(
                        name: "FK_Provider_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id_Person",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Provider_Type_provider_ProviderTypeId",
                        column: x => x.ProviderTypeId,
                        principalTable: "Type_provider",
                        principalColumn: "Id_type_provider",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    idPk = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AccessToken = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RefreshToken = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PersonId = table.Column<int>(type: "int", nullable: false)
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
                    table.ForeignKey(
                        name: "FK_Address_Person_Id_person",
                        column: x => x.Id_person,
                        principalTable: "Person",
                        principalColumn: "Id_Person",
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
                    Name_medicine = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id_Inventory = table.Column<int>(type: "int", nullable: false),
                    Id_state = table.Column<int>(type: "int", nullable: false)
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
                        name: "FK_Medicine_State_Id_state",
                        column: x => x.Id_state,
                        principalTable: "State",
                        principalColumn: "Id_State",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Sale",
                columns: table => new
                {
                    Id_Sale = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Sale_Date = table.Column<DateTime>(type: "Datetime", nullable: false),
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
                    table.ForeignKey(
                        name: "FK_Sale_Person_Id_person",
                        column: x => x.Id_person,
                        principalTable: "Person",
                        principalColumn: "Id_Person",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Employee_Eps",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    EpsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee_Eps", x => new { x.EpsId, x.EmployeeId });
                    table.ForeignKey(
                        name: "FK_Employee_Eps_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id_Employee",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employee_Eps_Eps_EpsId",
                        column: x => x.EpsId,
                        principalTable: "Eps",
                        principalColumn: "Id_Eps",
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
                    Employee_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buy", x => x.Id_buy);
                    table.ForeignKey(
                        name: "FK_Buy_Employee_Employee_Id",
                        column: x => x.Employee_Id,
                        principalTable: "Employee",
                        principalColumn: "Id_Employee",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Buy_Provider_Provider_Id",
                        column: x => x.Provider_Id,
                        principalTable: "Provider",
                        principalColumn: "Id_Provider",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RoleUser",
                columns: table => new
                {
                    Id_user = table.Column<int>(type: "int", nullable: false),
                    Id_role = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleUser", x => new { x.Id_user, x.Id_role });
                    table.ForeignKey(
                        name: "FK_RoleUser_Role_Id_role",
                        column: x => x.Id_role,
                        principalTable: "Role",
                        principalColumn: "idPk",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleUser_user_Id_user",
                        column: x => x.Id_user,
                        principalTable: "user",
                        principalColumn: "idPk",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Detail_Sale",
                columns: table => new
                {
                    Id_medicine = table.Column<int>(type: "int", nullable: false),
                    Id_sale = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detail_Sale", x => new { x.Id_medicine, x.Id_sale });
                    table.ForeignKey(
                        name: "FK_Detail_Sale_Medicine_Id_medicine",
                        column: x => x.Id_medicine,
                        principalTable: "Medicine",
                        principalColumn: "Id_Medicine",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Detail_Sale_Sale_Id_sale",
                        column: x => x.Id_sale,
                        principalTable: "Sale",
                        principalColumn: "Id_Sale",
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
                    Expire_Date = table.Column<DateTime>(type: "DateTime", nullable: false),
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
                name: "Detail_Buy",
                columns: table => new
                {
                    MedicineId = table.Column<int>(type: "int", nullable: false),
                    Buy_Id = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detail_Buy", x => new { x.MedicineId, x.Buy_Id });
                    table.ForeignKey(
                        name: "FK_Detail_Buy_Buy_Buy_Id",
                        column: x => x.Buy_Id,
                        principalTable: "Buy",
                        principalColumn: "Id_buy",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Detail_Buy_Medicine_MedicineId",
                        column: x => x.MedicineId,
                        principalTable: "Medicine",
                        principalColumn: "Id_Medicine",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id_category", "Name" },
                values: new object[,]
                {
                    { 1, "A" },
                    { 2, "B" },
                    { 3, "C" },
                    { 4, "D" }
                });

            migrationBuilder.InsertData(
                table: "Contact_category",
                columns: new[] { "Id_contactCategory", "Name" },
                values: new object[,]
                {
                    { 1, "Email" },
                    { 2, "Phone" },
                    { 3, "telepathic" }
                });

            migrationBuilder.InsertData(
                table: "Contact_type",
                columns: new[] { "Id_contactType", "Name" },
                values: new object[,]
                {
                    { 1, "staff" },
                    { 2, "profesional" },
                    { 3, "Provider" }
                });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id_country", "Name" },
                values: new object[] { 1, "Colombia" });

            migrationBuilder.InsertData(
                table: "Document_type",
                columns: new[] { "Id_Document_type", "Description" },
                values: new object[,]
                {
                    { 1, "CC" },
                    { 2, "TI" },
                    { 3, "NIT" }
                });

            migrationBuilder.InsertData(
                table: "Medicine_brand",
                columns: new[] { "Id_Medicine_brand", "Name" },
                values: new object[,]
                {
                    { 1, "TQ" },
                    { 2, "MK" },
                    { 3, "La Sante" },
                    { 4, "Durafex" },
                    { 5, "Ferrer" },
                    { 6, "Bayer" },
                    { 7, "Genfar" }
                });

            migrationBuilder.InsertData(
                table: "Position",
                columns: new[] { "Id_Position", "Name" },
                values: new object[,]
                {
                    { 1, "seller" },
                    { 2, "manager" },
                    { 3, "Administrator" }
                });

            migrationBuilder.InsertData(
                table: "Presentation",
                columns: new[] { "Id_Presentation", "Name" },
                values: new object[,]
                {
                    { 1, "Tableta" },
                    { 2, "Cápsula" },
                    { 3, "Jarabe" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "idPk", "Description" },
                values: new object[,]
                {
                    { 1, "Administrator" },
                    { 2, "Manager" },
                    { 3, "Employee" }
                });

            migrationBuilder.InsertData(
                table: "State",
                columns: new[] { "Id_State", "Name" },
                values: new object[,]
                {
                    { 1, "prueba" },
                    { 2, "prueba" },
                    { 3, "prueba" },
                    { 4, "prueba" },
                    { 5, "prueba" }
                });

            migrationBuilder.InsertData(
                table: "Type_person",
                columns: new[] { "Id_type_person", "Description" },
                values: new object[,]
                {
                    { 1, "Natural" },
                    { 2, "Juridica" }
                });

            migrationBuilder.InsertData(
                table: "Type_provider",
                columns: new[] { "Id_type_provider", "Name" },
                values: new object[,]
                {
                    { 1, "Drugs" },
                    { 2, "syrups" },
                    { 3, "hallucinogens" }
                });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "Id_Department", "Id_country", "Name" },
                values: new object[] { 1, 1, "Antioquia" });

            migrationBuilder.InsertData(
                table: "MedicineInfo",
                columns: new[] { "Id_Position", "Description", "Discount", "Id_Category", "Id_MedicineBrand", "Id_Presentation", "Name", "Need_Order", "Price" },
                values: new object[,]
                {
                    { 1, "Alivia el dolor leve y moderado,\nVia oral 10 comprimidos", 0, 1, 5, 1, "Paracetamol", true, 20 },
                    { 2, "30 tabletas cubiertas de 1g", 5, 1, 2, 1, "Ibuprofeno", true, 25 },
                    { 3, "104 tabletas de 100mg", 10, 1, 5, 1, "Aspirina", true, 15 },
                    { 4, "50 capsulas 500mg", 0, 1, 3, 3, "Amoxicilina", true, 40 },
                    { 5, "10 tabletas 10mg", 0, 1, 7, 1, "Cetirizina", true, 10 },
                    { 6, "30 tabletas recubiertas de 50mg via oral", 0, 1, 7, 1, "Losartan", true, 55 },
                    { 7, "30 tabletas de 850mg", 40, 1, 2, 1, "Metformina", true, 60 },
                    { 8, "30 tabletas recubiertas de 30mg", 12, 1, 3, 1, "Atorvastatina", true, 45 },
                    { 9, "30 tabletas recubiertas de 2mg", 0, 1, 1, 1, "Clonazepam", true, 35 },
                    { 10, "5 mg / 5ml jarabe de 100ml", 0, 2, 7, 2, "Loratadina", true, 22 }
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id_Person", "Birth_Date", "Id_Document_type", "Id_Type_Person", "Name", "Register_Date" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 27, 22, 38, 15, 296, DateTimeKind.Local).AddTicks(6389), 3, 1, "root", new DateTime(2023, 9, 27, 22, 38, 15, 296, DateTimeKind.Local).AddTicks(6377) },
                    { 2, new DateTime(2023, 9, 27, 22, 38, 15, 296, DateTimeKind.Local).AddTicks(6390), 3, 2, "ProveedorA", new DateTime(2023, 9, 27, 22, 38, 15, 296, DateTimeKind.Local).AddTicks(6390) },
                    { 3, new DateTime(2023, 9, 27, 22, 38, 15, 296, DateTimeKind.Local).AddTicks(6391), 3, 2, "ProveedorB", new DateTime(2023, 9, 27, 22, 38, 15, 296, DateTimeKind.Local).AddTicks(6391) },
                    { 4, new DateTime(2023, 9, 27, 22, 38, 15, 296, DateTimeKind.Local).AddTicks(6393), 3, 2, "ProveedorC", new DateTime(2023, 9, 27, 22, 38, 15, 296, DateTimeKind.Local).AddTicks(6392) },
                    { 5, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "Juan Paco", new DateTime(2023, 9, 27, 22, 38, 15, 296, DateTimeKind.Local).AddTicks(6393) },
                    { 6, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "Pedro De La Mar", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, new DateTime(2014, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, "Maria Db", new DateTime(2023, 9, 27, 22, 38, 15, 296, DateTimeKind.Local).AddTicks(6400) },
                    { 8, new DateTime(1929, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "Ana frank", new DateTime(2019, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, new DateTime(1978, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "Luis Fonsi", new DateTime(2018, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, new DateTime(1957, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "Sena Sofia", new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, new DateTime(1987, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "Elena de avalord", new DateTime(2001, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id_city", "Id_department", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Medellin" },
                    { 2, 1, "Apartado" },
                    { 3, 1, "Arboletes" },
                    { 4, 1, "Rio negro" }
                });

            migrationBuilder.InsertData(
                table: "Contact",
                columns: new[] { "Id_contact", "Description", "Id_contact_category", "Id_contact_type", "Id_person" },
                values: new object[,]
                {
                    { 1, "contacto@proveedor_A.com", 1, 2, 2 },
                    { 2, "contacto@proveedor_B.com", 1, 2, 3 },
                    { 3, "contacto@proveedor_C.com", 1, 2, 4 }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id_Employee", "PersonId", "PositionId" },
                values: new object[,]
                {
                    { 1, 6, 1 },
                    { 2, 8, 1 },
                    { 3, 9, 2 },
                    { 4, 10, 3 }
                });

            migrationBuilder.InsertData(
                table: "Inventory",
                columns: new[] { "Id_Inventory", "Id_MedicineInfo", "Name_medicine", "Total_Stock", "Ubication" },
                values: new object[,]
                {
                    { 1, 1, null, 5, 4 },
                    { 2, 2, null, 6, 4 },
                    { 3, 3, null, 9, 4 },
                    { 4, 4, null, 6, 4 },
                    { 5, 5, null, 3, 4 },
                    { 6, 6, null, 4, 4 },
                    { 7, 7, null, 7, 4 },
                    { 8, 8, null, 8, 4 },
                    { 9, 9, null, 2, 4 },
                    { 10, 10, null, 4, 4 }
                });

            migrationBuilder.InsertData(
                table: "Provider",
                columns: new[] { "Id_Provider", "Name", "PersonId", "ProviderTypeId" },
                values: new object[,]
                {
                    { 1, "melissa", 2, 1 },
                    { 2, "benito", 3, 2 },
                    { 3, "MQ society", 4, 3 }
                });

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "idPk", "AccessToken", "Email", "Password", "PersonId", "RefreshToken", "Username" },
                values: new object[] { 1, null, null, "root", 1, null, "root" });

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
                name: "IX_Detail_Buy_Buy_Id",
                table: "Detail_Buy",
                column: "Buy_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Detail_Sale_Id_sale",
                table: "Detail_Sale",
                column: "Id_sale");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_PersonId",
                table: "Employee",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_PositionId",
                table: "Employee",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Eps_EmployeeId",
                table: "Employee_Eps",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Eps_Id_Person",
                table: "Eps",
                column: "Id_Person");

            migrationBuilder.CreateIndex(
                name: "IX_Eps_Id_type_eps",
                table: "Eps",
                column: "Id_type_eps");

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_Id_MedicineInfo",
                table: "Inventory",
                column: "Id_MedicineInfo");

            migrationBuilder.CreateIndex(
                name: "IX_Medicine_Id_Inventory",
                table: "Medicine",
                column: "Id_Inventory");

            migrationBuilder.CreateIndex(
                name: "IX_Medicine_Id_state",
                table: "Medicine",
                column: "Id_state");

            migrationBuilder.CreateIndex(
                name: "IX_MedicineInfo_Id_Category",
                table: "MedicineInfo",
                column: "Id_Category");

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
                name: "IX_Person_Id_Type_Person",
                table: "Person",
                column: "Id_Type_Person");

            migrationBuilder.CreateIndex(
                name: "IX_Provider_PersonId",
                table: "Provider",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Provider_ProviderTypeId",
                table: "Provider",
                column: "ProviderTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleUser_Id_role",
                table: "RoleUser",
                column: "Id_role");

            migrationBuilder.CreateIndex(
                name: "IX_Sale_Id_Employe",
                table: "Sale",
                column: "Id_Employe");

            migrationBuilder.CreateIndex(
                name: "IX_Sale_Id_person",
                table: "Sale",
                column: "Id_person");

            migrationBuilder.CreateIndex(
                name: "IX_user_PersonId",
                table: "user",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Username_Email",
                table: "user",
                columns: new[] { "Username", "Email" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "Detail_Buy");

            migrationBuilder.DropTable(
                name: "Detail_Sale");

            migrationBuilder.DropTable(
                name: "Employee_Eps");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "RoleUser");

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
                name: "Eps");

            migrationBuilder.DropTable(
                name: "Sale");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "user");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "Provider");

            migrationBuilder.DropTable(
                name: "Inventory");

            migrationBuilder.DropTable(
                name: "State");

            migrationBuilder.DropTable(
                name: "Type_eps");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "Type_provider");

            migrationBuilder.DropTable(
                name: "MedicineInfo");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "Position");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Medicine_brand");

            migrationBuilder.DropTable(
                name: "Presentation");

            migrationBuilder.DropTable(
                name: "Document_type");

            migrationBuilder.DropTable(
                name: "Type_person");
        }
    }
}
