using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AndroidToolkit.Startup))]
namespace AndroidToolkit
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
