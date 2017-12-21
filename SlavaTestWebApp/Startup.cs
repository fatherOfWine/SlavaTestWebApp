using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SlavaTestWebApp.Startup))]
namespace SlavaTestWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
