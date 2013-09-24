using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC5_Bootstrap2.Startup))]
namespace MVC5_Bootstrap2
{
    public partial class Startup 
    {
        public void Configuration(IAppBuilder app) 
        {
            ConfigureAuth(app);
        }
    }
}
