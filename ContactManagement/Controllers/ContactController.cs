using DataLayer;
using DataLayer.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net.Http;

namespace ContactManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private IContactDataRepository contactDataRepository;

        public ContactController(IContactDataRepository contactDataRepository)
        {
            this.contactDataRepository = contactDataRepository;
        }

        // GET api/contact
        [HttpGet]
        public IEnumerable<Contact> GetContacts()
        {
            return contactDataRepository.GetContacts();
        }

        // GET api/contact/5
        [HttpGet("{id}")]
        public Contact Get(int id)
        {
            return contactDataRepository.GetContact(id);
        }

        // Delete api/contact/<id>
        [HttpDelete("{id}")]
        public int DeleteContact(int id)
        {
            return contactDataRepository.DeleteContact(id);
        }

        // PUT api/contact/5
        [HttpPut("{id}")]
        public void EditContact(int id, [FromBody] Contact editedContact)
        {
            contactDataRepository.EditContact(id, editedContact);
        }

        // POST api/contact
        [HttpPost]
        public void CreateContact([FromBody]Contact newContact)
        {
            contactDataRepository.CreateContact(newContact);
        }
    }
}
