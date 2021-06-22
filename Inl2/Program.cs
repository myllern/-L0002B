
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
            Display display = new Display();
            DataHandler DH = new DataHandler();


            while(true){
            switch (display.MainMenue())
            {
                case 1:
                    String[] p = display.AddPerson();
                    DH.AddPerson(new Person(p[0], p[1], p[2], int.Parse(p[3])));
                    break;
                case 2:
                //lista med personer från txt
                    List<Person> ppl = DH.GetPersons();
                //sorterad listan ppl, för att få en array med fyra listor som är sorterade
                    List<Person>[] groups = Sorter.GroupPersons(ppl);
                    display.SalesInfo(groups[0], groups[1], groups[2], groups[3]);             
                    break;
                case 3:
                System.Environment.Exit(1);
                break;
            }
            }


        }
    }
}
