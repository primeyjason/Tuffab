using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tuffab.Startup))]
namespace Tuffab
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
