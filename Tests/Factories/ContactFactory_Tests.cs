using Business.Dtos;
using Business.Factories;
using Business.Models;

namespace Tests.Factories;

public class ContactFactory_Tests
{
    [Fact]
    public void Create_ShouldReturnContactForm()
    {
        // Act
        var result = ContactFactory.Create();


        // Assert
        Assert.NotNull(result);
        Assert.IsType<ContactForm>(result);
    }

    [Fact]
    public void Create_ShouldReturnContact_WhenContactFormIsProvided()
    {
        // Arrange
        var contactForm = new ContactForm()
        {
            FirstName = "John",
            LastName = "Doe",
            Email = "john.doe@domain.com",
            PhoneNumber = "01234564789",
            Street = "Street",
            PostalCode = "12345",
            City = "City"


        };


        // Act
        var result = ContactFactory.Create(contactForm);


        // Assert
        Assert.NotNull(result);
        Assert.IsType<Contact>(result);
        Assert.Equal(contactForm.FirstName, result.FirstName);
        Assert.Equal(contactForm.LastName, result.LastName);
        Assert.Equal(contactForm.Email, result.Email);
        Assert.Equal(contactForm.PhoneNumber, result.PhoneNumber);
        Assert.Equal(contactForm.Street, result.Street);
        Assert.Equal(contactForm.PostalCode, result.PostalCode);
        Assert.Equal(contactForm.City, result.City);
    }




}
