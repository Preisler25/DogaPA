using System;
namespace DogaPA
{
	public class Termek
	{
		public int ID { get; set; }
		public string Nev { get; set; }
		public int Ar { get; set; }
		public int Raktaron { get; set; }
		public Termek(int id, string nev, int ar, int raktaron)
		{
			ID = id;
			Nev = nev;
			Ar = ar;
			Raktaron = raktaron;
		}

		public void RaktarFrissites(int mennyiseg)
		{
			Raktaron += mennyiseg;
		}

		public void ArBeallitas(int ujAr)
		{
			Ar = ujAr;
		}

		public void TermekRendelese(int mennyiseg)
		{
			if (Raktaron >= mennyiseg)
			{
				Raktaron -= mennyiseg;
			}
			else
			{
				Console.WriteLine("Nincs ennyi termék raktáron!");
			}
		}

		public void TermekAdatainakKiirasa()
		{
			Console.WriteLine("Termék ID: {0}", ID);
			Console.WriteLine("Termék neve: {0}", Nev);
			Console.WriteLine("Termék ára: {0}", Ar);
			Console.WriteLine("Termék raktáron lévő mennyisége: {0}", Raktaron);
		}
		
		public void TermekAraNovel(int szazalek)
		{
			Ar += Ar * szazalek / 100;
		}

		public void TermekAraCsokken(int szazalek)
		{
			Ar -= Ar * szazalek / 100;
		}

		public void TermekAraVisszaallitas(int alapAr)
		{
			Ar = alapAr;
		}

		public void TermekAraKiiras()
		{
			Console.WriteLine("Termék ára: {0}", Ar);
		}
	}
}

