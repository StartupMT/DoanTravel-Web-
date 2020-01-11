using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Airbnb.Startup))]
namespace Airbnb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
