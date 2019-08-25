using DataLayer.Models;
using System.Collections.Generic;
//using DataEntities;

namespace DataLayer
{
    public interface IContactRepository
    {
        IList<Contact> GetContacts();
    }
}