using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(inzSNMWebForms.Startup))]
namespace inzSNMWebForms
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
