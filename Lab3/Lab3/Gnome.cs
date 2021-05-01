using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_OOP
{
    class Gnome : Middleearth
    {

        public string Ancestor { get; set; }
        public string Name { get; set; }
        public Gnome() { }
        
      
        public override string battlecry()
        {
            return "За короля под горой";
        }

    }
}