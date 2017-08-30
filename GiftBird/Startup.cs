using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GiftBird.Startup))]
namespace GiftBird
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
