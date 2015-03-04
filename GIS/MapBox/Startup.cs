using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MapBox.Startup))]
namespace MapBox
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
