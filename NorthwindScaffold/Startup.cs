using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NorthwindScaffold.Startup))]
namespace NorthwindScaffold
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
