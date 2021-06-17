using System;
using System.Collections.Generic;

namespace Inl2
{

    static class Sorter
    {

        public static List<Person>[] groups(List<Person> people)
        {
            List<Person>[] L = new List<Person>[4];
            
                people.Sort(delegate (Person p1, Person p2)
                { return p1.Antal.CompareTo(p2.Antal); });

                L[0] = people.FindAll(delegate (Person p) { return p.Antal < 50; });
                L[1] = people.FindAll(delegate (Person p) { return p.Antal >= 50 && p.Antal < 100; });
                L[2] = people.FindAll(delegate (Person p) { return p.Antal >= 100 && p.Antal < 200; });
                L[3] = people.FindAll(delegate (Person p) { return p.Antal >= 200; });
                
            return L;

        }


    }
}