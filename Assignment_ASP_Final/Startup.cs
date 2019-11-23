using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assignment_ASP_Final.Startup))]
namespace Assignment_ASP_Final
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
