using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalInformationSystem.Shared.Migrations
{
    public partial class Initial : Migration
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
                values: new object[,]
                {
                    { new Guid("17a73ff4-1305-4a1c-b1ad-9d143cee3683"), "Fevzi Çakmak Mahallesi 10782. Sokak Uhut Sitesi No:2A/9 Karatay/Konya", "Hacıveyiszade Mahallesi Müeyyitzade Sokak No:14/B Karatay/Konya", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "33356489317", "Konya", "Fuat Bakırcı", "+905366724096", "Brother", "Turkey", "ahmetbakirci30@gmail.com", 32154987431m, new DateTime(2021, 5, 4, 1, 25, 8, 691, DateTimeKind.Local).AddTicks(373), 0, "Ahmet Bakırcı", "Syrian", "+905383754105", new DateTime(2021, 5, 4, 1, 25, 8, 690, DateTimeKind.Local).AddTicks(6964), "Başak Caddesi" },
                    { new Guid("40b1f94f-33d7-401d-a2dd-50bf57c755f2"), "Fevzi Çakmak Mahallesi 10782. Sokak Uhut Sitesi No:2A/9 Karatay/Konya", "Hacıveyiszade Mahallesi Müeyyitzade Sokak No:14/B Karatay/Konya", new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "55693457810", "Konya", "Fuat Bakırcı", "+905366724096", "Brother", "Turkey", "amuhammetbakirci30@gmail.com", 9874231674421m, new DateTime(2021, 5, 4, 1, 25, 8, 691, DateTimeKind.Local).AddTicks(1016), 0, "Muhammet Bakırcı", "Syrian", "+905365823893", new DateTime(2021, 5, 4, 1, 25, 8, 691, DateTimeKind.Local).AddTicks(1011), "Başak Caddesi" },
                    { new Guid("8326b761-53e1-4099-a8fd-a683b80d9f07"), "Fevzi Çakmak Mahallesi 10782. Sokak Uhut Sitesi No:2A/9 Karatay/Konya", "Hacıveyiszade Mahallesi Müeyyitzade Sokak No:14/B Karatay/Konya", new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "59356489387", "Konya", "Fuat Bakırcı", "+905366724096", "Brother", "Turkey", "ahmetbakirci30@gmail.com", 6516321616058m, new DateTime(2021, 5, 4, 1, 25, 8, 691, DateTimeKind.Local).AddTicks(1033), 0, "Ahmet Nehhas", "Syrian", "+905383754105", new DateTime(2021, 5, 4, 1, 25, 8, 691, DateTimeKind.Local).AddTicks(1032), "Başak Caddesi" },
                    { new Guid("e6ea96b2-5f6b-48e4-81f8-79cc46a44e91"), "Fevzi Çakmak Mahallesi 10782. Sokak Uhut Sitesi No:2A/9 Karatay/Konya", "Hacıveyiszade Mahallesi Müeyyitzade Sokak No:14/B Karatay/Konya", new DateTime(1993, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "98632189317", "Konya", "Fuat Bakırcı", "+905366724096", "Brother", "Turkey", "ahmetbakirci30@gmail.com", 354168102081m, new DateTime(2021, 5, 4, 1, 25, 8, 691, DateTimeKind.Local).AddTicks(1041), 1, "Fatma Rıza", "Turkish", "+905383754105", new DateTime(2021, 5, 4, 1, 25, 8, 691, DateTimeKind.Local).AddTicks(1040), "Başak Caddesi" },
                    { new Guid("d51611e2-a357-4547-ad40-50db0ebced50"), "Fevzi Çakmak Mahallesi 10782. Sokak Uhut Sitesi No:2A/9 Karatay/Konya", "Hacıveyiszade Mahallesi Müeyyitzade Sokak No:14/B Karatay/Konya", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "96256489317", "Konya", "Fuat Bakırcı", "+905366724096", "Brother", "Turkey", "ahmetbakirci30@gmail.com", 3234054987431m, new DateTime(2021, 5, 4, 1, 25, 8, 691, DateTimeKind.Local).AddTicks(1062), 1, "Halide Bakırcı", "Syrian", "+905383754105", new DateTime(2021, 5, 4, 1, 25, 8, 691, DateTimeKind.Local).AddTicks(1061), "Başak Caddesi" },
                    { new Guid("b038a173-98ab-45db-9b7c-0028a861de21"), "Fevzi Çakmak Mahallesi 10782. Sokak Uhut Sitesi No:2A/9 Karatay/Konya", "Hacıveyiszade Mahallesi Müeyyitzade Sokak No:14/B Karatay/Konya", new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "50699827810", "Konya", "Fuat Bakırcı", "+905366724096", "Brother", "Turkey", "amuhammetbakirci30@gmail.com", 9874231601491m, new DateTime(2021, 5, 4, 1, 25, 8, 691, DateTimeKind.Local).AddTicks(1071), 0, "Nasır Bakırcı", "Iraqi", "+905365823893", new DateTime(2021, 5, 4, 1, 25, 8, 691, DateTimeKind.Local).AddTicks(1070), "Başak Caddesi" },
                    { new Guid("63309baf-321c-4b4c-a30c-2b867b22cb41"), "Fevzi Çakmak Mahallesi 10782. Sokak Uhut Sitesi No:2A/9 Karatay/Konya", "Hacıveyiszade Mahallesi Müeyyitzade Sokak No:14/B Karatay/Konya", new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "59356409387", "Konya", "Fuat Bakırcı", "+905366724096", "Brother", "Turkey", "ahmetbakirci30@gmail.com", 15163616058m, new DateTime(2021, 5, 4, 1, 25, 8, 691, DateTimeKind.Local).AddTicks(1079), 1, "Ritta Safa", "Turkish", "+905383754105", new DateTime(2021, 5, 4, 1, 25, 8, 691, DateTimeKind.Local).AddTicks(1078), "Başak Caddesi" },
                    { new Guid("e436310f-dce4-4148-a1be-661e1e3fd251"), "Fevzi Çakmak Mahallesi 10782. Sokak Uhut Sitesi No:2A/9 Karatay/Konya", "Hacıveyiszade Mahallesi Müeyyitzade Sokak No:14/B Karatay/Konya", new DateTime(1991, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "92032189317", "Konya", "Fuat Bakırcı", "+905366724096", "Brother", "Turkey", "ahmetbakirci30@gmail.com", 3544768102081m, new DateTime(2021, 5, 4, 1, 25, 8, 691, DateTimeKind.Local).AddTicks(1087), 1, "Fatma Lale", "Turk", "+905383754105", new DateTime(2021, 5, 4, 1, 25, 8, 691, DateTimeKind.Local).AddTicks(1086), "Başak Caddesi" }
                });

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
