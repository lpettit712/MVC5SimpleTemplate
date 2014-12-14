using Microsoft.Owin;
using Owin;
using Site;

[assembly: OwinStartup(typeof(Startup))]
namespace Site
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
