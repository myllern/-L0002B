using System;

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
                
                    Console.WriteLine($"Växel tillbaka: {sum} kr"
                    );

                    Console.WriteLine(nrOfBills(500));
                    Console.WriteLine(nrOfBills(100));
                    Console.WriteLine(nrOfBills(50));
                    Console.WriteLine(nrOfBills(20));
                    Console.WriteLine(nrOfBills(10));
                    Console.WriteLine(nrOfBills(5));
                    Console.WriteLine(nrOfBills(1));


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
                String s = $"{val} valör tillbaka: {(sum - sum % val) / val}";
                sum = sum % val;
                return s;
            }

        }
    }
}





