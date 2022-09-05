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
            float x = float.Parse(Console.ReadLine());
            Ausgabe("Wert für y eingeben, mit Enter bestätigen");
            float y = float.Parse(Console.ReadLine());
            Ausgabe("1 für Addition / 2 für Subtraktion");
            int operation = Convert.ToInt32(Console.ReadLine());
            Ausgabe("Ergebnis ist " + Calc(x, y, operation));

            string[] zeichenkette = new string[6];
            int[] Zahlen = new int[6];
            Zahlen[0] = 1;
            Zahlen[1] = 2;
            Zahlen[2] = 3;
            foreach (int counter in Zahlen)
            {
                Console.WriteLine(counter);
            }
            Console.ReadLine();
        }

        static void Ausgabe(string sentence)
        {
            Console.WriteLine(sentence);
        }

        static float Calc(float x, float y, int operation)
        {
            float resultAdd = x + y;
            float resultSub = x - y;
            if (operation == 1 )
            {
                return resultAdd;
            } else if (operation == 2)
            {
                return resultSub;
            }else
            {
                return 0;
            }
          
        }
    }
}

