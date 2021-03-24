using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_collections
{
    class Rytir
    {
        private Random nahodnaCisla;

        public string Jmeno;
        public int Sila;
        public int Zivot;

        public Rytir(string jmeno)
        {
            nahodnaCisla = new Random(jmeno.GetHashCode());

            Jmeno = jmeno;
            Sila = nahodnaCisla.Next(7, 15);
            Zivot = nahodnaCisla.Next(80, 120);
        }

        public Rytir(int sila, int zivot)
        {
            Sila = sila;
            Zivot = zivot;
        }

        public override string ToString()
        {
            return String.IsNullOrEmpty(Jmeno)
                ? string.Format("rytir -- zivot:{0} sila:{1}", Zivot, Sila)
                : string.Format("rytir {0} -- zivot:{1} sila:{2}", Jmeno, Zivot, Sila);
        }

        public bool JeNazivu()
        {
            return Zivot > 0;
        }

        public int BojujNaTurnaji(Rytir rytir)
        {
            return this.Sila - rytir.Sila + nahodnaCisla.Next(6);
        }

        public void Zautoc(Rytir rytir)
        {
            rytir.Zivot -= Sila;
        }

        public void Zautoc(Drak drak)
        {
            drak.Zivot -= Sila;
        }
    }
}
