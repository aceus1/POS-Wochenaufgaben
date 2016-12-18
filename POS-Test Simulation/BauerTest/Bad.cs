using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BauerTest
{
    class Bad
    {
        public List<Schwimmer> Schlange;
        public int zeit;
        public int max = 0;
        Schwimmer geradedran;
        public Bad()
        {
            Schlange = new List<Schwimmer>();
            zeit = 20 * 60; //Zeit in sekunden also 20 min â 60 sec
            for (int i = 0; i < 10; i++)
            {
                Schlange.Add(new Schwimmer());
            }
        }
        public void BadTick()
        {
            if(geradedran == null)
            {
                geradedran = Schlange[0];
            }
            geradedran = Schlange[geradedran.id1 + 1];
            
            Random rnd = new Random();
            geradedran.dauer = rnd.Next(10 * 60, 30 * 60); //Zwischen 10 und 30 min
            for (int i = 0; i < geradedran.dauer; i++)
            {
                zeit = zeit - 1;
                if(zeit % 60 == 0)
                {
                    if (zeit <= 10 * 60 && zeit >= 5 * 20)
                    {
                        Schlange.Add(new Schwimmer());
                    }
                    else if (zeit < 5 * 20)
                    {
                        Schlange.Remove(Schwimmer.getHighestSchwimmer(Schlange));
                    }
                }
                if(Schlange.Count > max)
                {
                    max = Schlange.Count;
                }
                Console.WriteLine(Schlange.Count);
            }
            //TODO tick fix
            
        }
    }
}
