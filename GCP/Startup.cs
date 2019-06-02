using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GCP.Startup))]
namespace GCP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
