using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(handlingErrorPractice.Startup))]
namespace handlingErrorPractice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
