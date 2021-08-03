using System;
using Volo.Abp.DependencyInjection;

namespace HelloAbp
{
    public class HelloService:IScopedDependency
    {
        public void Run()
        {
            Console.WriteLine("hello world1");
        }
    }
}