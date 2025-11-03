using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeee
{
    internal static class ExtensionMethod
    {
        public static void IsRare(this Item item)
        {
            if (item.Value >= 100)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

    }
}
