using System;
using System.Collections.Generic;

namespace Inl2
{
    public class Display
    {
        public Display() { }



        public int MainMenue()
        {
            Console.WriteLine("\n1 - Lägg till säljare");
            Console.WriteLine("2 - Information om säljare");
            Console.WriteLine("3 - Avsluta program\n");

            Console.WriteLine("Välj ett alternativ:\n");

            return int.Parse(Console.ReadLine());
        }

        public string[] addPerson()
        {
            string[] p = new string[4];
            Console.WriteLine("Namn:");
            p[0] = Console.ReadLine();
            Console.WriteLine("Personnummer:");
            p[1] = Console.ReadLine();
            Console.WriteLine("Distrikt:");
            p[2] = Console.ReadLine();
            Console.WriteLine("Artiklar sålda:");
            p[3] = Console.ReadLine();
            return p;
        }

        public void SalesInfo(List<Person> G1, List<Person> G2, List<Person> G3, List<Person> G4)
        {
                        Console.WriteLine("\nNamn   Persnr   Distrikt    Antal\n");

                        foreach (var person in G1)
                        {
                               Console.WriteLine($"{person.Name}   {person.PersonNr}   {person.Distrikt}   {person.Antal}");
                        }
                        Console.WriteLine($"{G1.Count} säljare har nått nivå 1: under 50 artiklar\n");
                        foreach (var person in G2)
                        {
                               Console.WriteLine($"{person.Name}   {person.PersonNr}   {person.Distrikt}   {person.Antal}");
                        }
                        Console.WriteLine($"{G2.Count} säljare har nått nivå 2: 50 - 99 artiklar\n");
                        foreach (var person in G3)
                        {
                           Console.WriteLine($"{person.Name}   {person.PersonNr}   {person.Distrikt}   {person.Antal}");
                        }
                        Console.WriteLine($"{G3.Count} säljare har nått nivå 3: 100 - 199 artiklar\n");
                        foreach (var person in G4)
                        {
                               Console.WriteLine($"{person.Name}   {person.PersonNr}   {person.Distrikt}   {person.Antal}");
                        }
                        Console.WriteLine($"{G4.Count} säljare har nått nivå 4: Fler än artiklar\n");
        }
    }
}


