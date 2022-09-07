using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace pr2
{
    abstract class Isik
    {
        public string nimi { get; set; }
        public int vanus;
        public string sugu;
        public Isik() { }
        public Isik(string nimi,  string sugu)
        {
            this.nimi = nimi; 
            this.sugu = sugu;
        }
    
        public Isik(string sugu = "---", string nimi = "---", int synniAasta = 0)
        { this.nimi = nimi; this.vanus = synniAasta; this.sugu = sugu; }
        public Isik(Isik ob)
        { this.nimi = ob.nimi; this.vanus = ob.vanus; this.sugu = ob.sugu; }
        public virtual void print()
        {
            Console.Write("{0,-10} {1} {2,4}", nimi, sugu, vanus);
        }
        public int arvutaVanus()
        {
            int vanus = DateTime.Now.Year - this.vanus;
            return vanus;
        }
        public abstract double arvutaSissetulek(double maksuvaba, double tulumaks);
        public List<Isik> GetIsiksFromFile(string filePath)
        {
            using (var fileReader = File.OpenText(filePath))
            using (var reader = new CsvReader((IParser)fileReader))
            {
                return reader.GetRecords<Isik>().ToList();
            }
        }
    }
}
