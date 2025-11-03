using System;

namespace Homeee
{
    internal class Inventory
    {
        private Item[] _items =new Item[10];

        public Item this[int index]
        {
            get
            {
               return _items[index];
            }
            set
            {
                _items[index] = value;
            }
            }
        public int Count => _items.Length;

        public Inventory(Item[] items)
        {
            _items = items;
        }

        public Inventory()
        {
        }

        public void ShowAll()
        {
            foreach (var item in _items)
            {
                Console.WriteLine($"Name: {item.Name}, Type: {item.Type}, Price: {item.Value}, IsUsed: {item.IsUsed}");
            }
        }
    }
}
