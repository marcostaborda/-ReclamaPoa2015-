using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReclamaPoa2015.Startup))]
namespace ReclamaPoa2015
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
