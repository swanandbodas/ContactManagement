//using DataEntities;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq;
using DataLayer.Models;

namespace DataLayer
{
    public class ContactRepository : IContactRepository
    {
        public IList<Contact> GetContacts()
        {
            CMContext contactDBContext = new CMContext();
            return contactDBContext.Contact.ToList<Contact>();
        }
    }
}
