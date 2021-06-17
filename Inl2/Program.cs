
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


            switch (display.MainMenue())
            {
                case 1:
                    String[] p = display.addPerson();
                    DH.addPerson(new Person(p[0], int.Parse(p[1]), p[2], int.Parse(p[3])));
                    break;

               // case 2:


            }




        }
    }
}
