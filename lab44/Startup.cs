using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lab44.Startup))]
namespace lab44
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
