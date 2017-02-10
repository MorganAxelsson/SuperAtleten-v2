using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SuperAtleten2.Startup))]
namespace SuperAtleten2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
