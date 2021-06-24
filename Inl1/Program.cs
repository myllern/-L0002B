using System;
using System.Collections.Generic;

namespace OU1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // skapar ett obj
                Cashier c = new Cashier();
                // kör obj
                c.init();
            }
        }


        public class Cashier
        {
            // skapar var
            int sum;
            int deposit;
            int price;
            int number_val;

            public void init()
            {

                // läser in värden 
                Console.WriteLine("Ange pris :");
                this.price = int.Parse(Console.ReadLine());

                Console.WriteLine("Ange hur mycket du har betalat :");
                int deposit = int.Parse(Console.ReadLine());

                sum = deposit - price;


                // om sum > 0, skriv ut den som metoden gör, alltså printar hur mång av valören som ska tillbaka
                if (sum > 0)
                {

                    List<int> list = new List<int>();
                    list.Add(500);
                    list.Add(100);
                    list.Add(50);
                    list.Add(10);
                    list.Add(5);
                    list.Add(1);

                    Console.WriteLine($"Växel tillbaka: {sum} kr");


                    foreach (int item in list)
                    {
                        nrOfBills(item);
                            if (number_val > 0)
                            { 
                                Console.WriteLine(nrOfBills(item)); 
                            }

                    }

                }
                // ganska självbeskrivande
                if (sum == 0)
                {
                    Console.WriteLine("Allt betalt");
                    Console.WriteLine("\n--------------------------------------------------------\n");
                    return;
                }
                else
                {
                                    // ganska självbeskrivande
                    sum = deposit - price;
                    Console.WriteLine("Ej tillräcklig betalning... ");
                    Console.WriteLine("\n--------------------------------------------------------\n");

                    return;
                }

            }

            // tar in valören som skall printas.
            public String nrOfBills(int val)
            {
                
                String s = $"{val} valör tillbaka: {number_val}";
                number_val = (sum - sum % val) / val;
                sum = sum % val;
                return s;
            }

        }
    }
}





