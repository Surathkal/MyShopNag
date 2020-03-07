using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyShopNag.WebUI.Startup))]
namespace MyShopNag.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
