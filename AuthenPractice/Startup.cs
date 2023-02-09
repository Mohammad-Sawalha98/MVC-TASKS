using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AuthenPractice.Startup))]
namespace AuthenPractice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
