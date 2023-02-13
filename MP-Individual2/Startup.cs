using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MP_Individual2.Startup))]
namespace MP_Individual2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
