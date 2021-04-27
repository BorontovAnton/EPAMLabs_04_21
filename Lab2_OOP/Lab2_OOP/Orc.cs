using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_OOP
{
    class Orc : Middleearth
    {
        public int kills; 
        public int Humans { get; set; }
        public int Gnoms { get; set; }
        public int Elfs { get; set; }
        public Orc(string race, string region, string weapon, int humans, int gnoms, int elfs) : base(race, region, weapon)
        {
            kills = humans+gnoms+elfs;
        }
       
        public override string battlecry()
        {
            return "Waaagh";
        }
    }
}
