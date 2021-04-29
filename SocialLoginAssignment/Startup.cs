using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SocialLoginAssignment.Startup))]
namespace SocialLoginAssignment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
