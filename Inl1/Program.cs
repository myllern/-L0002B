using System;

namespace OU1
{
    class Program
    {
        static void Main(string[] args)
        {
            

//TODO ändra texterna 
                Console.WriteLine("Ange pris :");
                int price = int.Parse(Console.ReadLine());

                Console.WriteLine("ange hur mycket du har betalat :");
                int deposit = int.Parse(Console.ReadLine());
                
                int sum = deposit - price;

                sum = price - deposit;
                if (sum > 0)
                {
                    Console.WriteLine($"Växel tillbaka: {sum}"
                    );
                    Console.WriteLine(nrOfBills(500, sum));
                    Console.WriteLine(nrOfBills(100, sum));
                    Console.WriteLine(nrOfBills(50, sum));
                    Console.WriteLine(nrOfBills(20, sum));
                    Console.WriteLine(nrOfBills(10, sum));
                    Console.WriteLine(nrOfBills(5, sum));
                    Console.WriteLine(nrOfBills(1, sum));
                    
                    Console.ReadLine();

                }

                if (sum == 0)
                {
                    Console.WriteLine("Allt betalt");
                }
                else
                {
                    sum = deposit - price;
                    Console.WriteLine("Ej tillräcklig betalning... ");
                }
                //TODO: Fixa sum så den minskaar eller nått   
            }
            public static String nrOfBills(int val, int sum)
                {
                    String s = $"{(sum - sum % val) / val} lappar:";
                    sum = sum % val;
                    return s;
                }
        }
    }

