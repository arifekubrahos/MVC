using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Araba_Kirala.Startup))]
namespace Araba_Kirala
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
