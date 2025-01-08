using Business.Dtos;
using Business.Helper;
using Business.Models;

namespace Business.Factories;

public static class ContactFactory
{
    public static ContactForm Create() => new();

    public static Contact Create(ContactForm form) => new()
    {
        Id = IdGenerator.Generate(),
        FirstName = form.FirstName,
        LastName = form.LastName,
        Email = form.Email,
        PhoneNumber = form.PhoneNumber,
        Street = form.Street,
        PostalCode = form.PostalCode,
        City = form.City,
    };

}
