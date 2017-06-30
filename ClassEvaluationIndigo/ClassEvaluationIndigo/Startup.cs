using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClassEvaluationIndigo.Startup))]
namespace ClassEvaluationIndigo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
