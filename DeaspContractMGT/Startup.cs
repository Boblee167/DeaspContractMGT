using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DeaspContractMGT.Startup))]
namespace DeaspContractMGT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
