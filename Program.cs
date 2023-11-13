using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pripremaZaIspitZadatak9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("unesite cijenu bez PDV-a: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("unesite cijenu sa PDV-a: ");
            double y = Convert.ToDouble(Console.ReadLine());
            double z = 100 - ((x / y) * 100);
            Console.WriteLine("PDV iznosi " + z + "%");
            Console.ReadKey();

        } 
    }
}
