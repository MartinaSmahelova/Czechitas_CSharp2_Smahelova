using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum Zbran
{
	Mec,
	Palcat,
}

class Rytir
{
	public Zbran Zbran { get; private set; } = Zbran.Mec;

	private string jmeno;
	public string Jmeno
	{
		get
		{
			return jmeno;
		}
		private set
		{
			jmeno = value;
		}
	}
	public int Zdravi { get; private set; }
	public int Sila { get; private set; }
	public int Brneni { get; private set; }
	public bool JeZivy
	{
		get
		{
			return Zdravi > 0;
		}
	}

	public Rytir(string jmeno, int sila, int zdravi = 100, int brneni = 100)
	{
		this.Jmeno = jmeno;
		this.Sila = sila <= 10 ? 10 : sila;
		//if (sila <= 10)
		//{
		//    Sila = 10;
		//}
		//else
		//{
		//    Sila = sila;
		//}

		Zdravi = zdravi;
		Brneni = brneni;
	}

	public void UtocNa(Rytir obet)
	{
		int silaUtoku = this.DejSiluUtoku();
		int poskozeni = obet.DejPoskozeniUtokem(silaUtoku);
		obet.Zdravi -= poskozeni;
	}

	private int DejSiluUtoku()
	{
		return this.Sila;
	}

	private int DejPoskozeniUtokem(int silaUtoku)
	{
		return silaUtoku;
	}
}

static class Matematika
{
	public static int Koeficient { get; set; }

	public static int VypocitejObsahObdelnika(int sirka, int vyska)
	{
		return sirka * vyska * Koeficient;
	}

	// nelze ve staticke tride
	//public void VytiskniMouInstanciMatematiky()
	//{
	//    Console.WriteLine($"{Koeficient}");
	//}
}

enum RocniObdobi
{
	Jaro,
	Leto,
	Podzim,
	Zima,
}

class Program
{
	static void Main(string[] args)
	{
		// OpakovaniSeznamyASlovniky();
		// OpakovaniOopAProperties();

		Matematika.Koeficient = 2;
		int obsahObdelnika = Matematika.VypocitejObsahObdelnika(10, 20);

		RocniObdobi rocniObdobi = RocniObdobi.Jaro;
		if (rocniObdobi == RocniObdobi.Jaro)
		{

		}
		else if (rocniObdobi == RocniObdobi.Leto)
		{

		}

		switch (rocniObdobi)
		{
			case RocniObdobi.Jaro:
				break;
			case RocniObdobi.Leto:
				break;
			case RocniObdobi.Podzim:
				break;
			case RocniObdobi.Zima:
				break;
			default:
				break;
		}

		Console.ReadLine();
	}

	private static void OpakovaniOopAProperties()
	{
		Rytir rytir1 = new Rytir("Vojtěch", 0);
		//rytir.Jmeno = "Vojtěch";
		//rytir.Zdravi = 100;
		//rytir.Sila = 20;
		//rytir.Brneni = 100;

		Rytir rytir2 = new Rytir("Bedřích", 30, brneni: 20);
		//rytir2.Jmeno = "Bedřích";
		//rytir2.Zdravi = 100;
		//rytir2.Sila = 30;
		//rytir2.Brneni = 20;

		//int silaUtoku1 = rytir1.DejSiluUtoku();
		//int silaUtoku2 = rytir2.DejSiluUtoku();

		//int poskozeni1 = rytir1.DejPoskozeniUtokem(silaUtoku2);
		//int poskozeni2 = rytir2.DejPoskozeniUtokem(silaUtoku1);

		// nelze, protoze Properties maji private set - funguje jen uvnitr tridy
		//rytir1.Zdravi -= poskozeni1;
		//rytir2.Zdravi -= poskozeni2;

		//rytir1.Zdravi = 200;
		//rytir1.Sila = 0;

		rytir1.UtocNa(rytir2);

		Console.WriteLine("Po prvnim kole souboje: ");
		Console.WriteLine($"Rytir1 Zdravi: {rytir1.Zdravi}");
		Console.WriteLine($"Rytir2 Zdravi: {rytir2.Zdravi}");
	}

	private static void OpakovaniSeznamyASlovniky()
	{
		string[] poleJmen = new string[] { "Denisa", "Iva" };
		List<string> seznamJmen = new List<string>();
		seznamJmen.Add("Jarda");
		seznamJmen.Add("Vitek");
		seznamJmen.AddRange(new string[] { "Denisa", "Iva" });

		foreach (string jmeno in seznamJmen)
		{
			Console.WriteLine(jmeno);
		}

		Console.WriteLine();
		seznamJmen.Remove("Jarda");

		foreach (string jmeno in seznamJmen)
		{
			Console.WriteLine(jmeno);
		}

		Console.WriteLine();
		seznamJmen.Sort();
		foreach (string jmeno in seznamJmen)
		{
			Console.WriteLine(jmeno);
		}

		Console.WriteLine();
		seznamJmen.Clear();
		foreach (string jmeno in seznamJmen)
		{
			Console.WriteLine(jmeno);
		}

		Dictionary<string, string> slovnikJmenoNaTelefon = new Dictionary<string, string>();
		slovnikJmenoNaTelefon.Add("Jarda", "123456789");
		slovnikJmenoNaTelefon.Add("Vitek", "777777777");

		Console.WriteLine(slovnikJmenoNaTelefon["Vitek"]);

		string telefon;
		if (!slovnikJmenoNaTelefon.TryGetValue("Iva", out telefon))
		{
			Console.WriteLine("Iva nema telefon");
		}
	}
}
