using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReservasHotel.Presentacion.Startup))]
namespace ReservasHotel.Presentacion
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
