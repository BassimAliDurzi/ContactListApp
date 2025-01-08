using Business.Dtos;
using Business.Models;

namespace Business.Interfaces
{
    public interface IContactService1
    {
        IEnumerable<Contact> GetAll();
        bool save(ContactForm form);
    }
}