using System.Reflection.Metadata;
using System.Text.Json;
using Business.Dtos;
using Business.Interfaces;
using Business.Models;
using Business.Services;
using Moq;

namespace Tests.Services;

public class ContactService_Tests
{
    private readonly Mock<IFileService> _fileServiceMock;
    private readonly IContactService _contactService;


    public ContactService_Tests()
    {
        _fileServiceMock = new Mock<IFileService>();
        _contactService = new ContactService(_fileServiceMock.Object);
    }

    [Fact]
    public void Save_ShouldReturnTrue_AddSaveContactToListAndSaveToFile()
    {
        // arrange

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

        _fileServiceMock.Setup(x => x.SaveContentToFile(It.IsAny<string>())).Returns(true);

        // act

        var result = _contactService.Create(contactForm);


        // assert

        Assert.True(result);
        _fileServiceMock.Verify(x => x.SaveContentToFile(It.IsAny<string>()), Times.Once);
    }



    [Fact]
    public void GetAll_ShouldReturnListOfContacts()
    {
        // arrang

        List<Contact> expected = [new Contact { Id = "1", FirstName = "John", LastName = "Doe", Email = "john.doe@domain.com", PhoneNumber = "01234564789", Street = "Street", PostalCode = "12345", City = "City" }];
        var json = JsonSerializer.Serialize(expected);

        _fileServiceMock.Setup(x => x.GetContentFromFile()).Returns(json);


        // act

        var result = _contactService.GetAll();

        // assert
        Assert.NotNull(result);
        Assert.Single(result);
        Assert.Equal(expected[0].Id, result.First().Id);
        Assert.Equal(expected[0].FirstName, result.First().FirstName);
        Assert.Equal(expected[0].LastName, result.First().LastName);
        Assert.Equal(expected[0].Email, result.First().Email);
        Assert.Equal(expected[0].PhoneNumber, result.First().PhoneNumber);
        Assert.Equal(expected[0].Street, result.First().Street);
        Assert.Equal(expected[0].PostalCode, result.First().PostalCode);
        Assert.Equal(expected[0].City, result.First().City);


    }

    [Fact]
    public void Uodate_ShouldReturnTrue_UpdateContentAndSaveToFile()
    {
        // arrange
        var existingContact = new Contact()
        {
            FirstName = "John",
            LastName = "Doe",
            Email = "john.doe@domain.com",
            PhoneNumber = "01234564789",
            Street = "Street",
            PostalCode = "12345",
            City = "City"
        };

        var updatedContact = new Contact()
        {
            FirstName = "Isak",
            LastName = "Doe",
            Email = "john.doe@domain.com",
            PhoneNumber = "01234564789",
            Street = "Updated Street",
            PostalCode = "12345",
            City = "Updated City"
        };

        var contactList = new List<Contact> { existingContact };
        var json = JsonSerializer.Serialize(contactList);

        _fileServiceMock.Setup(x => x.GetContentFromFile()).Returns(json);
        _fileServiceMock.Setup(x => x.SaveContentToFile(It.IsAny<string>())).Returns(true);

        _contactService.GetAll();


        // act
        var result = _contactService.Update(updatedContact);

        // assert
        Assert.True(result);
        _fileServiceMock.Verify(x => x.SaveContentToFile(It.IsAny<string>()), Times.Once);

    }

    [Fact]
    public void Delete_ShouldRetuenTrue_RemoveContactAndSaveFile()
    {
        // arrange
        var contact = new Contact()
        {
            FirstName = "John",
            LastName = "Doe",
            Email = "john.doe@domain.com",
            PhoneNumber = "01234564789",
            Street = "Street",
            PostalCode = "12345",
            City = "City"
        };

        var contactList = new List<Contact> { contact };
        var json = JsonSerializer.Serialize(contactList);

        _fileServiceMock.Setup(x => x.GetContentFromFile()).Returns(json);
        _fileServiceMock.Setup(x => x.SaveContentToFile(It.IsAny<string>())).Returns(true);

        _contactService.GetAll();

        // act

        var result = _contactService.Delete(contact);

        // assert
        Assert.True(result);
        _fileServiceMock.Verify(x => x.SaveContentToFile(It.IsAny<string>()), Times.Once);
    }
}
