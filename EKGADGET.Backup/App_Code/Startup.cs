using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EKGADGET.Backup.Startup))]
namespace EKGADGET.Backup
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
