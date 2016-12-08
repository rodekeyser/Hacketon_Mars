using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hacketon.Startup))]
namespace Hacketon
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
