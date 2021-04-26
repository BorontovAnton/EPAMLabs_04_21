using System;

namespace Lab2_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Gnome gnome = new Gnome ("Гном", "Одинокая гора", "Топор", "Гимли", "Глоин");
            Orc orc = new Orc ("Орк", "Мордор", "Ятаган", 30, 4, 2);

            gnome.Affiliation();
            Console.WriteLine($"{gnome.Name} сын {gnome.Ancestor}а");
            Console.WriteLine($"Боевой клич = {gnome.battlecry()}");
            Console.WriteLine("-------------------");
            orc.Affiliation();
            Console.WriteLine($"Убийств на счету = {orc.kills}");
            Console.WriteLine($"Боевой клич = {orc.battlecry()}");

        }
    }
}
