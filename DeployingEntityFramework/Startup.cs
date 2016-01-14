using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DeployingEntityFramework.Startup))]
namespace DeployingEntityFramework
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
