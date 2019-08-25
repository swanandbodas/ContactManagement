using DataLayer.Models;
using System.Collections.Generic;

namespace DataLayer
{
    public interface IContactDataLayer
    {
        void CreateContact(Contact newContact);
        void DeleteContact(int id);
        void EditContact(int id, Contact editedContact);
        IEnumerable<Contact> GetContacts();
    }
}