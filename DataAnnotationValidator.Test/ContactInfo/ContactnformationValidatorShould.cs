using DataAnnotationValidator.Domain.ContactInfo;
using Xunit;

namespace DataAnnotationValidator.Test.ContactInfo
{
    public class ContactnformationValidatorShould
    {
        [Fact]
        public void NotValidateNullContactnformation()
        {
            var sut = new ContactnformationValidator();
            var (actual, logs) = sut.TryValidate(null);
            Assert.False(actual);
        }
        [Fact]
        public void NotValidateEmptyContactnformation()
        {
            var sut = new ContactnformationValidator();
            var (actual, logs) = sut.TryValidate(new Contactnformation());
            Assert.False(actual);
        }
    }
}
