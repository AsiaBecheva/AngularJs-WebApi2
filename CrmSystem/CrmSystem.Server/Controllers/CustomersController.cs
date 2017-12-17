using CrmSystem.Data.Repository;
using CrmSystem.Models;
using CrmSystem.Server.Models;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace CrmSystem.Server.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [Authorize]
    public class CustomersController : BaseController
    {
        public CustomersController(IUnitOfWork data) : base(data)
        {
        }

        [HttpGet]
        public IHttpActionResult AllCustomers()
        {
            var customers = this.data
                .Customers
                .All()
                .OrderBy(x => x.Name)
                .ToList();

            return Ok(customers);
        }

        [HttpGet]
        public IHttpActionResult GetCustomerById(int id)
        {
            var customer = this.data
                .Customers
                .GetById(id);

            return this.Ok(customer);
        }

        [HttpPost]
        public IHttpActionResult AddCustomer([FromBody]CustomerBindingModel model)
        {
            if (ModelState.IsValid && model != null)
            {
                var customer = new Customer
                {
                    Email = model.Email,
                    Info = model.Info,
                    Name = model.Name,
                    Phone = model.Phone,
                    Projects = model.Projects
                };

                this.data.Customers.Add(customer);
                this.data.SaveChanges();

                return this.Ok(customer.Name + " was created!");
            }


            return this.BadRequest("Invalid data!");
        }

        [HttpDelete]
        public IHttpActionResult DeleteCustomer(int id)
        {
            var getCustomerById = this.data
                .Customers
                .GetById(id);

            this.data
                .Customers
                .Delete(getCustomerById);

            this.data.SaveChanges();

            return this.Ok("Customer was deleted!");
        }
    }
}
