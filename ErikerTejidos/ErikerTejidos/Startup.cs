using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ErikerTejidos.Startup))]
namespace ErikerTejidos
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
