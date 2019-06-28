using System.ComponentModel.DataAnnotations;

namespace DataAnnotationValidator.Domain.ContactInfo
{
    public class Contactnformation
    {
        [Required(ErrorMessage = "Missing Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Missing Surname")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Missing IdNumber")]
        public string IdNumber { get; set; }

        [Required(ErrorMessage = "Missing Professional Phone Number")]
        [Phone(ErrorMessage = "Invalid Professional Phone Number")]
        public string ProfessionalPhoneNumber { get; set; }

        [Phone(ErrorMessage = "Invalid Personal Phone Number, not required anyway")]
        public string PersonalPhoneNumber { get; set; }

        [Required(ErrorMessage = "Missing ProfessionalEmail")]
        [EmailAddress(ErrorMessage = "Invalid Professional Email Format")]
        public string ProfessionalEmail { get; set; }

        [EmailAddress(ErrorMessage = "Invalid Personal Email, not required anyway")]
        public string PersonalEmail { get; set; }
        
    }
}
