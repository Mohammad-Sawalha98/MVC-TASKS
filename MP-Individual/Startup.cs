using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MP_Individual.Startup))]
namespace MP_Individual
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
