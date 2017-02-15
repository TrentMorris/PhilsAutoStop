using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PhilsAutoStop.Startup))]
namespace PhilsAutoStop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
