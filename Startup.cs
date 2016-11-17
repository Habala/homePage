using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LeHömePage.Startup))]
namespace LeHömePage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
