using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Escuela_Fausto_Herrera_Cordero.Startup))]
namespace Escuela_Fausto_Herrera_Cordero
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
