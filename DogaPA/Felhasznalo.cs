using System;
namespace DogaPA
{
	public class Felhasznalo
	{
		public int ID { get; set; }
    	public string Nev { get; set; }
    	public string Email { get; set; }
    	public Kosar Kosar { get; set; }

    	public Felhasznalo(int id, string nev, string email)
    	{
        	ID = id;
        	Nev = nev;
        	Email = email;
        	Kosar = new Kosar();
		}

		/*
KosarTartalma(): Kiírja a felhasználó kosarában lévő termékek neveit.
RendeleseimListazasa(): Kiírja a felhasználó rendeléseit.
EmailKuldes(string uzenet): Küld egy e-mailt a felhasználó e-mail címére egy adott üzenettel.
ProfilAdatainakKiirasa(): Kiírja a felhasználó profiladatait.
RendelesekOsszegezes(): Összegzi és kiírja a felhasználó összes rendelésének értékét.
RendelesHozzaadasa(Rendeles rendeles): Hozzáad egy új rendelést a felhasználóhoz.*/
		public void KosarTartalma(){
			Kosar.KosarTartalma();
		}

		public 
	}
}

