using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EKGADGET.Backend.Startup))]
namespace EKGADGET.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
