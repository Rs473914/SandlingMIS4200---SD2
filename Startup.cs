using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SandlingMIS4200.Startup))]
namespace SandlingMIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
