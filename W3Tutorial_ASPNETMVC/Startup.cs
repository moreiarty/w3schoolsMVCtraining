using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(W3Tutorial_ASPNETMVC.Startup))]
namespace W3Tutorial_ASPNETMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
