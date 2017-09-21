using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppsTestAnwendung.Startup))]
namespace WebAppsTestAnwendung
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
