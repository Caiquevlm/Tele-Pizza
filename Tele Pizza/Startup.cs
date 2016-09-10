using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tele_Pizza.Startup))]
namespace Tele_Pizza
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
