using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BauerTest
{
    class Schwimmer
    {
        public int dauer {  get; set; }
        static int id = 0;
        public int id1;
        public Schwimmer()
        {
            id1 = id;
            id++;
            dauer = 0;
        }
        public static Schwimmer getHighestSchwimmer(List<Schwimmer> Schlange)
        {
            if(Schlange.Count - 1 < 0)
            {
                return null;
            }
            return Schlange[Schlange.Count - 1];
        }
    }
}
