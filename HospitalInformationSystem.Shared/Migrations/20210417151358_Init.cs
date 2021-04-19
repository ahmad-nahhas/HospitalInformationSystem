using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalInformationSystem.Shared.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    FileNo = table.Column<decimal>(type: "decimal(38,0)", nullable: false),
                    CitizenId = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: true),
                    Natinality = table.Column<string>(type: "nvarchar(65)", maxLength: 65, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    ContactPerson = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ContactRelation = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ContactPhone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Country = table.Column<string>(type: "nvarchar(65)", maxLength: 65, nullable: false),
                    City = table.Column<string>(type: "nvarchar(65)", maxLength: 65, nullable: false),
                    Street = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Address1 = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    Address2 = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    FirstVisitDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RecordCreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Address1", "Address2", "BirthDate", "CitizenId", "City", "ContactPerson", "ContactPhone", "ContactRelation", "Country", "Email", "FileNo", "FirstVisitDate", "Gender", "Name", "Natinality", "PhoneNumber", "RecordCreationDate", "Street" },
                values: new object[] { new Guid("ef5c8981-5185-4f12-b8b4-9dffc5103e58"), "Fevzi Çakmak Mahallesi 10782. Sokak Uhut Sitesi No:2A/9 Karatay/Konya", "Hacıveyiszade Mahallesi Müeyyitzade Sokak No:14/B Karatay/Konya", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "33356489317", "Konya", "Fuat Bakırcı", "+905366724096", "Brother", "Turkey", "ahmetbakirci30@gmail.com", 1155540415m, new DateTime(2021, 4, 17, 15, 13, 58, 96, DateTimeKind.Utc).AddTicks(6271), 0, "Ahmet Bakırcı", "Syrian", "+905383754105", new DateTime(2021, 4, 17, 15, 13, 58, 96, DateTimeKind.Utc).AddTicks(5855), "Başak Caddesi" });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Address1", "Address2", "BirthDate", "CitizenId", "City", "ContactPerson", "ContactPhone", "ContactRelation", "Country", "Email", "FileNo", "FirstVisitDate", "Gender", "Name", "Natinality", "PhoneNumber", "RecordCreationDate", "Street" },
                values: new object[] { new Guid("1ced7357-0f1b-4b69-a4df-3c3b65d05d38"), "Fevzi Çakmak Mahallesi 10782. Sokak Uhut Sitesi No:2A/9 Karatay/Konya", "Hacıveyiszade Mahallesi Müeyyitzade Sokak No:14/B Karatay/Konya", new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "55693457810", "Konya", "Fuat Bakırcı", "+905366724096", "Brother", "Turkey", "amuhammetbakirci30@gmail.com", 1246663973m, new DateTime(2021, 4, 17, 15, 13, 58, 96, DateTimeKind.Utc).AddTicks(6834), 0, "Muhammet Bakırcı", "Syrian", "+905365823893", new DateTime(2021, 4, 17, 15, 13, 58, 96, DateTimeKind.Utc).AddTicks(6831), "Başak Caddesi" });

            migrationBuilder.CreateIndex(
                name: "IX_Patients_CitizenId",
                table: "Patients",
                column: "CitizenId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Patients_FileNo",
                table: "Patients",
                column: "FileNo",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Patients");
        }
    }
}
