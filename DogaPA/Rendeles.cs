using System;
namespace DogaPA
{
	public class Rendeles {

    	public int ID { get; set; }
    	public Felhasznalo Vevo { get; set; }
    	public List<Termek> RendeltTermekek { get; set; }
    	public FizetesiMod FizetesiMod { get; set; }
    	public DateTime RendelesIdeje { get; set; }

    	public Rendeles(int id, Felhasznalo vevo, List<Termek> rendeltTermekek, FizetesiMod fizetesiMod)
    	{
        	ID = id;
        	Vevo = vevo;
        	RendeltTermekek = rendeltTermekek;
        	FizetesiMod = fizetesiMod;
        	RendelesIdeje = DateTime.Now;
    	}

    	public void RendeltTermekekListazasa()
    	{
        	Console.WriteLine($"A rendelt termékek listája:");
        	foreach (var termek in RendeltTermekek)
        	{
            	Console.WriteLine(termek.Nev);
        	}
    	}

		public void RendelestElvegzett()
		{
            Vevo.RendelesHozzaadasa(this);
		}

		public void RendelésAdatainakKiirasa()
		{
			Console.WriteLine($"Rendelés ID: {ID}, Rendelés ideje: {RendelesIdeje}");
			Console.WriteLine("Rendelt termékek:");
			RendeltTermekekListazasa();
			Console.WriteLine($"Fizetési mód: {FizetesiMod.Megnevezes}");
		}

		public int RendelesOsszegzes()
		{
			int osszeg = 0;
			foreach (var termek in RendeltTermekek)
			{
				osszeg += termek.Ar;
			}
			Console.WriteLine($"A rendelés értéke: {osszeg}");
			return osszeg;
		}
	}
}

