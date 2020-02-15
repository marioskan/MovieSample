using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovieSample.Startup))]
namespace MovieSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
