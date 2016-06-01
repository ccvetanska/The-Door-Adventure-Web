using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TheDoorAdventure.Web.Startup))]
namespace TheDoorAdventure.Web
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
