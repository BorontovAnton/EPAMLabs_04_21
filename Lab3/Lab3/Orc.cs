using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_OOP
{
    class Orc : Middleearth
    {
        public int totalkills;
        public int Humans { get; set; }
        public int Gnoms   { get; set; }
        public int Elfs { get; set; }
        public Orc () 
        {
            this.totalkills = Humans + Gnoms + Elfs;
        }
        
        public override string battlecry()
        {
            return "Waaagh";
        }
    }
}

