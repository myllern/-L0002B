
using System;
using System.IO;
using System.Collections.Generic;



namespace Inl2
{
    public class DataHandler
    {
        private string path;
        private string fileName;
        private List<string> lines = new List<string>();

        public DataHandler()
        {
            this.fileName = "ppl.txt";
            this.path = Path.Combine(Environment.CurrentDirectory, @"Data\", fileName);


        }
        public void addPerson(Person p)
        {
            File.AppendAllText(path, p.PersonAttributes() + Environment.NewLine);
        }


        public List<string> GetPersons()
        {
            List<string> p = new List<string>();
           
            // TODO  GetPersons från line i fil!

            return p;
        }

        public List<string> getLines()
        {
            return this.lines;
        }

        public void addLine(String[] p)
        {
            File.WriteAllLines(path, p);
        }
    }
}