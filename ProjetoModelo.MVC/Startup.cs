using Microsoft.Owin;
using Owin;
using ProjetoModelo.MVC;

[assembly: OwinStartup(typeof(Startup))]
namespace ProjetoModelo.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}