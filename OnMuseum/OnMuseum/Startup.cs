using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnMuseum.Startup))]
namespace OnMuseum
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
