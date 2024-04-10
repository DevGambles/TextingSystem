using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TextingSystem.Startup))]
namespace TextingSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
