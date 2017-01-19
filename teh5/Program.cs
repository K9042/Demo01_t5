using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teh5
{
    class Program
    {
        static void Main(string[] args)
        {
            double sekunti, minuutti, tunti;

            Console.Write("Anna sekunnit > ");
            sekunti = double.Parse(Console.ReadLine());

            minuutti = sekunti / 60;
            tunti = minuutti / 60;

            Console.WriteLine("Aika sekuntiena: " + sekunti);
            Console.WriteLine("Aika minuutteina: " + minuutti);
            Console.WriteLine("Aika tunteina: " + tunti);
        }
    }
}
