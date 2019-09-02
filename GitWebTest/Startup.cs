using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitWebTest.Startup))]
namespace GitWebTest
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
