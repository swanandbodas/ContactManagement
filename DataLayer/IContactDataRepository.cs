using DataLayer.Models;
using System.Collections.Generic;

namespace DataLayer
{
    public interface IContactDataRepository
    {
        void CreateContact(Contact newContact);
        int DeleteContact(int id);
        void EditContact(int id, Contact editedContact);
        IEnumerable<Contact> GetContacts();
        Contact GetContact(int id);
    }
}