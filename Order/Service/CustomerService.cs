using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Service
{
    public class CustomerService
    {
        private readonly IOrder _order;

        public IOrder order { get; set; }

        public CustomerService(){}

        public CustomerService (IOrder order)
        {
            _order = order;
        }

        public void ConstructorRun()
        {
            Console.WriteLine(_order.MainMeal());
            Console.WriteLine(_order.Dessert());
            Console.WriteLine(_order.Drinks());
        }

        public void PropertyRun()
        {
            Console.WriteLine(order.MainMeal());
            Console.WriteLine(order.Dessert());
            Console.WriteLine(order.Drinks());
        }

        public void MethodRun(IOrder order)
        {
            Console.WriteLine(order.MainMeal());
            Console.WriteLine(order.Dessert());
            Console.WriteLine(order.Drinks());
        }
    }
}
