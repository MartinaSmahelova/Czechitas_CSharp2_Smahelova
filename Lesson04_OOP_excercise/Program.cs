using Lesson04_OOP_excercise;
using System;

/* Vytvorte tridu Obdelnik, ktera bude mit vlastnosti Sirka a Vyska jako properties.
   Nastavte properties tak, aby je nebylo mozne zmenit po vytvoreni instance.
   Obdelniku vytvorte funkci Vypis informace, ktery vypise vysku a sirku.
   Vytvorte property Obsah, ktera umozni ziskat obsah obdelniku.
   Vytvorte property Obvod, ktera umozni ziskat obvod obdelniku.
   Vytvorte funkci Zvetsi, ktera zvetsi obdelnik o sirku a vysku.
   Zajistete, aby nebylo mozne vytvorit obdelnik o obsahu 0.
   Napiste program, ktery vytvori obdelnik, vypise jeho velikosti, obsah a obvod.
*/
public class Program
{
	public static void Main()
	{
		var obdelnik = new Obdelnik(5,4);

		obdelnik.VypisInfoOObdelniku();
        Console.WriteLine($"Obsah obdélniku je {obdelnik.Obsah} a jeho obvod je {obdelnik.Obvod}");

		obdelnik.ZvetsiObdelnik(2, 10);
		obdelnik.VypisInfoOObdelniku();
		Console.WriteLine($"Obsah obdélniku je {obdelnik.Obsah} a jeho obvod je {obdelnik.Obvod}");

		Console.ReadLine();
	}
}