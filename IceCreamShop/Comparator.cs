using System;
using System.Collections.Generic;
using System.Text;

namespace IceCreamShop
{
    class Comparator : IComparer<Ingredient>
    {
        public int Compare(Ingredient x, Ingredient y)
        {
                return x.Cost.CompareTo(y.Cost);
        }


    }
}
