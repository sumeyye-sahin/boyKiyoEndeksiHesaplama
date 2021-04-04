using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ilkProjem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Boyunuzu metre cinsinden giriniz: ");
            double boy = Convert.ToDouble(Console.ReadLine());
            Console.Write("kilonuzu kilogram cinsinden giriniz: ");
            double kilo = Convert.ToDouble(Console.ReadLine());
            double bki =  kilo / (boy*boy);
            Console.Write(bki);

       
            Console.ReadKey();
        }
    }
}
