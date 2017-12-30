using CrmSystem.Data.Repository;
using CrmSystem.Models;
using CrmSystem.Server.Controllers;
using CrmSystem.Tests.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Web.Http.Results;

namespace CrmSystem.Tests
{
    [TestClass]
    public class CompaniesControllerTest
    {
        private readonly IUnitOfWork data;
        private CustomersController controller;

        public CompaniesControllerTest() :
            this(new MockIUnitOfWork())
        {
        }

        public CompaniesControllerTest(IUnitOfWorkMock dataMock)
        {
            this.data = dataMock.Data;
        }

        [TestInitialize]
        public void CreateController()
        {
            this.controller = new CustomersController(this.data);
        }

        [TestMethod]
        public void GetAllCustomers_ShouldReturnAllCustomers()
        {
            var result = controller.AllCustomers() as OkNegotiatedContentResult<List<Customer>>;
            Assert.AreEqual(4, result.Content.Count);
        }

        [TestMethod]
        public void GetCustomer_ShouldReturnCorrectCustomer()
        {
            var result = controller.GetCustomerById(1) as OkNegotiatedContentResult<Customer>;
            Assert.IsNotNull(result);
            Assert.AreEqual(data.Customers.GetById(1).Name = "Asya", result.Content.Name = "Asya");
        }
    }
}
