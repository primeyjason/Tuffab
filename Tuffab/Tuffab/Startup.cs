using Microsoft.Owin;
using Owin;
using TuffabLibrary;

[assembly: OwinStartupAttribute(typeof(Tuffab.Startup))]
namespace Tuffab
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {

            /*    EmailProvider.Send("jason.g.jones.81@gmail.com",
                    "subject",
                    "test",
                    senderEmail: "me@Me.com");
                    */


            
            ConfigureAuth(app);
        }
    }
}
