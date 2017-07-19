using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BanducciWeb.Startup))]
namespace BanducciWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
