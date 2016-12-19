using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkplatzverwaltung
{
    class Auto
    {
        public int Verweilzeit;
        public Auto()
        {
            Random rnd = new Random();
            Verweilzeit = rnd.Next(5, 60);
        }

        public override string ToString()
        {
            return $"Verweilzeit: {Verweilzeit}";
        }
    }
}
