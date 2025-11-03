using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeee
{


    internal static class GameStats
    {
        private static Item[] items = new Item[0];
     

        private static int count = 0;
        public static void RegisterItem(Item item)
        {
            Array.Resize(ref items, items.Length + 1);
            items[^1] = item;
            count++;
        }
        public static void ShowAllItems()
        {
            foreach (Item item in items)
            {
                Console.WriteLine($"Name:{item.Name},Type:{item.Type},Price:{item.Value},IsUsed:{item.IsUsed}");
            }
        }
        public static void TotalItems()
        {
            Console.WriteLine($"ItemCount is {count}");
        }
        public static void AverageValue()
        {
            var avarage = 0;
            foreach (Item item in items)
            {
                avarage += item.Value;
            }
            Console.WriteLine($"Ortalama deyer:{avarage / items.Length}");
        }
        public static void ShowStats()
        {
            TotalItems();
            AverageValue();
            ShowAllItems();
        }


    }
}
