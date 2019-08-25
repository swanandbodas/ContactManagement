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
        {
            var contact = contactDataContext.Contact.Find(id);
            contact.Active = false;
            contactDataContext.Update(contact);
            contactDataContext.SaveChanges();
        }

        public void EditContact(int id, Contact editedContact)
        {
            var contact = contactDataContext.Contact.Find(id);
            contact.Active = editedContact.Active;
            contact.ContactNumber = editedContact.ContactNumber;
            contact.FirstName = editedContact.FirstName;
            contact.LastName = editedContact.LastName;

            contactDataContext.Contact.Update(editedContact);
            contactDataContext.SaveChanges();
        }

        public void CreateContact(Contact newContact)
        {
            contactDataContext.Contact.Add(newContact);
            contactDataContext.SaveChanges();
        }

    }
}
