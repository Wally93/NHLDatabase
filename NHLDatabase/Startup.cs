using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NHLDatabase.Startup))]
namespace NHLDatabase
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
