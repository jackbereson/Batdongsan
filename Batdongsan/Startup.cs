using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Batdongsan.Startup))]
namespace Batdongsan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
