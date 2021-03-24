using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_HW
{
    public class Prihlasovani
    {
        List<Student> seznamStudentu;
        Dictionary<string, Predmet> katalogPredmetu;

        public Prihlasovani()
        {
            // 1. nejprve vytvor novy prazdny seznam studentu a uloz ho do promenne seznamStudentu


            // naplnime studenty
            seznamStudentu.Add(new Student("Jan", "Novak"));
            seznamStudentu.Add(new Student("Petra", "Svobodova"));
            // 2. pridej nekolik dalsich studentu


            // 3. vypis seznam studentu na konzoli


            // vytvorime katalog predmetu, vytvorime nejake predmety
            katalogPredmetu = new Dictionary<string, Predmet>
        {
            {"M001", new Predmet("M001", "Uvod do elektronove mikroskopie")},
            {"P001", new Predmet("P001", "Programovani C# 1")},
            {"P002", new Predmet("P002", "Programovani C# 2", new List<string> {"P001"})}
        };

            // pridame jeste dalsi predmety
            katalogPredmetu.Add("P020", new Predmet("P020", "Vyvoj mobilnich aplikaci", new List<string> { "X111" }));
            katalogPredmetu.Add("P030", new Predmet("P030", "Vzvoj aplikaci pro elektronove mikroskopy", new List<string> { "M001", "P002" }));
            // 4. pridej jeste dalsi predmety, aspon jeden bez prerekvizit a jeden s prerekvizitou


            // 5. v metode ZkontrolujKatalog prover, jestli vsechny predmety katalogu maji v prerekvizitach existujici predmety
            // vypis chyby v nasledujicim formatu:
            // Predmet <nazev> obsahuje neexistujici prerekvizitu: <kod>
            ZkontrolujKatalog(katalogPredmetu);


            // 6. najdi v seznamu studenta s prijmenim Novak, uloz ho do promenne studentNovak
            Student studentNovak;


            // 7. naimplementuj metodu ZapisPredmet
            // ktera zapise danemu studentovi predmet (tedy ulozi kod predmetu do jeho seznamu ZapsaneAbsolvovanePredmety)
            // pokud predmet existuje v katalogu a pokud ma student uz zapsane vsechny prerekvizity
            // vypis uspesne zapsani nebo chybu v nasledujicim formatu:
            //     <jmeno>, <prijemni>: Uspesne zapsany predmet <nazev>
            //     <jmeno>, <prijemni>: Nebylo mozno zapsat predmet <nazev> (chybi prerekvizita)
            //     <jmeno>, <prijemni>: Nebylo mozno zapsat predmet <kod> (neexistujici predmet)
            ZapisPredmet(studentNovak, "P001");
            ZapisPredmet(studentNovak, "P002");
            ZapisPredmet(studentNovak, "P030");
            ZapisPredmet(studentNovak, "M001");
            ZapisPredmet(studentNovak, "P030");
            ZapisPredmet(studentNovak, "X222");
        }

        private void ZkontrolujKatalog(Dictionary<string, Predmet> katalog)
        {

        }

        private void ZapisPredmet(Student student, string kodPredmetu)
        {

        }
    }
}
