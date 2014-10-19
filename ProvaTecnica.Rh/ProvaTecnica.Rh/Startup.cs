using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProvaTecnica.Rh.Startup))]
namespace ProvaTecnica.Rh
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
