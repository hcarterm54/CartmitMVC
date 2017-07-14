using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CartmitMVC.Startup))]
namespace CartmitMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}