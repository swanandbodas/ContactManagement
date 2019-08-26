using ContactManagement.Controllers;
using DataLayer;
using DataLayer.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace ContentManagement.Test
{
    [TestClass]
    public class ContactControllerTest
    {
        Moq.Mock<IContactDataRepository> dataRepository;
        ContactController contactController;

        [TestInitialize]
        public void SetUp()
        {
            dataRepository = new Mock<IContactDataRepository>();
            contactController = new ContactController(dataRepository.Object);

        }

        [TestMethod]
        public void GetAllContactsTest()
        {
            dataRepository.Setup(o=>o.GetContacts()).Returns(new Contact[] { new Contact {Id=2, Active=false }, new Contact { Id=3, Active=true} });

            var actualResult = contactController.GetContacts();

            Equals(actualResult, dataRepository.Object);
        }

        [TestMethod]
        public void GetByIdTest()
        {
            dataRepository.Setup(o => o.GetContact(2)).Returns(new Contact { Id = 2, Active = false });

            var actualResult = contactController.Get(2);

            Equals(actualResult, dataRepository.Object);
        }

        [TestMethod]
        public void GetByIdTestFailure()
        {
            Contact expectedResult = null;
            dataRepository.Setup(o => o.GetContact(1)).Returns(expectedResult);

            var actualResult = contactController.Get(1);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void DeleteByIdTest()
        {
            var expectedResult = 1;
            dataRepository.Setup(o => o.DeleteContact(2)).Returns(expectedResult);

            var actualResult = contactController.DeleteContact(2);

            Assert.AreEqual(expectedResult, actualResult); 
        }

        [TestMethod]
        public void DeleteByIdTestFailure()
        {
            var expectedResult = 0;
            dataRepository.Setup(o => o.DeleteContact(1)).Returns(expectedResult);

            var actualResult = contactController.DeleteContact(1);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
