using DataAnnotationValidator.Domain.People;
using Xunit;

namespace DataAnnotationValidator.Test.People
{
    public class PersonValidatorShould
    {
        [Fact]
        public void NotValidateNullPerson()
        {
            var sut = new PersonValidator();
            var actual = sut.Validate(null);
            Assert.False(actual);
        }
        [Fact]
        public void NotValidateEmptyPerson()
        {
            var sut = new PersonValidator();
            var actual = sut.Validate(new PersonInformation());
            Assert.False(actual);
        }
        [Fact]
        public void NotValidateFullyInformedPerson()
        {
            var person = new PersonInformation
            {
                Name = "John",
                Surname = "Doe",
                Email = "jdoe@domain.tk",
                IdNumber = "x-1111111",
                PhoneNumber = "555123123"
            };
            var sut = new PersonValidator();
            var actual = sut.Validate(person);
            Assert.True(actual);
        }
        [Fact]
        public void NotValidateWrongEmailPerson()
        {
            var sut = new PersonValidator();
            var person = new PersonInformation
            {
                Name = "John",
                Surname = "Doe",
                Email = "jdoedomain.tk",
                IdNumber = "x-1111111",
                PhoneNumber = "555123123"
            };
            var actual = sut.Validate(person);
            Assert.False(actual);
        }
        [Fact]
        public void ValidateNoEmailNoPhonePerson()
        {
            var sut = new PersonValidator();
            var person = new PersonInformation
            {
                Name = "John",
                Surname = "Doe",
                Email = string.Empty,
                IdNumber = "x-1111111",
                PhoneNumber = null
            };
            var actual = sut.Validate(person);
            Assert.True(actual);
        }
    }
}
