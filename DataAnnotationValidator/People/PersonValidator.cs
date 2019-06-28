using System.Text.RegularExpressions;

namespace DataAnnotationValidator.Domain.People
{
    public class PersonValidator
    {
        public bool Validate(PersonInformation personInfo)
        {
            if (personInfo != null)
            {
                if(!string.IsNullOrEmpty(personInfo.Name)
                    && !string.IsNullOrEmpty(personInfo.Surname) 
                    && !string.IsNullOrEmpty(personInfo.IdNumber))
                {
                    if(!string.IsNullOrEmpty(personInfo.Email))
                    {
                        Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                        Match match = regex.Match(personInfo.Email);
                        return match.Success;
                    }
                    return true;
                }
            }
            return false;
        }
    }
}
