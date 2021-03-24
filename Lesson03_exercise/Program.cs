using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_exercise
{
    class Program
    {
        public static void Main()
        {
            var cisla = new List<double>
        {
            0.046939913,
            0.295866297,
            0.852489925,
            0.84994766,
            0.96925183,
            0.946275497,
            0.688903175,
            0.553463564,
            0.59628254,
            0.645816929
        };

            // 1.Vypis vsechna cisla na konzoli (nachystej si pro to funkci)
            Vypis(cisla);
            Console.WriteLine("---------------1----------------");
            Vypis1(cisla);

            // 2.Vypis na konzoli pocet cisel v seznamu
            Console.WriteLine("---------------2----------------");
            VypisPocet(cisla);

            // 3.Pridej cislo 0.5 do seznamu
            cisla.Add(0.5);
            Console.WriteLine("---------------3----------------");
            VypisPocet(cisla);

            // 4.vypis prvni cislo ze seznamu, ktere je vetsi nez 0.8
            Console.WriteLine("---------------4----------------");
            Console.WriteLine(cisla.Find(number => number > 0.8));

            // 5.najdi nejvetsi cislo v seznamu, vypis, ktere to je, a odstran ho ze seznamu
            Console.WriteLine("---------------5----------------");
            //Console.WriteLine(NajdiNejvetsiCislo(cisla));
            //cisla.Remove(NajdiNejvetsiCislo(cisla));

            cisla.Sort();
            Console.WriteLine(cisla.Last()); 

            Console.WriteLine(cisla.Max());
            cisla.Remove(cisla.Max());

            // vypis opet vsechna cisla a jejich pocet
            Console.WriteLine("---------------6----------------");
            Vypis1(cisla);
            VypisPocet(cisla);

            Console.ReadLine();
        }

        private static void Vypis(List<double> list)
        {
            foreach (var number in list)
            {
                Console.WriteLine(number);
            }
        }

        private static void Vypis1(List<double> list)
        {
            Console.WriteLine(String.Join(Environment.NewLine, list));
        }

        private static void VypisPocet(List<double> list)
        {
            Console.WriteLine(String.Format(" -- pocet cisel: {0}", list.Count));
        }

        private static double NajdiNejvetsiCislo(List<double> list)
        {
            double cislo1 = double.MinValue;

            foreach (var cislo in list)
            {
                if (cislo > cislo1)
                {
                    cislo1 = cislo;
                }
            }
            return cislo1;
        }
    }
}
