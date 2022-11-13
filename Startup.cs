using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Komis.Startup))]
namespace Komis
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
