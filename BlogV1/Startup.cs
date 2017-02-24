using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BlogV1.Startup))]
namespace BlogV1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
