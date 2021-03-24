using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04_OOP_excercise
{
    /* Vytvorte tridu Obdelnik, ktera bude mit vlastnosti Sirka a Vyska jako properties.
   Nastavte properties tak, aby je nebylo mozne zmenit po vytvoreni instance.
   Obdelniku vytvorte funkci Vypis informace, ktery vypise vysku a sirku.
   Vytvorte property Obsah, ktera umozni ziskat obsah obdelniku.
   Vytvorte property Obvod, ktera umozni ziskat obvod obdelniku.
   Vytvorte funkci Zvetsi, ktera zvetsi obdelnik o sirku a vysku.
   Zajistete, aby nebylo mozne vytvorit obdelnik o obsahu 0.
   Napiste program, ktery vytvori obdelnik, vypise jeho velikosti, obsah a obvod.
*/
    class Obdelnik
    {
        private int sirka;
        public int Sirka 
        {   get 
            {
                return sirka;
            }
            private set 
            {
                sirka = value <= 0 ? 1 : value;
            }
        }
        private int vyska;
        public int Vyska
        {
            get
            {
                return vyska;
            }
            private set 
            {
                vyska = value <= 0 ? 1 : value;
            }
        }

        public int Obsah
        {
            get
            {
                return Sirka * Vyska;
            }

           private set { }
        }

        public int Obvod
        {
            get
            {
                return (Sirka*2) + (Vyska*2);
            }

            private set { }
        }

        public Obdelnik(int sirka, int vyska)
        {
            //Sirka = sirka <= 0 ? 1 : sirka;
            Sirka = sirka;
            Vyska = vyska;
        }

        public void VypisInfoOObdelniku()
        {
            Console.WriteLine($"Šírka obdélníku je {this.Sirka} a jeho výška je {this.Vyska}");
        }

        public void ZvetsiObdelnik(int zvetsiSirkuO, int zvetsiVyskuO)
        {
            Sirka = Sirka + zvetsiSirkuO;
            Vyska = Vyska + zvetsiVyskuO;
        }


    }
}
