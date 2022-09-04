using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
           
         
            /* Console.WriteLine("Hello World");
            Console.WriteLine("Zum Beenden Enter drücken!");
            */
            Ausgabe("Taschenrechner für Ganzzahlen");
            Ausgabe("Wert für x eingeben, mit Enter bestätigen");
            int x = Convert.ToInt32(Console.ReadLine());
            Ausgabe("Wert für y eingeben, mit Enter bestätigen");
            int y = Convert.ToInt32(Console.ReadLine());
            Ausgabe("Ergebnis der Addition ist " + Sum(x, y));
        }

        static void Ausgabe(string sentence)
        {
            Console.WriteLine(sentence);
        }

        static int Sum(int x, int y)
        {
            int result = x + y;
            return result;
        }
    }
}

