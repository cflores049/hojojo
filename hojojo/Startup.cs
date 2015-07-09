using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(hojojo.Startup))]
namespace hojojo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
