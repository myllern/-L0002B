using System;
using System.Collections.Generic;

namespace Inl2
{
    // vid instans skapas person med attributes som behövs 
    public class Person
    {
        private string name, distrikt, personNr;
        private  int antal;

        //constructor för Person
        public Person(string name, string personNr, string distrikt, int antal)
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
        public string PersonNr
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
        // retunerar en sträng med de attribut som behöver skrivas in i txt filen
        public String PersonAttributes(){
            String s = $"{this.name}, {this.personNr.ToString()}, {this.Distrikt}, {this.Antal.ToString()}";
            return s;

        }

    }
}