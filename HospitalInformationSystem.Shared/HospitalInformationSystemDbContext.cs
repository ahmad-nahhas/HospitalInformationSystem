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
                FileNo = new Random().Next(),
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
                RecordCreationDate = DateTime.UtcNow,
                FirstVisitDate = DateTime.UtcNow
            }, new Patient
            {
                Id = Guid.NewGuid(),
                Name = "Muhammet Bakırcı",
                FileNo = new Random().Next(),
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
                RecordCreationDate = DateTime.UtcNow,
                FirstVisitDate = DateTime.UtcNow
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