using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //LISTY
            List<Rytir> seznam = new List<Rytir>();

            seznam.Add(new Rytir("Vojtech"));
            seznam.Add(null);
            seznam.Add(new Rytir("Prokop"));

            seznam.Add(new Rytir("Silver"));
            seznam.Add(new Rytir("Silver"));
            seznam[2].Jmeno = "SilverGold";

            Rytir jonas = new Rytir("Jonas");
            seznam.Add(jonas);
            seznam.Add(jonas);
            seznam[4].Jmeno = "Jonas II";

            //seznam[6].Jmeno = "Pepe"; //out of range

            Console.WriteLine(seznam.Count);
            //Console.WriteLine(seznam.Capacity);

            foreach (var rytir in seznam)
            {
                Console.WriteLine(rytir);
            }

            List<Rytir> seznam1 = new List<Rytir>()
            {
                new Rytir("Vojtech"),
                new Rytir("Mumúch"),
                new Rytir("Lolo")
            };

            foreach (var rytir in seznam1)
            {
                Console.WriteLine(rytir);
            }

            seznam1.Remove(seznam1[0]);

            foreach (var rytir in seznam1)
            {
                Console.WriteLine(rytir);
            }

            var rytiriZivotMensiNez100 = seznam1.FindAll(rytir => rytir.Zivot < 100);

            //dve možnosti ako vypísať kolekciu do konzole:
            //1.
            Console.WriteLine(String.Join(Environment.NewLine, rytiriZivotMensiNez100));

            //2.
            foreach (var rytir in rytiriZivotMensiNez100)
            {
                Console.WriteLine(rytir);
            }

            //SLOVNÍKY
            // vytvoreni slovniku
            Dictionary<string, Rytir> soupiskaRytiru = new Dictionary<string, Rytir>
        {
            { "Vaclav", new Rytir("Vaclav") },
            { "Rostislav", new Rytir("Rostislav") },
        };

            // pristup k jeho prvku
            var rytirVaclav = soupiskaRytiru["Vaclav"];

            Console.WriteLine(rytirVaclav);

            // iterace pres vsechny klice slovniku
            foreach (var jmenoRytire in soupiskaRytiru.Keys)
            {
                Console.WriteLine(jmenoRytire);
            }

            // dotaz, jestli je zaznam k dispozici
            if (soupiskaRytiru.ContainsKey("Vaclav"))
            {
                Console.WriteLine("Nasel jsem Vaclava");
            }

            // pridani zaznamu do slovniku
            soupiskaRytiru.Add("Prokop", new Rytir("Prokop"));
            soupiskaRytiru["Spytihnev"] = new Rytir("Spytihnev");

            Console.WriteLine();
            // iterace pres vsechny obekty ulozene ve slovniku
            foreach (var rytir in soupiskaRytiru.Values)
            {
                Console.WriteLine(rytir);
            }


            //Príklad s kurzu C#1 - práca s polom (array) 

            //V Poli musí mať nadefinovaný dopredu počet. 

            //Drak drak = new Drak(32, 200);
            //Console.WriteLine("Priletel k nam drak!");

            //Rytir[] seznamRytiru = new Rytir[6]; // pole (array) instanci typu Rytir

            //seznamRytiru[0] = new Rytir(9, 100); // Vojtech   POZOR, zacina se od indexu 0
            //seznamRytiru[1] = new Rytir(12, 80); // Prokop
            //seznamRytiru[2] = new Rytir(11, 110); // Borivoj
            //seznamRytiru[3] = new Rytir(14, 100); // Vaclav
            //seznamRytiru[4] = new Rytir(12, 130); // Stanislav
            //seznamRytiru[5] = new Rytir(8, 100); // Spytihnev

            //Console.WriteLine("Kral povolal pul tuctu rytiru, aby s drakem bojovali");

            //int kolikatyRytir = 0;

            //// cela patalie s drakem -- rytiri jdou postupne bojovat s drakem, dokud je drak nazivu (nebo dokud mame rytire na seznamu)
            //while (drak.JeNazivu() && kolikatyRytir < seznamRytiru.Length && seznamRytiru[kolikatyRytir] != null)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("Drakova aktualni kondice " + drak);

            //    Rytir rytirKteryPraveBojuje = seznamRytiru[kolikatyRytir];
            //    Console.WriteLine("Bojovat s nim bude " + rytirKteryPraveBojuje);

            //    // jeden souboj -- tak dlouho, dokud jsou drak i rytir nazivu
            //    while (rytirKteryPraveBojuje.JeNazivu() && drak.JeNazivu())
            //    {
            //        // jedno kolo souboje -- rytir zautoci a pak drak zautoci
            //        rytirKteryPraveBojuje.Zautoc(drak);
            //        drak.Zautoc(rytirKteryPraveBojuje);

            //        Console.WriteLine(drak);
            //        Console.WriteLine(rytirKteryPraveBojuje);
            //    }

            //    kolikatyRytir++;
            //}


            //Console.WriteLine();
            //Console.WriteLine("Vsichni rytiri: ");

            //// vnitrek cyklu foreach se provede prave tolikrat, kolik je prvku v ridicim poli (seznamRytiru)
            //// uvnitr cyklu v promenne aktualniRytir budu mit postupne vsechny prvky pole
            //foreach (Rytir aktualniRytir in seznamRytiru)
            //{
            //    if (aktualniRytir != null)
            //    {
            //        Console.Write(aktualniRytir);
            //        if (!aktualniRytir.JeNazivu())
            //        {
            //            Console.Write(" (cest jeho pamatce!)");
            //        }
            //        Console.WriteLine();
            //    }
            //}

            Console.ReadLine();
        }
    }
}
