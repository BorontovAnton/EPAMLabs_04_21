using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_OOP
{
    abstract class Middleearth
    {
        public string Race { get; set; }
        public string Region { get; set; }
        public string Weapon { get; set; }

        public abstract string battlecry();         //абстрактный метод выводит боевой клич для рассы
        public Middleearth(string race, string region, string weapon)

        {
            Race = race;
            Region = region;
            Weapon = weapon;
        }

        public void Affiliation()                   //Метод выводит параметры рассы
        {
            Console.WriteLine(Race);
            Console.WriteLine(Region);
            Console.WriteLine(Weapon);
        }

    }
}
