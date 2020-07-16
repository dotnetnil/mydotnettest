using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(gitWebApplication1.Startup))]
namespace gitWebApplication1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
