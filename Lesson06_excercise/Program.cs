using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson06_excercise
{
    // Vytvořte abstraktní třídu PohadkovaBytost a v ní abstraktní metodu NapisJakTravisVolnyCas
    // Vytvorte tridy Princezna, Rytir, Carodenice, ktere dedi PohadkovouBytost
    // Naimplementujte metodu NapisJakTravisVolnyCas - vypsanemu textu na konzoli se meze nekladou
    // Vytvorte instance od kazde tridy a vypiste informace o trávení volného času.

    abstract class PohadkovaBytost
    {
        public abstract void NapisJakTravisVolnyCas();
    }

    class Princezna : PohadkovaBytost
    {
        public override void NapisJakTravisVolnyCas()
        {
            Console.WriteLine("Tanuji s princem");
        }
    }

    class Princ : PohadkovaBytost
    {
        public override void NapisJakTravisVolnyCas()
        {
            Console.WriteLine("Tanuji s princeznou");
        }
    }

    class Carodejnice : PohadkovaBytost
    {
        public override void NapisJakTravisVolnyCas()
        {
            Console.WriteLine("Otravujem jablká");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PohadkovaBytost princezna = new Princezna();
            PohadkovaBytost princ = new Princ();
            PohadkovaBytost carodejnice = new Carodejnice();

            princezna.NapisJakTravisVolnyCas();
            princ.NapisJakTravisVolnyCas();
            carodejnice.NapisJakTravisVolnyCas();

            Console.ReadLine();
        }
    }
}
