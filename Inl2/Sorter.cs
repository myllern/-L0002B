using System;
using System.Collections.Generic;
using System.Linq;

namespace Inl2
{

    static class Sorter
    {

        public static List<Person>[] GroupPersons(List<Person> people)
        {

            // sorterar en lista efter antal sålda artiklar\n
            // retunerar en arrat med listor 
            List<Person>[] L = new List<Person>[4];
                people = people.OrderByDescending(ppl => ppl.Antal).ToList();

                L[0] = people.FindAll(delegate (Person p) { return p.Antal < 50; });
                L[1] = people.FindAll(delegate (Person p) { return p.Antal >= 50 && p.Antal < 100; });
                L[2] = people.FindAll(delegate (Person p) { return p.Antal >= 100 && p.Antal < 200; });
                L[3] = people.FindAll(delegate (Person p) { return p.Antal >= 200; });
               
               
            return L;

        }


    }
}