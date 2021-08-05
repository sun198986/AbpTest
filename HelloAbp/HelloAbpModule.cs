using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace HelloAbp
{
    public class HelloAbpModule:AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            base.ConfigureServices(context);
            context.Services.AddScoped <HelloService>();
        }

        public HelloAbpModule()
        {
            
        }
    }
}