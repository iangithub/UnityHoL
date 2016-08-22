using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication15.Startup))]
namespace WebApplication15
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
