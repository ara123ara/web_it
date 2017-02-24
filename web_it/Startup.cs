using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(web_it.Startup))]
namespace web_it
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
