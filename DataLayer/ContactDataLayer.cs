using DataLayer.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer
{
    public class ContactDataLayer : IContactDataLayer
    {
        //CMContext contactDataContext;
        public ContactDataLayer()//CMContext contactDataContext)
        {
            //this.contactDataContext = contactDataContext;
        }
        public IEnumerable<Contact> GetContacts()
        {
            CMContext contactDataContext = new CMContext();
            return contactDataContext.Contact.ToList();
        }

        public void DeleteContact(int id)
        {
            using (CMContext contactDataContext = new CMContext())
            {
                using (var transaction = contactDataContext.Database.BeginTransaction())
                {
                    var contact = contactDataContext.Contact.Find(id);
                    contact.Active = false;
                    contactDataContext.Update(contact);
                    contactDataContext.SaveChanges();
                    transaction.Commit();
                }
            }
        }

        public void EditContact(int id, Contact editedContact)
        {
            using (CMContext contactDataContext = new CMContext())
            {
                using (var transaction = contactDataContext.Database.BeginTransaction())
                {
                    var contact = contactDataContext.Contact.SingleOrDefault(x => x.Id == id);

                    contact.Active = editedContact.Active;
                    contact.ContactNumber = editedContact.ContactNumber;
                    contact.FirstName = editedContact.FirstName;
                    contact.LastName = editedContact.LastName;

                    contactDataContext.Update(contact);
                    contactDataContext.SaveChanges();
                    transaction.Commit();
                }
            }
        }

        public void CreateContact(Contact newContact)
        {
            using (CMContext contactDataContext = new CMContext())
            {
                using (var transaction = contactDataContext.Database.BeginTransaction())
                {
                    contactDataContext.Contact.Add(newContact);
                    contactDataContext.SaveChanges();
                    transaction.Commit();
                }
            }
        }

    }
}
