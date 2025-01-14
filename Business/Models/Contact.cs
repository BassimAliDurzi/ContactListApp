using Business.Helper;

namespace Business.Models;

public class Contact
{
    public string Id { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;
    public string Street { get; set; } = null!;
    public string PostalCode { get; set; } = null!;
    public string City { get; set; } = null!;

    public string FullName => $"{FirstName} {LastName}";
    public string ContactInfo => $"{Email}, {PhoneNumber}";
    public string Address => $"{Street}, {PostalCode} {City}";
}
