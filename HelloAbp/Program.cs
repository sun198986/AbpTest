using System;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp;

namespace HelloAbp
{
    /// <summary>
    /// 每个模块注册的服务,其实都注册到了全局容器中
    /// 模块也分为两种类型
    /// 1.应用程序模块
    /// 2.框架模块 缓存日志 中间件
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //工厂手动创建模块
            var app = AbpApplicationFactory.Create<HelloAbpModule>();
            //初始化模块
            app.Initialize();
            //使用abp的依赖服务
            var service = app.ServiceProvider.GetService<HelloService>();
            //调用服务方法
            service.Run();

            Console.ReadKey();
        }
    }
}
