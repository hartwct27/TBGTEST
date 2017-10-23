using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TBGTEST.Startup))]
namespace TBGTEST
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
