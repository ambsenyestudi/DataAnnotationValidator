using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAnnotationValidator.Domain.ContactInfo
{
    public class ContactnformationParser
    {
        public (bool, Contactnformation) TryParse(string  json, ILogger logger)
        {
            var success = false;
            var result = default(Contactnformation);
            //Todo parse data

            return (success, result);
        }
    }
}
