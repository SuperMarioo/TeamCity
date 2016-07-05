using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MarioApp.Startup))]
namespace MarioApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
