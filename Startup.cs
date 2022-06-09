using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GestiuneBileteAvion.Startup))]
namespace GestiuneBileteAvion
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
