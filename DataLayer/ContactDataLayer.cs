using DataLayer.Models;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer
{
    public class ContactDataLayer : IContactDataLayer
    {
        CMContext contactDataContext;
        public ContactDataLayer(CMContext contactDataContext)
        {
            this.contactDataContext = contactDataContext;
        }
        public IEnumerable<Contact> GetContacts()
        {
            return contactDataContext.Contact.ToList();
        }

        public void DeleteContact(int id)
        { }

        public void EditContact(int id, Contact editedContact)
        { }

        public void CreateContact(Contact newContact)
        { }

    }
}
