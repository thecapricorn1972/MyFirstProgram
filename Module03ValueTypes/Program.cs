using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module03ValueTypes
{
    enum FilTyper
    {
        csv, pdf, txt
    }

    struct Person
    {
        public int Id;
        public string Navn;
    }

    class Program
    {
        static void Main(string[] args)
        {
            System.Int32 heltal = 10;
            heltal++;
            heltal--;
            heltal += 20;
            Console.WriteLine(heltal);

            System.Double kommatal = 12.5;
            kommatal++;
            kommatal--;
            kommatal *= 2;
            Console.WriteLine(kommatal);

            FilTyper ft = FilTyper.csv;
            Console.WriteLine(ft + " " + (int) ft);

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt.ToString("ddMMyy"));
            Console.WriteLine(dt.ToString("dmy"));
            Console.WriteLine(dt.ToString("dd-MM-yyyy"));

            Person p;
            p.Id = 1;
            p.Navn = "Mikkel";
            Console.WriteLine(p.Navn);
        }
    }
}
