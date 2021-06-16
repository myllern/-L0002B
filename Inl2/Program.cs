
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq; 


namespace Inl2
{
    class Program
    {
        

        static void Main(string[] args)
        {




            string fileName = "ppl.txt";
            string path = Path.Combine(Environment.CurrentDirectory, @"Data\", fileName);
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(path).ToList();

            foreach (string line in lines){
                Console.WriteLine(line);
            }





        }
    }
}
