using System;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp;

namespace HelloAbp
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = AbpApplicationFactory.Create<HelloAbpModule>();
            app.Initialize();

            var service = app.ServiceProvider.GetService<HelloService>();
            service.Run();

            Console.ReadKey();
        }
    }
}
