using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlinePractice.Startup))]
namespace OnlinePractice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
