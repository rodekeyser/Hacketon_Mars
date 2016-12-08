using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MarsHacketon.Startup))]
namespace MarsHacketon
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
