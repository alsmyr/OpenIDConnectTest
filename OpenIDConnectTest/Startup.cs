using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OpenIDConnectTest.Startup))]
namespace OpenIDConnectTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
