using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PurchageSystem.Startup))]
namespace PurchageSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
