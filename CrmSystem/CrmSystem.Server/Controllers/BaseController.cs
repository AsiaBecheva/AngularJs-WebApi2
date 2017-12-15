using CrmSystem.Data.Repository;
using System.Web.Http;

namespace CrmSystem.Server.Controllers
{
    public class BaseController : ApiController
    {
        protected readonly IUnitOfWork data;
        public BaseController(IUnitOfWork db)
        {
            this.data = db;
        }
    }
}
