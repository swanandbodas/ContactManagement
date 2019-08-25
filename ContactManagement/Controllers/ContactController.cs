using DataLayer;
using DataLayer.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ContactManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private IContactDataLayer contactDataLayer;

        public ContactController(IContactDataLayer contactDataLayer)
        {
            this.contactDataLayer = contactDataLayer;
        }

        // GET api/contact
        [HttpGet]
        public IEnumerable<Contact> GetContacts()
        {
            return contactDataLayer.GetContacts();
        }

        //// GET api/contact/5
        //[HttpGet("{id}")]
        //public ActionResult<string> Get(int id)
        //{
        //    return "value";
        //}

        // Delete api/contact/<id>
        [HttpDelete("{id}")]
        public void DeleteContact(int id)
        {
            contactDataLayer.DeleteContact(id);
        }

        // PUT api/contact/5
        [HttpPut("{id}")]
        public void EditContact(int id, [FromBody] Contact editedContact)
        {
            contactDataLayer.EditContact(id, editedContact);
        }

        // DELETE api/contact/5
        [HttpPost]
        public void CreateContact([FromBody]Contact newContact)
        {
            contactDataLayer.CreateContact(newContact);
        }
    }
}
