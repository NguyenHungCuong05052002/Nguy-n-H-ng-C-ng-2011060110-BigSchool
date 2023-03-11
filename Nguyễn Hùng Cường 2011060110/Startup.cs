using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Nguyễn_Hùng_Cường_2011060110.Startup))]
namespace Nguyễn_Hùng_Cường_2011060110
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
