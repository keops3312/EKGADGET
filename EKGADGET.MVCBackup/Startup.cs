using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EKGADGET.MVCBackup.Startup))]
namespace EKGADGET.MVCBackup
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
