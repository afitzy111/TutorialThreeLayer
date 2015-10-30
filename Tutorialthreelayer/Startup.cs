using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tutorialthreelayer.Startup))]
namespace Tutorialthreelayer
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
