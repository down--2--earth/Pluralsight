using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(front_end_web_app_html5_javascript_css.Startup))]
namespace front_end_web_app_html5_javascript_css
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
