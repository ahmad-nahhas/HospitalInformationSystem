using HospitalInformationSystem.Shared.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace HospitalInformationSystem.Shared
{
    public class HospitalInformationSystemDbContext : DbContext
    {
        public HospitalInformationSystemDbContext(DbContextOptions<HospitalInformationSystemDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Patient>().HasData(new Patient
            {
                Id = Guid.NewGuid(),
                Name = "Ahmet Bakırcı",
                FileNo = 32154987431,
                CitizenId = "33356489317",
                BirthDate = DateTime.Parse("01/01/1999"),
                Gender = Gender.Male,
                Natinality = "Syrian",
                PhoneNumber = "+905383754105",
                Email = "ahmetbakirci30@gmail.com",
                Country = "Turkey",
                City = "Konya",
                Street = "Başak Caddesi",
                Address1 = "Fevzi Çakmak Mahallesi 10782. Sokak Uhut Sitesi No:2A/9 Karatay/Konya",
                Address2 = "Hacıveyiszade Mahallesi Müeyyitzade Sokak No:14/B Karatay/Konya",
                ContactPerson = "Fuat Bakırcı",
                ContactRelation = "Brother",
                ContactPhone = "+905366724096",
                RecordCreationDate = DateTime.Now,
                FirstVisitDate = DateTime.Now
            }, new Patient
            {
                Id = Guid.NewGuid(),
                Name = "Muhammet Bakırcı",
                FileNo = 9874231674421,
                CitizenId = "55693457810",
                BirthDate = DateTime.Parse("01/01/1990"),
                Gender = Gender.Male,
                Natinality = "Syrian",
                PhoneNumber = "+905365823893",
                Email = "amuhammetbakirci30@gmail.com",
                Country = "Turkey",
                City = "Konya",
                Street = "Başak Caddesi",
                Address1 = "Fevzi Çakmak Mahallesi 10782. Sokak Uhut Sitesi No:2A/9 Karatay/Konya",
                Address2 = "Hacıveyiszade Mahallesi Müeyyitzade Sokak No:14/B Karatay/Konya",
                ContactPerson = "Fuat Bakırcı",
                ContactRelation = "Brother",
                ContactPhone = "+905366724096",
                RecordCreationDate = DateTime.Now,
                FirstVisitDate = DateTime.Now
            }, new Patient
            {
                Id = Guid.NewGuid(),
                Name = "Ahmet Nehhas",
                FileNo = 6516321616058,
                CitizenId = "59356489387",
                BirthDate = DateTime.Parse("01/01/1997"),
                Gender = Gender.Male,
                Natinality = "Syrian",
                PhoneNumber = "+905383754105",
                Email = "ahmetbakirci30@gmail.com",
                Country = "Turkey",
                City = "Konya",
                Street = "Başak Caddesi",
                Address1 = "Fevzi Çakmak Mahallesi 10782. Sokak Uhut Sitesi No:2A/9 Karatay/Konya",
                Address2 = "Hacıveyiszade Mahallesi Müeyyitzade Sokak No:14/B Karatay/Konya",
                ContactPerson = "Fuat Bakırcı",
                ContactRelation = "Brother",
                ContactPhone = "+905366724096",
                RecordCreationDate = DateTime.Now,
                FirstVisitDate = DateTime.Now
            }, new Patient
            {
                Id = Guid.NewGuid(),
                Name = "Fatma Rıza",
                FileNo = 354168102081,
                CitizenId = "98632189317",
                BirthDate = DateTime.Parse("01/01/1993"),
                Gender = Gender.Female,
                Natinality = "Turkish",
                PhoneNumber = "+905383754105",
                Email = "ahmetbakirci30@gmail.com",
                Country = "Turkey",
                City = "Konya",
                Street = "Başak Caddesi",
                Address1 = "Fevzi Çakmak Mahallesi 10782. Sokak Uhut Sitesi No:2A/9 Karatay/Konya",
                Address2 = "Hacıveyiszade Mahallesi Müeyyitzade Sokak No:14/B Karatay/Konya",
                ContactPerson = "Fuat Bakırcı",
                ContactRelation = "Brother",
                ContactPhone = "+905366724096",
                RecordCreationDate = DateTime.Now,
                FirstVisitDate = DateTime.Now
            }, new Patient
            {
                Id = Guid.NewGuid(),
                Name = "Halide Bakırcı",
                FileNo = 3234054987431,
                CitizenId = "96256489317",
                BirthDate = DateTime.Parse("01/01/1981"),
                Gender = Gender.Female,
                Natinality = "Syrian",
                PhoneNumber = "+905383754105",
                Email = "ahmetbakirci30@gmail.com",
                Country = "Turkey",
                City = "Konya",
                Street = "Başak Caddesi",
                Address1 = "Fevzi Çakmak Mahallesi 10782. Sokak Uhut Sitesi No:2A/9 Karatay/Konya",
                Address2 = "Hacıveyiszade Mahallesi Müeyyitzade Sokak No:14/B Karatay/Konya",
                ContactPerson = "Fuat Bakırcı",
                ContactRelation = "Brother",
                ContactPhone = "+905366724096",
                RecordCreationDate = DateTime.Now,
                FirstVisitDate = DateTime.Now
            }, new Patient
            {
                Id = Guid.NewGuid(),
                Name = "Nasır Bakırcı",
                FileNo = 9874231601491,
                CitizenId = "50699827810",
                BirthDate = DateTime.Parse("01/01/1998"),
                Gender = Gender.Male,
                Natinality = "Iraqi",
                PhoneNumber = "+905365823893",
                Email = "amuhammetbakirci30@gmail.com",
                Country = "Turkey",
                City = "Konya",
                Street = "Başak Caddesi",
                Address1 = "Fevzi Çakmak Mahallesi 10782. Sokak Uhut Sitesi No:2A/9 Karatay/Konya",
                Address2 = "Hacıveyiszade Mahallesi Müeyyitzade Sokak No:14/B Karatay/Konya",
                ContactPerson = "Fuat Bakırcı",
                ContactRelation = "Brother",
                ContactPhone = "+905366724096",
                RecordCreationDate = DateTime.Now,
                FirstVisitDate = DateTime.Now
            }, new Patient
            {
                Id = Guid.NewGuid(),
                Name = "Ritta Safa",
                FileNo = 15163616058,
                CitizenId = "59356409387",
                BirthDate = DateTime.Parse("01/01/2003"),
                Gender = Gender.Female,
                Natinality = "Turkish",
                PhoneNumber = "+905383754105",
                Email = "ahmetbakirci30@gmail.com",
                Country = "Turkey",
                City = "Konya",
                Street = "Başak Caddesi",
                Address1 = "Fevzi Çakmak Mahallesi 10782. Sokak Uhut Sitesi No:2A/9 Karatay/Konya",
                Address2 = "Hacıveyiszade Mahallesi Müeyyitzade Sokak No:14/B Karatay/Konya",
                ContactPerson = "Fuat Bakırcı",
                ContactRelation = "Brother",
                ContactPhone = "+905366724096",
                RecordCreationDate = DateTime.Now,
                FirstVisitDate = DateTime.Now
            }, new Patient
            {
                Id = Guid.NewGuid(),
                Name = "Fatma Lale",
                FileNo = 3544768102081,
                CitizenId = "92032189317",
                BirthDate = DateTime.Parse("01/01/1991"),
                Gender = Gender.Female,
                Natinality = "Turk",
                PhoneNumber = "+905383754105",
                Email = "ahmetbakirci30@gmail.com",
                Country = "Turkey",
                City = "Konya",
                Street = "Başak Caddesi",
                Address1 = "Fevzi Çakmak Mahallesi 10782. Sokak Uhut Sitesi No:2A/9 Karatay/Konya",
                Address2 = "Hacıveyiszade Mahallesi Müeyyitzade Sokak No:14/B Karatay/Konya",
                ContactPerson = "Fuat Bakırcı",
                ContactRelation = "Brother",
                ContactPhone = "+905366724096",
                RecordCreationDate = DateTime.Now,
                FirstVisitDate = DateTime.Now
            });
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            ChangeTracker.DetectChanges();

            foreach (var item in ChangeTracker.Entries().Where(e => e.State == EntityState.Added))
                item.Property("RecordCreationDate").CurrentValue = DateTime.UtcNow;

            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        public DbSet<Patient> Patients { get; set; }
    }
}