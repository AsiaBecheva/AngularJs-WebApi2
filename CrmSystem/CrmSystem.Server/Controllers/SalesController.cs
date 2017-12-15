using CrmSystem.Data.Repository;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace CrmSystem.Server.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class SalesController : BaseController
    {
        public SalesController(IUnitOfWork data) : base(data)
        {
        }

        [HttpGet]
        public IHttpActionResult AllSales()
        {
            var sales = this.data
                .Sales
                .All()
                .ToList();

            return this.Ok(sales);
        }
    }
}
