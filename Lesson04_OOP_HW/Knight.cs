using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04_OOP_HW
{
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
	class Knight
    {
		public Weapon Weapon { get; private set; }

		public string Name { get; private set; }

		private int live;
		public int Live
		{
			get
			{
				return live;
			}
			private set
			{
				live = value
						<= 0 ? 1 : value
						> 100 ? 100 : value;
			}
		}
		private int strength;
		public int Strength
		{
			get
			{
				return strength;
			}
			private set
			{
				strength = value <= 0 ? 10 : value;
			}
		}

		private int armor;
		public int Armor
		{
			get
			{
				return armor;
			}
			private set
			{
				armor = value
							< 0 ? 0 : value
							> 50 ? 50 : value;
			}
		}


		public bool IsAlive
		{
			get
			{
				return Live > 0;
			}
		}

		public Knight(string name, int strength, int live = 100, int armor = 50)
		{
			Name = name;
			Strength = strength;
			Live = live;
			Armor = armor;
		}

		public void UtocNa(Knight obet)
		{
			int silaUtoku = this.DejSiluUtoku();
			int poskozeni = obet.DejPoskozeniUtokem(silaUtoku);
			obet.Live -= poskozeni;
		}

		private int DejSiluUtoku()
		{
			return this.Strength;
		}

		private int DejPoskozeniUtokem(int silaUtoku)
		{
			return silaUtoku;
		}

	}

}
