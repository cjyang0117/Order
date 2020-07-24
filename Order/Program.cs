using Order.Service;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Order
{
    class Program
    {
        static void Main(string[] args)
        {
            // 建構子注入
            var customerService = new CustomerService(new Order1());
            customerService.ConstructorRun();
            Console.WriteLine("========================================");

            // 屬性注入
            var customerService2 = new CustomerService();
            customerService2.order = new Order2();
            customerService2.PropertyRun();
            Console.WriteLine("========================================");

            // 方法注入
            var customerService3 = new CustomerService();
            customerService3.MethodRun(new Order3());
            Console.WriteLine("========================================");

            Console.ReadLine();
        }
    }
}
