using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Task_8_Feb.Startup))]
namespace Task_8_Feb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
