using DataAnnotationValidator.Domain.ContactInfo;
using Xunit;

namespace DataAnnotationValidator.Test.ContactInfo
{
    public class ContactnformationValidatorShould
    {
        [Fact]
        public void NotValidateNullContactformation()
        {
            var sut = new ContactnformationValidator();
            var (actual, logs) = sut.TryValidate(null);
            Assert.False(actual);
        }
        [Fact]
        public void NotValidateEmptyContactformation()
        {
            var sut = new ContactnformationValidator();
            var (actual, logs) = sut.TryValidate(new Contactnformation());
            Assert.False(actual);
        }
        [Fact]
        public void NotValidateWrongProfesionalEmailContactformation()
        {
            var sut = new ContactnformationValidator();
            var info = new Contactnformation
            {
                IdNumber = "1234Ab",
                Name = "John",
                Surname = "Doe",
                ProfessionalEmail = "abcde",
                ProfessionalPhoneNumber = "999666555"
            };
            var (actual, logs) = sut.TryValidate(info);
            Assert.False(actual);
        }
        [Fact]
        public void NotValidateWrongPersonalEmailContactformation()
        {
            var sut = new ContactnformationValidator();
            var info = new Contactnformation
            {
                IdNumber = "1234Ab",
                Name = "John",
                Surname = "Doe",
                PersonalEmail = "abcde",
                ProfessionalEmail = "john@doedomain.tk",
                ProfessionalPhoneNumber = "999666555"
            };
            var (actual, logs) = sut.TryValidate(info);
            Assert.False(actual);
        }
        [Fact]
        public void NotValidateWrongPersonalPhoneContactformation()
        {
            var sut = new ContactnformationValidator();
            var info = new Contactnformation
            {
                IdNumber = "1234Ab",
                Name = "John",
                Surname = "Doe",
                ProfessionalEmail = "john@doedomain.tk",
                ProfessionalPhoneNumber = "999666555",
                PersonalPhoneNumber="youDontCare"
            };
            var (actual, logs) = sut.TryValidate(info);
            Assert.False(actual);
        }
        [Fact]
        public void ValidateRequerdPersonalPhoneContactformation()
        {
            var sut = new ContactnformationValidator();
            var info = new Contactnformation
            {
                IdNumber = "123",
                Name = "Ot",
                Surname = "Pi",
                ProfessionalEmail = "ot@ddomain.tk",
                ProfessionalPhoneNumber = "99966655"
            };
            var (actual, logs) = sut.TryValidate(info);
            Assert.True(actual);
        }
        [Fact]
        public void NotValidateInvalidNameContactformation()
        {
            var sut = new ContactnformationValidator();
            var info = new Contactnformation
            {
                IdNumber = "123",
                Name = "O",
                Surname = "Pi",
                ProfessionalEmail = "ot@ddomain.tk",
                ProfessionalPhoneNumber = "99966655"
            };
            var (actual, logs) = sut.TryValidate(info);
            Assert.False(actual);
        }
        [Fact]
        public void NotValidateInvalidSurnameContactformation()
        {
            var sut = new ContactnformationValidator();
            var info = new Contactnformation
            {
                IdNumber = "123",
                Name = "Ot",
                Surname = "P",
                ProfessionalEmail = "ot@ddomain.tk",
                ProfessionalPhoneNumber = "99966655"
            };
            var (actual, logs) = sut.TryValidate(info);
            Assert.False(actual);
        }
        [Fact]
        public void NotValidateInvalidIdNumberContactformation()
        {
            var sut = new ContactnformationValidator();
            var info = new Contactnformation
            {
                IdNumber = "00",
                Name = "Ot",
                Surname = "Pi",
                ProfessionalEmail = "ot@ddomain.tk",
                ProfessionalPhoneNumber = "99966655"
            };
            var (actual, logs) = sut.TryValidate(info);
            Assert.False(actual);
        }
    }
}
