using System;

namespace OU1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                // introducerar variablar pris,betalat ,summa och indata
                int pris;
                int betalat;
                double summa;
                string indata;


                //Datorn ber andvändaren ange priset på varan , läser sedan svaret och sparar det i variabeln pris
                Console.WriteLine("Ange pris :");
                indata = Console.ReadLine();
                pris = int.Parse(indata);

                //Datorn ber andvändaren ange hur mycket dem har betalat , läser sedan svaret och sparar det i variabeln betalat
                Console.WriteLine("ange hur mycket du har betalat :");
                indata = Console.ReadLine();
                betalat = int.Parse(indata);

                // programmet räknar ut växeln som kunden ska få tillbaka och lagrar det i summa 
                summa = betalat - pris;



                // om summa är ströre än 0 så kommer programmet köra nedanstående och ränka ut hur mycket av varje kunden ska få tillbaka i varje valör
                if (summa > 0)
                {


                    Console.WriteLine("Du kommer få " + summa + " kr tillbaka");
                    Console.WriteLine("Växel tillbaka:");
                    Console.WriteLine("500 lappar: " + (summa - summa % 500) / 500);
                    summa = summa % 500;
                    Console.WriteLine("100 lappar: " + (summa - summa % 100) / 100);
                    summa = summa % 100;
                    Console.WriteLine("50 lappar: " + (summa - summa % 50) / 50);
                    summa = summa % 50;
                    Console.WriteLine("20 lappar: " + (summa - summa % 20) / 20);
                    summa = summa % 20;
                    Console.WriteLine("10 kronor: " + (summa - summa % 10) / 10);
                    summa = summa % 10;
                    Console.WriteLine("5 kronor: " + (summa - summa % 5) / 5);
                    summa = summa % 5;
                    Console.WriteLine("1 kronor: " + (summa - summa % 1) / 1);
                    summa = summa % 1;

                    Console.ReadLine();

                }

                if (summa == 0)
                {
                    summa = betalat - pris;
                    Console.WriteLine("Va skönt att du betalade med jämna pengar");
                    Console.WriteLine("Ha en bra dag!");
                    Console.ReadLine();

                }


                else
                {
                    summa = betalat - pris;
                    Console.WriteLine("Tyvärr verkar det som att du inte kan betala för ditt köp");
                    Console.WriteLine("Vänligen besök din närmaste bank");
                    Console.ReadLine();
                }
            }
        }
    }

}