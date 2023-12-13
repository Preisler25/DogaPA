using System;
namespace DogaPA
{
	public class Felhasznalo
	{
		public int ID { get; set; }
    	public string Nev { get; set; }
    	public string Email { get; set; }
    	public Kosar Kosar { get; set; }
		public List<Rendeles> Rendeleseim { get; set; }

    	public Felhasznalo(int id, string nev, string email)
    	{
        	ID = id;
        	Nev = nev;
        	Email = email;
        	Kosar = new Kosar();
			Rendeleseim = new List<Rendeles>();
		}

		public void KosarTartalma() {
			Kosar.KosarTartalma();
		}

		public void RendeleseimListazasa(){
			foreach (var rendeles in Rendeleseim)
			{
				rendeles.RendelésAdatainakKiirasa();
			}
		}

		public void EmailKuldes(string uzenet){
			Console.WriteLine($"E-mail küldve a felhasználónak: {Email}, üzenet: {uzenet}");
		}

		public void ProfilAdatainakKiirasa(){
			Console.WriteLine($"Felhasználó ID: {ID}, Felhasználó neve: {Nev}, Felhasználó e-mail címe: {Email}");
		}

		public void RendelesekOsszegezes(){
			int osszeg = 0;
			foreach (var rendeles in Rendeleseim)
			{
				osszeg += rendeles.RendelesOsszegzes();
			}
			Console.WriteLine($"A felhasználó összes rendelésének értéke: {osszeg}");
		}

		public void RendelesHozzaadasa(Rendeles rendeles){
			Rendeleseim.Add(rendeles);
		}
	}
}

