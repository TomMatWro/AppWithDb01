using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppWithDb01.Startup))]
namespace AppWithDb01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
