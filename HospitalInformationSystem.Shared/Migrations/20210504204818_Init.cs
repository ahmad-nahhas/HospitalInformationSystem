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
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    ContactPerson = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ContactRelation = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ContactPhone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Country = table.Column<string>(type: "nvarchar(65)", maxLength: 65, nullable: true),
                    City = table.Column<string>(type: "nvarchar(65)", maxLength: 65, nullable: true),
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
                    { new Guid("77ea19a8-d0a4-4de7-acac-925a88f366bc"), "Fevzi Çakmak Mahallesi 10782. Sokak Uhut Sitesi No:2A/9 Karatay/Konya", "Hacıveyiszade Mahallesi Müeyyitzade Sokak No:14/B Karatay/Konya", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "33356489317", "Konya", "Fuat Bakırcı", "+905366724096", "Brother", "Turkey", "ahmetbakirci30@gmail.com", 32154987431m, new DateTime(2021, 5, 4, 23, 48, 18, 199, DateTimeKind.Local).AddTicks(3604), 0, "Ahmet Bakırcı", "Syrian", "+905383754105", new DateTime(2021, 5, 4, 23, 48, 18, 198, DateTimeKind.Local).AddTicks(9700), "Başak Caddesi" },
                    { new Guid("5aac3544-2199-48ee-a536-8b63a4edaf0c"), "Fevzi Çakmak Mahallesi 10782. Sokak Uhut Sitesi No:2A/9 Karatay/Konya", "Hacıveyiszade Mahallesi Müeyyitzade Sokak No:14/B Karatay/Konya", new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "55693457810", "Konya", "Fuat Bakırcı", "+905366724096", "Brother", "Turkey", "amuhammetbakirci30@gmail.com", 9874231674421m, new DateTime(2021, 5, 4, 23, 48, 18, 199, DateTimeKind.Local).AddTicks(4448), 0, "Muhammet Bakırcı", "Syrian", "+905365823893", new DateTime(2021, 5, 4, 23, 48, 18, 199, DateTimeKind.Local).AddTicks(4441), "Başak Caddesi" },
                    { new Guid("b9c793fd-a2db-498a-91f4-7668219ca219"), "Fevzi Çakmak Mahallesi 10782. Sokak Uhut Sitesi No:2A/9 Karatay/Konya", "Hacıveyiszade Mahallesi Müeyyitzade Sokak No:14/B Karatay/Konya", new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "59356489387", "Konya", "Fuat Bakırcı", "+905366724096", "Brother", "Turkey", "ahmetbakirci30@gmail.com", 6516321616058m, new DateTime(2021, 5, 4, 23, 48, 18, 199, DateTimeKind.Local).AddTicks(4467), 0, "Ahmet Nehhas", "Syrian", "+905383754105", new DateTime(2021, 5, 4, 23, 48, 18, 199, DateTimeKind.Local).AddTicks(4465), "Başak Caddesi" },
                    { new Guid("019b54d7-b44b-4ac0-833b-db09f7dbf3cf"), "Fevzi Çakmak Mahallesi 10782. Sokak Uhut Sitesi No:2A/9 Karatay/Konya", "Hacıveyiszade Mahallesi Müeyyitzade Sokak No:14/B Karatay/Konya", new DateTime(1993, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "98632189317", "Konya", "Fuat Bakırcı", "+905366724096", "Brother", "Turkey", "ahmetbakirci30@gmail.com", 354168102081m, new DateTime(2021, 5, 4, 23, 48, 18, 199, DateTimeKind.Local).AddTicks(4476), 1, "Fatma Rıza", "Turkish", "+905383754105", new DateTime(2021, 5, 4, 23, 48, 18, 199, DateTimeKind.Local).AddTicks(4474), "Başak Caddesi" },
                    { new Guid("9477d78b-37b1-4ca6-8624-5391f341b751"), "Fevzi Çakmak Mahallesi 10782. Sokak Uhut Sitesi No:2A/9 Karatay/Konya", "Hacıveyiszade Mahallesi Müeyyitzade Sokak No:14/B Karatay/Konya", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "96256489317", "Konya", "Fuat Bakırcı", "+905366724096", "Brother", "Turkey", "ahmetbakirci30@gmail.com", 3234054987431m, new DateTime(2021, 5, 4, 23, 48, 18, 199, DateTimeKind.Local).AddTicks(4484), 1, "Halide Bakırcı", "Syrian", "+905383754105", new DateTime(2021, 5, 4, 23, 48, 18, 199, DateTimeKind.Local).AddTicks(4483), "Başak Caddesi" },
                    { new Guid("46ccc5b8-c339-4bac-a03f-95222479e4cd"), "Fevzi Çakmak Mahallesi 10782. Sokak Uhut Sitesi No:2A/9 Karatay/Konya", "Hacıveyiszade Mahallesi Müeyyitzade Sokak No:14/B Karatay/Konya", new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "50699827810", "Konya", "Fuat Bakırcı", "+905366724096", "Brother", "Turkey", "amuhammetbakirci30@gmail.com", 9874231601491m, new DateTime(2021, 5, 4, 23, 48, 18, 199, DateTimeKind.Local).AddTicks(4493), 0, "Nasır Bakırcı", "Iraqi", "+905365823893", new DateTime(2021, 5, 4, 23, 48, 18, 199, DateTimeKind.Local).AddTicks(4491), "Başak Caddesi" },
                    { new Guid("8d0ca88b-99b9-4122-add8-16ff615256ec"), "Fevzi Çakmak Mahallesi 10782. Sokak Uhut Sitesi No:2A/9 Karatay/Konya", "Hacıveyiszade Mahallesi Müeyyitzade Sokak No:14/B Karatay/Konya", new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "59356409387", "Konya", "Fuat Bakırcı", "+905366724096", "Brother", "Turkey", "ahmetbakirci30@gmail.com", 15163616058m, new DateTime(2021, 5, 4, 23, 48, 18, 199, DateTimeKind.Local).AddTicks(4501), 1, "Ritta Safa", "Turkish", "+905383754105", new DateTime(2021, 5, 4, 23, 48, 18, 199, DateTimeKind.Local).AddTicks(4499), "Başak Caddesi" },
                    { new Guid("fde418b2-93f4-43b8-8bc1-281c80f96ce5"), "Fevzi Çakmak Mahallesi 10782. Sokak Uhut Sitesi No:2A/9 Karatay/Konya", "Hacıveyiszade Mahallesi Müeyyitzade Sokak No:14/B Karatay/Konya", new DateTime(1991, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "92032189317", "Konya", "Fuat Bakırcı", "+905366724096", "Brother", "Turkey", "ahmetbakirci30@gmail.com", 3544768102081m, new DateTime(2021, 5, 4, 23, 48, 18, 199, DateTimeKind.Local).AddTicks(4509), 1, "Fatma Lale", "Turk", "+905383754105", new DateTime(2021, 5, 4, 23, 48, 18, 199, DateTimeKind.Local).AddTicks(4507), "Başak Caddesi" }
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
