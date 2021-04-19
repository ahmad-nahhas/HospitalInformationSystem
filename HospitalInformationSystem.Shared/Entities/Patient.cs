using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalInformationSystem.Shared.Entities
{
    [Index(nameof(FileNo), IsUnique = true)]
    [Index(nameof(CitizenId), IsUnique = true)]
    public class Patient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(255, ErrorMessage = "Name cannot exceed {1} characters.")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Required(ErrorMessage = "FileNo is required.")]
        [Column(TypeName = "decimal(38, 0)")]
        public decimal FileNo { get; set; }

        [Required(ErrorMessage = "Citizen Id is required.")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "Citizen ID must contain {1} digits.")]
        public string CitizenId { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}")]
        [DataType(DataType.Date)]
        public DateTime? BirthDate { get; set; }

        [EnumDataType(typeof(Gender))]
        public Gender? Gender { get; set; }

        [StringLength(65, ErrorMessage = "Natinality cannot exceed {1} characters.")]
        [DataType(DataType.Text)]
        public string Natinality { get; set; }

        [Required(ErrorMessage = "Phone Number is required.")]
        [StringLength(15, ErrorMessage = "Phone Number cannot exceed {1} numbers.")]
        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string PhoneNumber { get; set; }

        [StringLength(512, ErrorMessage = "Email Address cannot exceed {1} characters.")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

        [StringLength(255, ErrorMessage = "Contact Person cannot exceed {1} characters.")]
        [DataType(DataType.Text)]
        public string ContactPerson { get; set; }

        [StringLength(255, ErrorMessage = "Contact Relation cannot exceed {1} characters.")]
        [DataType(DataType.Text)]
        public string ContactRelation { get; set; }

        [StringLength(15, ErrorMessage = "Phone Number cannot exceed {1} numbers.")]
        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string ContactPhone { get; set; }

        [Required(ErrorMessage = "Country is required.")]
        [StringLength(65, ErrorMessage = "Country cannot exceed {1} characters.")]
        [DataType(DataType.Text)]
        public string Country { get; set; }

        [Required(ErrorMessage = "City is required.")]
        [StringLength(65, ErrorMessage = "City cannot exceed {1} characters.")]
        [DataType(DataType.Text)]
        public string City { get; set; }

        [StringLength(255, ErrorMessage = "Street cannot exceed {1} characters.")]
        [DataType(DataType.Text)]
        public string Street { get; set; }

        [StringLength(512, ErrorMessage = "Address1 cannot exceed {1} characters.")]
        [DataType(DataType.MultilineText)]
        public string Address1 { get; set; }

        [StringLength(512, ErrorMessage = "Address2 cannot exceed {1} characters.")]
        [DataType(DataType.MultilineText)]
        public string Address2 { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}")]
        [DataType(DataType.Date)]
        public DateTime? FirstVisitDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}")]
        [DataType(DataType.Date)]
        public DateTime RecordCreationDate { get; set; }
    }
}