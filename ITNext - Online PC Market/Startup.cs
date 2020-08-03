using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ITNext___Online_PC_Market.Startup))]
namespace ITNext___Online_PC_Market
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
