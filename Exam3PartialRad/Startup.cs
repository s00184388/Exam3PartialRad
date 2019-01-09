using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Exam3PartialRad.Startup))]
namespace Exam3PartialRad
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
