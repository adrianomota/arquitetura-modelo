using System.Web.Http;
using ProjetoModelo.Application.AutoMapper;

namespace ProjetoModelo.Services.WebAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            AutoMapperConfig.RegisterMappings();
        }
    }
}
