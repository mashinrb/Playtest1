using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InnovativeSecurityManagement.WebUI.Startup))]
namespace InnovativeSecurityManagement.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
