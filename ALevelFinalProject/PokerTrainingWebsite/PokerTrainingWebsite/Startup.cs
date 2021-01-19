using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PokerTrainingWebsite.Startup))]
namespace PokerTrainingWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
