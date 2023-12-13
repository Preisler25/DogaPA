using System;
namespace DogaPA
{
	public class Kosar
	{
		public List<Termek> termekek { get; set; }
		public Kosar(){

		}

		public void TermekHozzaadasa(Termek termek){
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

		public void TermekMennyisegKiiras(Termek termek){
			Console.WriteLine(termek.Raktaron);
		}

		public void TermekMennyisegNovel(Termek termek, int mennyiseg){
			for (int i = 0; i < mennyiseg; i++)
			{
				termekek.add(termek);
			}
		}

		public void TermekMennyisegCsokken(Termek termek, int mennyiseg){
			for (int i = 0; i < mennyiseg; i++)
			{
				termekek.remove(termek);
			}
		}
	}
}

