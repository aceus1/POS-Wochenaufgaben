using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkplatzverwaltung
{
    class Parkplatz
    {
        int anzP; //Anzahl der Parkplätze
        List<Auto> inParkplatz;
        List<Auto> vorParkplatz;
        public Parkplatz()
        {
            anzP = 30;
            inParkplatz = new List<Auto>();
            vorParkplatz = new List<Auto>();
        }
        public string getLength()
        {
            return $"Im Parkplatz sind {inParkplatz.Count} Autos und vor dem Parkplatz sind {vorParkplatz.Count}";
        }
        public void tick()
        {
            for (int i = 0; i < inParkplatz.Count - 1; i++)
            {
                inParkplatz[i].Verweilzeit = inParkplatz[i].Verweilzeit - 1;
                if (inParkplatz[i].Verweilzeit <= 0)
                {
                    inParkplatz.Remove(inParkplatz[i]);
                }
            }
            if(inParkplatz.Count < 30 && vorParkplatz.Count > 0)
            {
                inParkplatz.Add(vorParkplatz[vorParkplatz.Count - 1]);
                vorParkplatz.Remove(vorParkplatz[vorParkplatz.Count - 1]);
            }
        }
        public bool addAuto(Auto auto)
        {
            if(inParkplatz.Count >= anzP)
            {
                vorParkplatz.Add(auto);
                return false;
            }
            inParkplatz.Add(auto);
            return true;
        }

    }
}
