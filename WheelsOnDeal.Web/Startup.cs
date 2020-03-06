using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WheelsOnDeal.Web.Startup))]
namespace WheelsOnDeal.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
