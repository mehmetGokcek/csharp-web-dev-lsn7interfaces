using System;
using System.Collections.Generic;

namespace IceCreamShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Case menu = new Case();
            List<Flavor> availableFlavors = menu.Flavors;
            List<Cone> availableCones = menu.Cones;

            // TODO: Use a Comparer class to sort the 'flavors' array alphabetically by the 'name'
            //  field.
            availableFlavors.Sort(new Comparer());

            // TODO: Use a Comparator class to sort the 'cones' array in increasing order by the 'cost'
            //  field.
            availableCones.Sort(new Comparator());

            // TODO: Print the 'flavors' and 'cones' lists (in a clear manner) to verify the sorting.

            Console.WriteLine("****************Printing Flavors Array Sorted by Name*****************");
            foreach (Flavor item in availableFlavors)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("                                                                    ");
            Console.WriteLine("****************Printing Cones Array Sorted by Cost*****************");
            foreach (Cone item in availableCones)
            {
                Console.WriteLine(item);
            }

        }
    }
}
