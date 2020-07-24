using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Service
{
    public class Order3 : IOrder
    {
        public string MainMeal()
        {
            return "火鍋";
        }
        public string Dessert()
        {
            return "冰淇淋";
        }
        public string Drinks()
        {
            return "果汁";
        }
    }
}
