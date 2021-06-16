using System;

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

        public salesInfo(){
            
        }
    }
}


