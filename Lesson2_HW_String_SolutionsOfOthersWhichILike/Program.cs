using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02_HW_String_SolutionsOfOthersWhichILike
{
    class Program
    {
        static void Main(string[] args)
        {
			int padding = 45;
			string text = @"""Hurry up, boy!"" shouted Uncle Vernon from the kitchen. ""What are you
doing, checking for letter bombs?"" He chuckled at his own joke.

Harry went back to the kitchen, still staring at his letter. He handed
Uncle Vernon the bill and the postcard, sat down, and slowly began to
open the yellow envelope.

Uncle Vernon ripped open the bill, snorted in disgust, and flipped over
the postcard.

""Marge's ill,"" he informed Aunt Petunia. ""Ate a funny whelk. --.""

""Dad!"" said Dudley suddenly. ""Dad, Harry's got something!""

Harry was on the point of unfolding his letter, which was written on the
same heavy parchment as the envelope, when it was jerked sharply out of
his hand by Uncle Vernon.

""That's mine!"" said Harry, trying to snatch it back.

""Who'd be writing to you?"" sneered Uncle Vernon, shaking the letter open
with one hand and glancing at it. His face went from red to green faster
than a set of traffic lights. And it didn't stop there. Within seconds
it was the grayish white of old porridge.";

			// Zjisti, kolikrat se v textu vyskytuje slovo "and" bez ohledu na velikosti prvniho pismenka a vysledek uloz do promenne 'pocetAnd'.
			// Abych vam to zjednodusil, muzete se spolehnout, ze tato anglicka spojka bude v textu vzdy obklopena mezerou na kazde strane.
			// Tim se snadno vylouci jakekoliv vyskyty "and" v ramci jinych slov.

			//1.
			string[] poleSlov = text.Split(' ');
			int pocetAnd = 0;
			string andText = "and";
			for (int i = 0; i < poleSlov.Length; i++)
			{
				if (andText.Equals(poleSlov[i], StringComparison.InvariantCultureIgnoreCase))
				{
					pocetAnd++;
				}
			}

			//2.
			//var searchText = "and";
			//var input = text.ToLower();
			//var arr = input.Split(new char[] { ' ', '.' });

			//int pocetAnd = Array.FindAll(arr, s => s.Equals(searchText.Trim())).Length;
			//string kolik = pocetAnd.ToString();

			//3.
			//int pocetAnd = Regex.Matches(text, @"\band\b", RegexOptions.IgnoreCase).Count;

			//4.
			//int pocetAnd = text.ToLower().Split(" and").Length - 1;

			//5.
			//int pocetAnd = Regex.Matches(text, " [aA]nd ").Count;

			Console.WriteLine("Text obsahuje slovo 'and' celkem 5x' - ".PadRight(padding) + (pocetAnd == 5));
		}
    }
}
