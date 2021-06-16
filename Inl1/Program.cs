using System;

namespace OU1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Cashier c = new Cashier();
                c.init();
            }
        }





        public class Cashier
        {
            int sum;
            int deposit;
            int price;
            public void init()
            {

                Console.WriteLine("Ange pris :");
                this.price = int.Parse(Console.ReadLine());

                Console.WriteLine("ange hur mycket du har betalat :");
                int deposit = int.Parse(Console.ReadLine());

                sum = deposit - price;


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
                if (sum == 0)
                {
                    Console.WriteLine("Allt betalt");
                    Console.WriteLine("\n--------------------------------------------------------\n");
                    return;
                }
                else
                {
                    sum = deposit - price;
                    Console.WriteLine("Ej tillräcklig betalning... ");
                    Console.WriteLine("\n--------------------------------------------------------\n");

                    return;
                }

            }
            public String nrOfBills(int val)
            {
                String s = $"{val} valör tillbaka: {(sum - sum % val) / val}";
                sum = sum % val;
                return s;
            }

        }
    }
}





