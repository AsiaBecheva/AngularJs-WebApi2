using CrmSystem.Data.Repository;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace CrmSystem.Server.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ProjectsController : BaseController
    {
        public ProjectsController(IUnitOfWork data) : base(data)
        {
        }

        [HttpGet]
        public IHttpActionResult AllProjects()
        {
            var projects = this.data
                .Products
                .All()
                .ToList();

            return this.Ok(projects);
        }
    }
}
