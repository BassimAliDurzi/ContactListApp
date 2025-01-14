using System.Text.Json;
using Business.Dtos;
using Business.Factories;
using Business.Interfaces;
using Business.Models;

namespace Business.Services;

public class ContactService(IFileService fileService) : IContactService
{
    private readonly IFileService _fileService = fileService;
    private List<Contact> _contacts = [];

    public IEnumerable<Contact> GetAll()
    {
        var content = _fileService.GetContentFromFile();
        try
        {
            _contacts = JsonSerializer.Deserialize<List<Contact>>(content)!;
        }
        catch
        {
            _contacts = [];
        }



        return _contacts;
    }

    public bool Create(ContactForm form)
    {
        try
        {
            var contact = ContactFactory.Create(form);
            _contacts.Add(contact);

            var json = JsonSerializer.Serialize(_contacts);
            var result = _fileService.SaveContentToFile(json);
            return result;
        }
        catch
        {
            return false;
        }

    }
}
