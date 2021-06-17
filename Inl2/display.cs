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

            Console.WriteLine("Välj ett alternativ:");

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

        public void salesInfo(List<Person> G1, List<Person> G2, List<Person> G3, List<String> G4)
        {
            Console.WriteLine("Namn  Persnr Distrikt Antal");
            foreach (var person in G1)
            {
                Console.WriteLine(String.Format("{0} {1} {2} {3} {4}", person.Name, person.PersonNr, person.Distrikt, person.Antal));
            }
            Console.WriteLine($"{G1.Count} säljare har nått nivå 1: under 50 artiklar");
            foreach (var person in G1)
            {
                Console.WriteLine(String.Format("{0} {1} {2} {3} {4}", person.Name, person.PersonNr, person.Distrikt, person.Antal));
            }
            Console.WriteLine($"{G1.Count} säljare har nått nivå 2: 50 - 99 artiklar");
            foreach (var person in G1)
            {
                Console.WriteLine(String.Format("{0} {1} {2} {3} {4}", person.Name, person.PersonNr, person.Distrikt, person.Antal));
            }
            Console.WriteLine($"{G1.Count} säljare har nått nivå 3: 100 - 199 artiklar");
            foreach (var person in G1)
            {
                Console.WriteLine(String.Format("{0} {1} {2} {3} {4}", person.Name, person.PersonNr, person.Distrikt, person.Antal));
            }
            Console.WriteLine($"{G1.Count} säljare har nått nivå 4: över 199 artiklar");
        }
    }
}


