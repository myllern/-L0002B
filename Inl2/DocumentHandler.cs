
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq; 


namespace Inl2
{
    public class DocumentHandler
    {
        private string path;
        private string fileName;
        private List<string> lines = new List<string>();

        public DocumentHandler()
        {
            this.fileName = "ppl.txt";
            this.path = Path.Combine(Environment.CurrentDirectory, @"Data\", fileName);
            this.lines = File.ReadAllLines(path).ToList();
        
        }

        public void addLine(String[] p){
            File.WriteAllLines(path, p);
        }
        public  List<string> getLines(){
            return this.lines;
        }
        

        




    }
}