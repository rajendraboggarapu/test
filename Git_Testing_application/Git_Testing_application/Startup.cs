using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Git_Testing_application.Startup))]
namespace Git_Testing_application
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
