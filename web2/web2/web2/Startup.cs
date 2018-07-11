using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(web2.Startup))]
namespace web2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
