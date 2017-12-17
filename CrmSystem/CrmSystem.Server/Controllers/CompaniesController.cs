using CrmSystem.Data.Repository;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace CrmSystem.Server.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [Authorize]
    public class CompaniesController : BaseController
    {
        public CompaniesController(IUnitOfWork data) : base(data)
        {
        }

        [HttpGet]
        public IHttpActionResult AllCompanies()
        {
            var companies = this.data
                .Companies
                .All()
                .ToList();

            return this.Ok(companies);
        }
    }
}
