using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataAnnotationValidator.Domain.ContactInfo
{
    public class ContactnformationValidator
    {
        public (bool, List<ValidationResult>) TryValidate(Contactnformation info)
        {
            var success = false;
            var results = new List<ValidationResult>();
            if (info != null)
            {
                var context = new ValidationContext(info, serviceProvider: null, items: null);
                success = Validator.TryValidateObject(info, context, results, true);
            }
            return (success, results);
        }
    }
}
