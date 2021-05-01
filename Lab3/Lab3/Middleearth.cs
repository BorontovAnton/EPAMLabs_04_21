using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_OOP
{
    abstract class Middleearth
    {
        public string race;
        public string region;
        public string name;
        public int kills;
        public string weapon;

        public abstract string battlecry();         //абстрактный метод выводит боевой клич для рассы
       
        public void Affiliation()                   //Метод выводит параметры рассы
        {
            Console.WriteLine($"Расса: {race}, Регион: {region}, Имя: {name}, Убийств: {kills}, Оружие: {weapon}");
        }

    }
}
