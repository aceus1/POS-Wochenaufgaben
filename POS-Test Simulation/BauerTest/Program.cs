using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BauerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            beispielA();

            Bad myBad = new Bad();
            do
            {
                myBad.BadTick();
            } while (myBad.zeit > 0);
            Console.WriteLine("Max ist: " + myBad.max);
            Console.ReadKey();
        }
        static void beispielA()
        {
            int zeit = 20 * 60;
            int schlange = 10;
            int max = 0;
            do
            {
                Console.WriteLine("Schlange bei " + zeit + " Sekunden: " + schlange);
                zeit = zeit - 30;
                if(zeit <= 10*60 && zeit >= 5 * 60)
                {
                    schlange++;
                }
                else if(zeit < 5 * 60)
                {
                    schlange--;
                }
                if(max < schlange)
                {
                    max = schlange;
                }
                
            } while (zeit > 0);
            Console.WriteLine("Schlange bei " + zeit + " Sekunden: " + schlange);
            Console.WriteLine("Maximumlaenge: " + max);
        }
    }
}
