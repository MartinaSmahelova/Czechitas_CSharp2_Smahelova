using System;
using System.Collections.Generic;

namespace Lesson06_Interface_HW
{
    //1. Vytvořte interface IUcet, který bude mít property Zustatek s get (bez set) a 
    //   property Vlastnik s get (také bez set)
    //2. Vytvořte třídu Ucet, která bude dědit interface IUcet, implementovat properties 
    //   Zustatek (get i set) a Vlastník, který bude nastaven jen z konstruktoru.
    //3. Vytvořte konstruktor Uctu, který bude brát jako parametry jméno vlastníka a počáteční zůstatek.
    //4. Vytvořte třídu Banka, která bude mít funkci ZalozUcet s parametry počátečního zůstatku a jména vlastníka.
    //5. Vytvořte bance funkci NajdiUcet, která vrátí IUcet podle jména vlastníka.
    //6. Vytvořte bance funkci UložPeníze, která přidá do účtu vlastníka odpovídající obnos.
    //7. Vytvořte program, který bude mít instanci Banky, vytvoří 3 účty 
    //   (nemusíte dělat načítání z konzole, klidně v kodu vytvořit)
    //8. Vypište aktuální stav účtů v Bance
    //9. Uložte do jednoho účtu další peníze a opět vypište aktuální stav účtů
    //10. Získejte jeden účet z Banky do proměnné typu IUcet pomocí NajdiUcet.
    //    Nesmí mu jít změnit Zustatek, musí jít jedině přes příkaz v bance :)

    class Program
    {
        static void Main(string[] args)
        {
            var banka = new Banka();
            List<Ucet> seznamUctu = banka.SeznamUctu;

            seznamUctu.Add(banka.ZalozUcet(100000, "Saxana"));
            seznamUctu.Add(banka.ZalozUcet(58000, "Pinokio"));
            seznamUctu.Add(banka.ZalozUcet(89000, "Popelka"));

            ZobrazZustatkyNaUctech(seznamUctu);

            banka.UlozPenize(seznamUctu[2], 58000);

            ZobrazZustatkyNaUctech(seznamUctu);

            IUcet iUcet = banka.NajdiUcet("Popelka");
           
            Console.WriteLine($"Vybraný účet vlastní: {iUcet.Vlastnik} a je na něm zůstatek {iUcet.Zustatek} Eur");

            Console.ReadLine();

        }

        public static void ZobrazZustatkyNaUctech(IList<Ucet> seznamuctu)
        {
            foreach (var ucet in seznamuctu)
            {
                Console.WriteLine(ucet.Zustatek); 
            }
        }
    }
}
