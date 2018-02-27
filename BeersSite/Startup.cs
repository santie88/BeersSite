using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BeersSite.Startup))]
namespace BeersSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
