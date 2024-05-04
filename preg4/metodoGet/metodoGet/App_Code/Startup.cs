using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(metodoGet.Startup))]
namespace metodoGet
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
