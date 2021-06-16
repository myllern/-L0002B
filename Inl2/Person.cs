using System;
namespace Inl2
{

    public class Person
    {
        private string name, distrikt;
        private int personNr, antal;

        //constructor för Person
        public Person(string name, int personNr, string distrikt, int antal)
        {
            this.name = name;
            this.personNr = personNr;
            this.distrikt = distrikt;
            this.antal = antal;
        }

        // get och set metoder för samtliga Person-atribut
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int PersonNr
        {
            get { return personNr; }
            set { personNr = value; }
        }
        public string Distrikt
        {
            get { return distrikt; }
            set { distrikt = value; }
        }
        public int Antal
        {
            get { return antal; }
            set { antal = value; }
        }

    }
}