using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkplatzverwaltung
{
    class Program
    {
        static int uhrzeitH = 8, uhrzeitM = 0;
        static void Main(string[] args)
        {
            
            Parkplatz p = new Parkplatz();
            for (int i = 0; i < 181; i++)//Bis 181 ist zwar eine Minute zu viel für den Test, aber so sieht man auch die Endbedingungen
            {
                
                p.tick();//Verschiebt autos von der Anstehenden Liste in die Parkende Liste
                if (i < 60)
                {
                    p.addAuto(new Auto());
                }
                else if(i > 60 && i < 120 && i % 10 == 0)
                {
                    p.addAuto(new Auto());
                }
                if (i % 10 == 0)
                {
                    Console.WriteLine(uhrzeit() + " " + p.getLength() + " i:" + i);
                }
                uhrzeitplus(1);
            }
            Console.ReadKey();
        }
        static void uhrzeitplus(int min)
        {
            if (uhrzeitM + min >= 60)
            {
                uhrzeitH++;
                uhrzeitM = 0;
                return;
            }
            uhrzeitM++;
        }
        static string uhrzeit()
        {
            if (uhrzeitM < 10)
            {
                return uhrzeitH + ":0" + uhrzeitM;
            }
            return uhrzeitH + ":" + uhrzeitM;
        }
    }
}
