using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GigsService.Startup))]
namespace GigsService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
