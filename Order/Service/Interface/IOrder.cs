using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Service
{
    public interface IOrder
    {
        string MainMeal();
        string Dessert();
        string Drinks();
    }
}
