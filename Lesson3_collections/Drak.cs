using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_collections
{
    class Drak
    {
        public int Sila;
        public int Zivot;

        public Drak(int sila, int zivot)
        {
            Sila = sila;
            Zivot = zivot;
        }

        public override string ToString()
        {
            return "drak -- zivot:" + Zivot + " sila:" + Sila;
        }

        public bool JeNazivu()
        {
            return Zivot > 0;
        }

        public void Zautoc(Rytir rytir)
        {
            rytir.Zivot -= Sila;
        }
    }
}
