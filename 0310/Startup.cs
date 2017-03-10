using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_0310.Startup))]
namespace _0310
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
