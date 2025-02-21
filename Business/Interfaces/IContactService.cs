﻿using Business.Dtos;
using Business.Models;

namespace Business.Interfaces
{
    public interface IContactService
    {
        IEnumerable<Contact> GetAll();

        bool Create(ContactForm form);

        bool Update(Contact contact);

        bool Delete(Contact contact);

    }
}