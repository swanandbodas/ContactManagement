﻿using DataLayer.Models;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer
{
    public class ContactDataRepository : IContactDataRepository
    {
        public IEnumerable<Contact> GetContacts()
        {
            CMContext contactDataContext = new CMContext();
            return contactDataContext.Contact.ToList();
        }

        public int DeleteContact(int id)
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

                    return contact != null ? 1 : 0;
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

        public Contact GetContact(int id)
        {
            return GetContacts()?.Where(c => c.Id == id)?.FirstOrDefault<Contact>();
        }
    }
}
