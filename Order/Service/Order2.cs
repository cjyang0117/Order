using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Service
{
    public class Order2 : IOrder
    {
        public string MainMeal()
        {
            return "牛排";
        }
        public string Dessert()
        {
            return "餅乾";
        }
        public string Drinks()
        {
            return "雪碧";
        }
    }
}
