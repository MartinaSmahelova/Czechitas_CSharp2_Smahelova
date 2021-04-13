using System;
using System.Collections.Generic;

namespace Lesson06_Interface_HW
{
    class Banka 
    {
        public List<Ucet> SeznamUctu;
        public Banka()
        {
            SeznamUctu = new List<Ucet>();
        }

        public Ucet ZalozUcet(int zustatek, string vlastnik)
        {
            return new Ucet(zustatek, vlastnik);
        }

        public IUcet NajdiUcet(string vlastnikUctu)
        {
            foreach (var ucet in SeznamUctu)
            {
               if(ucet.Vlastnik == vlastnikUctu)
                {
                    return ucet;
                }
            }

            throw new Exception($"Účet s jménem vlastníka: {vlastnikUctu} nebyl nalezen.");
        }

        public int UlozPenize(Ucet ucet, int suma)
        {
            ucet.Zustatek = ucet.Zustatek + suma;
            return ucet.Zustatek;
        }
    }
}
