
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;


namespace Inl2
{
    public class DataHandler
    {
        private string path;
        private string fileName;
        private List<string> lines = new List<string>();


        // instans ger namn på fil och path
        public DataHandler()
        {
            this.fileName = "ppl.txt";
            this.path = Path.Combine(Environment.CurrentDirectory, @"data\", fileName);

        }
        //Tar in en person och skriver in den som en line i txt filen
        public void AddPerson(Person p)
        {
            File.AppendAllText(path, Environment.NewLine + p.PersonAttributes());
        }


        // läser in lines från filer och skapar person obj och retunerar dess i en lista 
        public List<Person> GetPersons()
        {
            List<string> lines = new List<string>();
            List<Person> persons = new List<Person>();

            lines = File.ReadAllLines(path).ToList();

            foreach (String line in lines)
            {
                String[] s = line.Split(',');

                persons.Add(new Person(s[0], s[1], s[2], int.Parse(s[3])));
            }

            return persons;
        }


    }
}