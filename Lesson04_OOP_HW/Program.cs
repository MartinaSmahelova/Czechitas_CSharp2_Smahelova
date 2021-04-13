using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04_OOP_HW
{
    class Program

    //        Aréna
    // Vytvořte Arenu, ve které budou zápasit bojovníci.
    // 1. Vytvořte třídu Bojovnik, která bude mít properties Jmeno, Sila, Brneni, Zivot.Properties nesmí být možné změnit mimo třídu.
    // 2. Síla musí být vždy alespoň 10, Život 0 až 100, Brnění 0 až 50
    // 3. Bojovníkovi vytvořte metodu UtocNa, která provede útok na jiného bojovníka.
    //    - útok odečte protivníkovi ze života sílu aktuálního bojovníka.
    // 4. Přidejte bojovníkovi další property nebo funkce/metody podle potřeby (např.může se hodit JeZivy apod)
    // 5. Vytvořte třídu Arena
    // 6. Vytvořte v Arene funkci, ktera zobrazi stav bojovniku v areně.
    // 7. V Arene vytvořte metodu boj, která spustí zápas mezi dvěma bojovníky a zobrazí stav před a po souboji.

    //==============================================
    //Fidel Zivot: 100 Brneni:  20
    //Horal Zivot: 100 Brneni:   0
    //==============================================
    //Horal Zivot:   4 Brneni:   0

    //Vylepšení č.1 - Zbraně
    //8. Vytvořte výčet zbraní, alespoň 2 - Mec, Palcat, ale kreativitě se meze nekladou :) např. Kopí
    //9. Bojovnikovi přidejte povinnou property používané zbraně.
    //10. Rozšiřte metodu UtocNa, která provede útok na jiného bojovníka.
    //    - podle typu zbraně se provede útok následovně
    //    Mec
    //    - cíl nemá brnění - útok je roven síle
    //    - cíl má brnění > 0 - útok se snižuje o velikost brnění
    //    - Vždy poškodí brnění o desetinu síly, dokud není úplně zničené.
    //    Palcat
    //    - útok je vždy roven čtvrtině síly 
    //    - vždy poškodí brnění o čtvrtinu síly, dokud není úplně zničené.

    //==============================================
    //Fidel Zbran:     Palcat Zivot: 100 Brneni:  20
    //Horal Zbran:     Palcat Zivot: 100 Brneni:   0
    //==============================================
    //Horal Zbran:     Palcat Zivot:   4 Brneni:   0

    //Vylepšení č.2 - Hry
    //11. Umožněte do arény vložit bojovniky, kteří budou zápasit, např. funkci RegistrujBojovnika.
    //12. V Arene vytvořte metodu Boj
    //   - boj probíhá tak, že se vytvoří páry, útočnik a protivník. Tj. v připadě 5 bojovníků 2 páry a jeden čekatel.
    //   - páry spolu bojují na život a na smrt. Jakmile je dobojováno, opět se losují páry a boj se opakuje
    //   - boj končí, když zůstane poslední bojovník
    //   - čekatel se zařadí do následujícího losování, takže jedno kolo může odpočívat
    //13. Před losováním párů vždy zobrazte statistiku.
    //14. V hlavním programu vytvořte instanci Areny a několik bojovníků, kteří budou bojovat.

    //==============================================
    //Krull Zbran:        Mec Zivot: 100 Brneni:  20
    //Smoke Zbran:        Mec Zivot: 100 Brneni:  10
    //Fidel Zbran:     Palcat Zivot: 100 Brneni:  20
    //Horal Zbran:     Palcat Zivot: 100 Brneni:   0
    //Karel Zbran:        Mec Zivot: 100 Brneni:  50
    //==============================================
    //Smoke Zbran:        Mec Zivot:   2 Brneni:   0
    //Fidel Zbran:     Palcat Zivot: 100 Brneni:  20
    //Horal Zbran:     Palcat Zivot:  20 Brneni:   0
    //==============================================
    //Fidel Zbran:     Palcat Zivot: 100 Brneni:  20
    //Horal Zbran:     Palcat Zivot:  20 Brneni:   0
    //==============================================
    //Horal Zbran:     Palcat Zivot:   4 Brneni:   0

    //Tipy: 
    //1. pro uložení bojovníků v aréně využijte List<>
    //2. pro vytvoření párů použijte Dictionary<>. Dictionary<klic, hodnota> má property .Keys ve ktere je kolekce všech klíčů, 
    //   a je možné je použít ve foreach
    //   např. foreach(Bojovnik utocnik in souperi.Keys)
    //3. Do pomocnych metod můžete jako parametr předat seznam i slovnik. Např. můžete mít funkci nebo metodu, 
    //   která vám připraví páry soupeřů.   
    //4. Můžete si vytvořit kopii Listu jako new List<Bojovnik>(existujiciList);
    //5. Můžete mít list všech bojovníků, a list zivých bojovníků, ze kterého přes Remove odebírat poražené. Nebo využít kopii 
    //   seznamu bojovníků, kteří se losují a vylosovaného hned odebrat.
    //6. Pokud používáte foreach na průchod seznamem, není možné ve foreach odebírat, nebo přidávat z procházeného seznamu.

    {
        static void Main(string[] args)
        {
            Knight knight = new Knight("Jonatan", 150,105,80);
            Console.WriteLine($"{knight.Live} , {knight.Strength}, {knight.Armor} , {knight.IsAlive}");

            Console.ReadLine();
        }
    }
}
