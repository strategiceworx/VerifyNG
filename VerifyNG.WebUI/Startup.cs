using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VerifyNG.WebUI.Startup))]
namespace VerifyNG.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
