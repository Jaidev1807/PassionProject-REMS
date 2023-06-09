using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Project_REMS.Startup))]
namespace Project_REMS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
