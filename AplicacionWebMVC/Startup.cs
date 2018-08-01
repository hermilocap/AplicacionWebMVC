using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AplicacionWebMVC.Startup))]
namespace AplicacionWebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
