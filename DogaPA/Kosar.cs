using System;
namespace DogaPA
{
	public class Kosar
	{
		public List<Termek> termekek { get; set; }
		public Kosar(){
			termekek = new List<Termek>();
		}

		public void TermekHozzaadasa(Termek termek){
			termek.TermekAraKiiras();
			termekek.Add(termek);
		}

		public void TermekTorlese(Termek termek){
			termekek.Remove(termek);
		}

		public void KosarUritese(){
			termekek.Clear();
		}

		public void KosarTartalma(){
			foreach (var item in termekek)
			{
				Console.WriteLine(item.Nev);
			}
		}

		public void KosarAra(){
			int osszeg = 0;
			foreach (var item in termekek)
			{
				osszeg += item.Ar;
			}
			Console.WriteLine(osszeg);
		}

		public void TermekMennyisegKiiras(Termek termek)
    	{
        	int mennyiseg = termekek.Count(t => t == termek);
        	Console.WriteLine($"A kosárban lévő {termek.Nev} mennyisége: {mennyiseg}");
    	}

    	public void TermekMennyisegNovel(Termek termek, int mennyiseg)
    	{
        	for (int i = 0; i < mennyiseg; i++)
        	{
            	termekek.Add(termek);
        	}
    	}

    	public void TermekMennyisegCsokken(Termek termek, int mennyiseg)
    	{
        	for (int i = 0; i < mennyiseg; i++)
        	{
            	termekek.Remove(termek);
        	}
    	}
	}
}

