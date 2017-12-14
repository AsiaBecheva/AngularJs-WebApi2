using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(CrmSystem.Server.Startup))]

namespace CrmSystem.Server
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
