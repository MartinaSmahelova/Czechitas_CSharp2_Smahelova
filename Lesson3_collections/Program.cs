using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Drak drak = new Drak(32, 200);
            Console.WriteLine("Priletel k nam drak!");

            Rytir[] seznamRytiru = new Rytir[6]; // pole (array) instanci typu Rytir

            seznamRytiru[0] = new Rytir(9, 100); // Vojtech   POZOR, zacina se od indexu 0
            seznamRytiru[1] = new Rytir(12, 80); // Prokop
            seznamRytiru[2] = new Rytir(11, 110); // Borivoj
            seznamRytiru[3] = new Rytir(14, 100); // Vaclav
            seznamRytiru[4] = new Rytir(12, 130); // Stanislav
            seznamRytiru[5] = new Rytir(8, 100); // Spytihnev

            Console.WriteLine("Kral povolal pul tuctu rytiru, aby s drakem bojovali");

            int kolikatyRytir = 0;

            // cela patalie s drakem -- rytiri jdou postupne bojovat s drakem, dokud je drak nazivu (nebo dokud mame rytire na seznamu)
            while (drak.JeNazivu() && kolikatyRytir < seznamRytiru.Length && seznamRytiru[kolikatyRytir] != null)
            {
                Console.WriteLine();
                Console.WriteLine("Drakova aktualni kondice " + drak);

                Rytir rytirKteryPraveBojuje = seznamRytiru[kolikatyRytir];
                Console.WriteLine("Bojovat s nim bude " + rytirKteryPraveBojuje);

                // jeden souboj -- tak dlouho, dokud jsou drak i rytir nazivu
                while (rytirKteryPraveBojuje.JeNazivu() && drak.JeNazivu())
                {
                    // jedno kolo souboje -- rytir zautoci a pak drak zautoci
                    rytirKteryPraveBojuje.Zautoc(drak);
                    drak.Zautoc(rytirKteryPraveBojuje);

                    Console.WriteLine(drak);
                    Console.WriteLine(rytirKteryPraveBojuje);
                }

                kolikatyRytir++;
            }


            Console.WriteLine();
            Console.WriteLine("Vsichni rytiri: ");

            // vnitrek cyklu foreach se provede prave tolikrat, kolik je prvku v ridicim poli (seznamRytiru)
            // uvnitr cyklu v promenne aktualniRytir budu mit postupne vsechny prvky pole
            foreach (Rytir aktualniRytir in seznamRytiru)
            {
                if (aktualniRytir != null)
                {
                    Console.Write(aktualniRytir);
                    if (!aktualniRytir.JeNazivu())
                    {
                        Console.Write(" (cest jeho pamatce!)");
                    }
                    Console.WriteLine();
                }
            }


            Console.ReadLine();
        }
    }
}
