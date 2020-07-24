using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Service
{
    public class Order1 : IOrder
    {
        public string MainMeal()
        {
            return "漢堡";
        }
        public string Dessert()
        {
            return "蛋糕";
        }
        public string Drinks()
        {
            return "可樂";
        }
    }
}
