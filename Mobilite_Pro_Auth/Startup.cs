using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mobilite_Pro_Auth.Startup))]
namespace Mobilite_Pro_Auth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
