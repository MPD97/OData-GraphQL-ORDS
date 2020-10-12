using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DatabaseLibrary.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryId = table.Column<short>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    PersonId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 100, nullable: false),
                    SecondName = table.Column<string>(maxLength: 100, nullable: true),
                    LastName = table.Column<string>(maxLength: 150, nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    BirthDate = table.Column<DateTimeOffset>(nullable: false),
                    NationalityId = table.Column<short>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.PersonId);
                    table.ForeignKey(
                        name: "FK_Persons_Countries_NationalityId",
                        column: x => x.NationalityId,
                        principalTable: "Countries",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryId", "CountryName" },
                values: new object[,]
                {
                    { (short)1, "Poland" },
                    { (short)2, "Germany" },
                    { (short)3, "Russia" },
                    { (short)4, "France" },
                    { (short)5, "Denmark" }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "PersonId", "BirthDate", "FirstName", "Gender", "LastName", "NationalityId", "SecondName" },
                values: new object[,]
                {
                    { 3L, new DateTimeOffset(new DateTime(1964, 10, 14, 22, 37, 42, 233, DateTimeKind.Unspecified).AddTicks(1508), new TimeSpan(0, 2, 0, 0, 0)), "Antoni", 0, "Szewczyk", (short)1, "Władysław" },
                    { 4L, new DateTimeOffset(new DateTime(1984, 10, 14, 22, 37, 42, 233, DateTimeKind.Unspecified).AddTicks(1519), new TimeSpan(0, 2, 0, 0, 0)), "Katarzyna", 1, "Kowal", (short)1, null },
                    { 1L, new DateTimeOffset(new DateTime(1952, 10, 13, 22, 37, 42, 230, DateTimeKind.Unspecified).AddTicks(6296), new TimeSpan(0, 2, 0, 0, 0)), "Antoni", 0, "Muller", (short)2, null },
                    { 2L, new DateTimeOffset(new DateTime(2002, 1, 6, 22, 37, 42, 233, DateTimeKind.Unspecified).AddTicks(1433), new TimeSpan(0, 2, 0, 0, 0)), "Helga", 1, "Von Treskow", (short)2, "Petra" },
                    { 5L, new DateTimeOffset(new DateTime(1999, 6, 8, 22, 37, 42, 233, DateTimeKind.Unspecified).AddTicks(1526), new TimeSpan(0, 2, 0, 0, 0)), "Николай", 0, "Лебедев", (short)3, "Иван" },
                    { 6L, new DateTimeOffset(new DateTime(1987, 9, 27, 22, 37, 42, 233, DateTimeKind.Unspecified).AddTicks(1534), new TimeSpan(0, 2, 0, 0, 0)), "Галина", 1, "Соколов", (short)3, "Нина" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Persons_NationalityId",
                table: "Persons",
                column: "NationalityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
