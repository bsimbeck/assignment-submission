using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assignment_Submission_Tool.Startup))]
namespace Assignment_Submission_Tool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
