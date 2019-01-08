using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VideoManagement.Startup))]
namespace VideoManagement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
