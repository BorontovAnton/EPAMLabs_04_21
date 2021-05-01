using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Collections.Concurrent;
using System.Linq;

namespace Lab2_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                             
                List<Middleearth> x = new List<Middleearth>();
                x.Add(new Gnome() { race = "Гном", region = "Одинокая гора", weapon = "Топор", name = "Гимли", kills = 135 });
                x.Add(new Gnome() { race = "Гном", region = "Эрибор", weapon = "Секира", name = "Балин", kills = 56 });
                x.Add(new Gnome() { race = "Гном", region = "Эрид Метрин", weapon = "Молот", name = "Торин", kills = 67 });
                x.Add(new Orc() { race = "Орк", region = "Мордор", weapon = "Ятаган", name = "Озог", kills = 211 });

                x = x.OrderBy(e => e.kills).ToList(); //Сортировка по увеличению убиств

                foreach (var el in x)
                {
                    el.Affiliation();
                }
            }

            catch (FormatException e)
            {
                Console.WriteLine($"Что-то пошло не так {e.Message}");
            }


        }
    }
}