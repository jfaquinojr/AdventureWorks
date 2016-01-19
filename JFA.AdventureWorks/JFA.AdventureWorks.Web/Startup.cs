using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JFA.AdventureWorks.Web.Startup))]
namespace JFA.AdventureWorks.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
