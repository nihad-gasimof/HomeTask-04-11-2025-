using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeee
{
    internal struct Item : ITradable, IUsable
    {
      
        public string Name { get; set; }
        public string Type{ get; set; }
        public int Value {  get; set; }
        public bool IsUsed { get; set; }
        public Item(string Name, string Type, int Value, bool IsUsed)
        {
            this.Name = Name;
            this.Type = Type;
            this.Value = Value;
            this.IsUsed = IsUsed;
            GameStats.RegisterItem(this);
        }
        public void Trade()
        {
            Console.WriteLine("Esyanin qiymeti ile alver edilib");
        }

        public void Use()
        {
            IsUsed = true;
            Console.WriteLine("Esya istifade olunub");
        }
       
    }
}
