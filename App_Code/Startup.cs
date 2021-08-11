using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mystery_code__blog_9.Startup))]
namespace mystery_code__blog_9
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
