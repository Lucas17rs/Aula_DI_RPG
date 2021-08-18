using System;
using Aula_DI_RPG.src.Entities;

namespace Aula_DI_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23 ,"kinght");
            Wizard wizard = new Wizard("Jennica", 23 ,"White Wizard");
            Ninja ninja = new Ninja ("Wedge", 25, "Ninja");

            Console.WriteLine(arus);
            Console.WriteLine(wizard);
            Console.WriteLine(ninja);

            Console.WriteLine(arus.Attack());
            Console.WriteLine(wizard.Attack());
            Console.WriteLine(ninja.Attack());

            Console.WriteLine(arus.Attack(7));
            Console.WriteLine(wizard.Attack(1));
            Console.WriteLine(ninja.Attack(10));

            Console.WriteLine(ninja.LevelUp());


            

        }
    }
}
