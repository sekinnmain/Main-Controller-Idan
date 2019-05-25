using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace code_1
{
    class dish
    {
        public string DishName;
        public float DishPrice;
        public int DishSize;
        public string DishDescripation;

       public dish(string dishname,float dishprice,int dishSize,string dishDescripation)
        {
           DishName = dishname;
            DishPrice = dishprice;
            DishSize = dishSize;
            DishDescripation = dishDescripation;
        }
        public string getDishName()
        {
            return DishName;
        }
        public float getPrice(String DishName, int DishSize)
        {
            return DishPrice;
        }
        public int getDishSize(String DishName)
        {
            return DishSize;  
        }
        public string getDishDescripation(String name)
        {
            return DishDescripation;
        }
    }
}
