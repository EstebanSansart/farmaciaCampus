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
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
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
                columns: new[] { "Id_State", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "default", "prueba" },
                    { 2, "expired", "prueba" },
                    { 3, "damaged", "prueba" },
                    { 4, "Sold", "prueba" },
                    { 5, "Returned", "prueba" }
                });

            migrationBuilder.InsertData(
                table: "Type_eps",
                columns: new[] { "Id_type_eps", "Name" },
                values: new object[,]
                {
                    { 1, "Salud Total" },
                    { 2, "Sura" }
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
                    { 1, new DateTime(2023, 9, 29, 6, 27, 48, 62, DateTimeKind.Local).AddTicks(100), 3, 1, "root", new DateTime(2023, 9, 29, 6, 27, 48, 62, DateTimeKind.Local).AddTicks(83) },
                    { 2, new DateTime(2023, 9, 29, 6, 27, 48, 62, DateTimeKind.Local).AddTicks(102), 3, 2, "ProveedorA", new DateTime(2023, 9, 29, 6, 27, 48, 62, DateTimeKind.Local).AddTicks(101) },
                    { 3, new DateTime(2023, 9, 29, 6, 27, 48, 62, DateTimeKind.Local).AddTicks(103), 3, 2, "ProveedorB", new DateTime(2023, 9, 29, 6, 27, 48, 62, DateTimeKind.Local).AddTicks(103) },
                    { 4, new DateTime(2023, 9, 29, 6, 27, 48, 62, DateTimeKind.Local).AddTicks(104), 3, 2, "ProveedorC", new DateTime(2023, 9, 29, 6, 27, 48, 62, DateTimeKind.Local).AddTicks(104) },
                    { 5, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "Juan Paco", new DateTime(2023, 9, 29, 6, 27, 48, 62, DateTimeKind.Local).AddTicks(105) },
                    { 6, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "Pedro De La Mar", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, new DateTime(2014, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, "Maria Db", new DateTime(2023, 9, 29, 6, 27, 48, 62, DateTimeKind.Local).AddTicks(115) },
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
                table: "Eps",
                columns: new[] { "Id_Eps", "Id_Person", "Id_type_eps" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 }
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

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id_Address", "Description", "Id_City", "Id_person" },
                values: new object[,]
                {
                    { 1, "Bello comuna 13", 1, 1 },
                    { 2, "Caldas comuna 80", 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Buy",
                columns: new[] { "Id_buy", "Buy_date", "Employee_Id", "Provider_Id" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1 },
                    { 2, new DateTime(2023, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 3, new DateTime(2023, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1 },
                    { 4, new DateTime(2023, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 5, new DateTime(2023, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2 },
                    { 6, new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 7, new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2 },
                    { 8, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 9, new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1 },
                    { 10, new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1 },
                    { 11, new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2 },
                    { 12, new DateTime(2023, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2 },
                    { 13, new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2 },
                    { 14, new DateTime(2023, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2 },
                    { 15, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2 },
                    { 16, new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2 }
                });

            migrationBuilder.InsertData(
                table: "Medicine",
                columns: new[] { "Id_Medicine", "Date_creation", "Date_expiration", "Id_Inventory", "Id_state", "Name_medicine" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 4, null },
                    { 2, new DateTime(2023, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 3, null },
                    { 3, new DateTime(2023, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 3, null },
                    { 4, new DateTime(2023, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 4, null },
                    { 5, new DateTime(2023, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 2, null },
                    { 6, new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 2, null },
                    { 7, new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 2, null },
                    { 8, new DateTime(2023, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 2, null },
                    { 9, new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 3, null },
                    { 10, new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 4, null },
                    { 11, new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 3, null },
                    { 12, new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 3, null },
                    { 13, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 2, null },
                    { 14, new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, null },
                    { 15, new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 1, null },
                    { 16, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 4, null },
                    { 17, new DateTime(2023, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 3, null },
                    { 18, new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 1, null },
                    { 19, new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, null },
                    { 20, new DateTime(2023, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 1, null },
                    { 21, new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, null },
                    { 22, new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 1, null },
                    { 23, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 1, null },
                    { 24, new DateTime(2023, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 2, null },
                    { 25, new DateTime(2023, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2, null },
                    { 26, new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, null },
                    { 27, new DateTime(2024, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 2, null },
                    { 28, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 3, null },
                    { 29, new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 2, null },
                    { 30, new DateTime(2023, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, null },
                    { 31, new DateTime(2023, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, null },
                    { 32, new DateTime(2023, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 2, null },
                    { 33, new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 3, null },
                    { 34, new DateTime(2023, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 2, null },
                    { 35, new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 2, null },
                    { 36, new DateTime(2023, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 2, null },
                    { 37, new DateTime(2023, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, null },
                    { 38, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 2, null },
                    { 39, new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 1, null },
                    { 40, new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 3, null },
                    { 41, new DateTime(2023, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 1, null },
                    { 42, new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 3, null },
                    { 43, new DateTime(2023, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 2, null },
                    { 44, new DateTime(2023, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 3, null },
                    { 45, new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 4, null },
                    { 46, new DateTime(2023, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 3, null },
                    { 47, new DateTime(2023, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3, null },
                    { 48, new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 1, null },
                    { 49, new DateTime(2023, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 4, null },
                    { 50, new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3, null },
                    { 51, new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 3, null },
                    { 52, new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 3, null },
                    { 53, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3, null },
                    { 54, new DateTime(2023, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, null },
                    { 55, new DateTime(2023, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 2, null },
                    { 56, new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 4, null },
                    { 57, new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3, null },
                    { 58, new DateTime(2023, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 2, null },
                    { 59, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, null },
                    { 60, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3, null },
                    { 61, new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3, null },
                    { 62, new DateTime(2023, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, null },
                    { 63, new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 4, null },
                    { 64, new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3, null },
                    { 65, new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 1, null },
                    { 66, new DateTime(2023, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 2, null },
                    { 67, new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3, null },
                    { 68, new DateTime(2023, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 1, null },
                    { 69, new DateTime(2023, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 4, null },
                    { 70, new DateTime(2023, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 1, null },
                    { 71, new DateTime(2023, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, null },
                    { 72, new DateTime(2023, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2, null },
                    { 73, new DateTime(2023, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, null },
                    { 74, new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 4, null },
                    { 75, new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 4, null },
                    { 76, new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3, null },
                    { 77, new DateTime(2023, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 4, null },
                    { 78, new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 3, null },
                    { 79, new DateTime(2023, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 4, null },
                    { 80, new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 2, null },
                    { 81, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 4, null },
                    { 82, new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 2, null },
                    { 83, new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 2, null },
                    { 84, new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 3, null },
                    { 85, new DateTime(2023, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 3, null },
                    { 86, new DateTime(2023, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, null },
                    { 87, new DateTime(2023, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, null },
                    { 88, new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3, null },
                    { 89, new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 3, null },
                    { 90, new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 4, null },
                    { 91, new DateTime(2023, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, null },
                    { 92, new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 3, null },
                    { 93, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 2, null },
                    { 94, new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 2, null },
                    { 95, new DateTime(2024, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2, null },
                    { 96, new DateTime(2023, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 3, null },
                    { 97, new DateTime(2023, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 4, null },
                    { 98, new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3, null },
                    { 99, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 3, null },
                    { 100, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 3, null },
                    { 101, new DateTime(2023, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 4, null },
                    { 102, new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 4, null },
                    { 103, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 1, null },
                    { 104, new DateTime(2023, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3, null },
                    { 105, new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 3, null },
                    { 106, new DateTime(2023, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 2, null },
                    { 107, new DateTime(2023, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 1, null },
                    { 108, new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 4, null },
                    { 109, new DateTime(2023, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 4, null },
                    { 110, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 3, null },
                    { 111, new DateTime(2023, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 1, null },
                    { 112, new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 1, null },
                    { 113, new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 3, null },
                    { 114, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 4, null },
                    { 115, new DateTime(2023, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 1, null },
                    { 116, new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3, null },
                    { 117, new DateTime(2023, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 4, null },
                    { 118, new DateTime(2023, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, null },
                    { 119, new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, null },
                    { 120, new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, null },
                    { 121, new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, null },
                    { 122, new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 1, null },
                    { 123, new DateTime(2023, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 2, null },
                    { 124, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 2, null },
                    { 125, new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 1, null },
                    { 126, new DateTime(2023, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, null },
                    { 127, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 4, null },
                    { 128, new DateTime(2023, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 4, null },
                    { 129, new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 4, null },
                    { 130, new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3, null },
                    { 131, new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 3, null },
                    { 132, new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, null },
                    { 133, new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 4, null },
                    { 134, new DateTime(2023, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 4, null },
                    { 135, new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 1, null },
                    { 136, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 4, null },
                    { 137, new DateTime(2023, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 2, null },
                    { 138, new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 4, null },
                    { 139, new DateTime(2023, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 1, null },
                    { 140, new DateTime(2023, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 4, null },
                    { 141, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3, null },
                    { 142, new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 4, null },
                    { 143, new DateTime(2023, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 1, null },
                    { 144, new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, null },
                    { 145, new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 4, null },
                    { 146, new DateTime(2023, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 4, null },
                    { 147, new DateTime(2023, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 3, null },
                    { 148, new DateTime(2023, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 4, null },
                    { 149, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, null },
                    { 150, new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3, null },
                    { 151, new DateTime(2023, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 3, null },
                    { 152, new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 1, null },
                    { 153, new DateTime(2023, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 1, null },
                    { 154, new DateTime(2023, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 3, null },
                    { 155, new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3, null },
                    { 156, new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 3, null },
                    { 157, new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 4, null },
                    { 158, new DateTime(2023, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 2, null },
                    { 159, new DateTime(2023, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 3, null },
                    { 160, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 1, null },
                    { 161, new DateTime(2023, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 3, null },
                    { 162, new DateTime(2023, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 4, null },
                    { 163, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3, null },
                    { 164, new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 4, null },
                    { 165, new DateTime(2023, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 3, null },
                    { 166, new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, null },
                    { 167, new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 4, null },
                    { 168, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 2, null },
                    { 169, new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 4, null },
                    { 170, new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 4, null },
                    { 171, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3, null },
                    { 172, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, null },
                    { 173, new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, null },
                    { 174, new DateTime(2023, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 3, null },
                    { 175, new DateTime(2023, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 4, null },
                    { 176, new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3, null },
                    { 177, new DateTime(2023, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 4, null },
                    { 178, new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 1, null },
                    { 179, new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3, null },
                    { 180, new DateTime(2023, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 4, null },
                    { 181, new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 2, null },
                    { 182, new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, null },
                    { 183, new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 4, null },
                    { 184, new DateTime(2023, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 3, null },
                    { 185, new DateTime(2023, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, null },
                    { 186, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 2, null },
                    { 187, new DateTime(2023, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 4, null },
                    { 188, new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 4, null },
                    { 189, new DateTime(2023, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3, null },
                    { 190, new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 2, null },
                    { 191, new DateTime(2023, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 1, null },
                    { 192, new DateTime(2023, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, null },
                    { 193, new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 1, null },
                    { 194, new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 2, null },
                    { 195, new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 1, null },
                    { 196, new DateTime(2023, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 4, null },
                    { 197, new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, null },
                    { 198, new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3, null },
                    { 199, new DateTime(2023, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 2, null },
                    { 200, new DateTime(2023, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2, null }
                });

            migrationBuilder.InsertData(
                table: "Sale",
                columns: new[] { "Id_Sale", "Id_Employe", "Id_person", "Sale_Date" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 3, 2, new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 2, 3, new DateTime(2023, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 1, 3, new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 1, 1, new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 3, 2, new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 2, 2, new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 1, 3, new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 1, 1, new DateTime(2023, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 2, 3, new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 1, 1, new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 3, 1, new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 2, 3, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 3, 2, new DateTime(2023, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, 3, 3, new DateTime(2023, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, 1, 1, new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Detail_Buy",
                columns: new[] { "Buy_Id", "MedicineId", "Id" },
                values: new object[,]
                {
                    { 5, 101, 0 },
                    { 10, 102, 0 },
                    { 13, 103, 0 },
                    { 13, 104, 0 },
                    { 4, 105, 0 },
                    { 2, 106, 0 },
                    { 13, 107, 0 },
                    { 8, 108, 0 },
                    { 4, 109, 0 },
                    { 14, 110, 0 },
                    { 15, 111, 0 },
                    { 3, 112, 0 },
                    { 1, 113, 0 },
                    { 11, 114, 0 },
                    { 11, 115, 0 },
                    { 2, 116, 0 },
                    { 15, 117, 0 },
                    { 7, 118, 0 },
                    { 5, 119, 0 },
                    { 6, 120, 0 },
                    { 12, 121, 0 },
                    { 13, 122, 0 },
                    { 7, 123, 0 },
                    { 11, 124, 0 },
                    { 2, 125, 0 },
                    { 7, 126, 0 },
                    { 2, 127, 0 },
                    { 11, 128, 0 },
                    { 1, 129, 0 },
                    { 7, 130, 0 },
                    { 11, 131, 0 },
                    { 10, 132, 0 },
                    { 12, 133, 0 },
                    { 6, 134, 0 },
                    { 12, 135, 0 },
                    { 15, 136, 0 },
                    { 4, 137, 0 },
                    { 10, 138, 0 },
                    { 7, 139, 0 },
                    { 4, 140, 0 },
                    { 10, 141, 0 },
                    { 10, 142, 0 },
                    { 5, 143, 0 },
                    { 14, 144, 0 },
                    { 11, 145, 0 },
                    { 10, 146, 0 },
                    { 3, 147, 0 },
                    { 2, 148, 0 },
                    { 8, 149, 0 },
                    { 2, 150, 0 },
                    { 9, 151, 0 },
                    { 6, 152, 0 },
                    { 1, 153, 0 },
                    { 12, 154, 0 },
                    { 5, 155, 0 },
                    { 11, 156, 0 },
                    { 11, 157, 0 },
                    { 10, 158, 0 },
                    { 12, 159, 0 },
                    { 14, 160, 0 },
                    { 8, 161, 0 },
                    { 9, 162, 0 },
                    { 12, 163, 0 },
                    { 4, 164, 0 },
                    { 14, 165, 0 },
                    { 1, 166, 0 },
                    { 7, 167, 0 },
                    { 15, 168, 0 },
                    { 2, 169, 0 },
                    { 5, 170, 0 },
                    { 2, 171, 0 },
                    { 11, 172, 0 },
                    { 8, 173, 0 },
                    { 12, 174, 0 },
                    { 13, 175, 0 },
                    { 1, 176, 0 },
                    { 10, 177, 0 },
                    { 2, 178, 0 },
                    { 7, 179, 0 },
                    { 7, 180, 0 },
                    { 11, 181, 0 },
                    { 9, 182, 0 },
                    { 8, 183, 0 },
                    { 6, 184, 0 },
                    { 7, 185, 0 },
                    { 15, 186, 0 },
                    { 13, 187, 0 },
                    { 14, 188, 0 },
                    { 15, 189, 0 },
                    { 13, 190, 0 },
                    { 13, 191, 0 },
                    { 10, 192, 0 },
                    { 8, 193, 0 },
                    { 11, 194, 0 },
                    { 2, 195, 0 },
                    { 8, 196, 0 },
                    { 8, 197, 0 },
                    { 5, 198, 0 },
                    { 1, 199, 0 }
                });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "Id_Order", "Expire_Date", "Detail", "EpsId", "Id_sale", "Order_Date" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Order detail 1", 1, 1, new DateTime(2022, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Order detail 2", 2, 2, new DateTime(2023, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) }
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
