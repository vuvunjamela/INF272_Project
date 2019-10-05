using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NewProject_272.Startup))]
namespace NewProject_272
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
