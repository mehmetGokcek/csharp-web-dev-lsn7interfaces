using System;
using System.Collections.Generic;
using System.Text;

namespace IceCreamShop
{
    public class Comparer : IComparer<Ingredient>
    {
        public int Compare(Ingredient x, Ingredient y)
        {
                return string.Compare(x.Name, y.Name);
        }

     
    }
}
