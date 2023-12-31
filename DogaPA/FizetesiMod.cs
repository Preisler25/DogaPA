﻿using System;
namespace DogaPA
{
	public class FizetesiMod{
		public int ID { get; set; }
		public string Megnevezes { get; set; }
		public string Leiras { get; set; }

		public FizetesiMod(int id, string megnevezes, string leiras)
		{
			ID = id;
			Megnevezes = megnevezes;
			Leiras = leiras;
		}

		public void FizetesiModAdatainakKiirasa()
		{
			Console.WriteLine($"ID: {ID}, Megnevezés: {Megnevezes}, Leírás: {Leiras}");
		}

		public void FizetesiModValasztas()
		{
			Console.WriteLine($"Fizetési mód kiválasztva: {Megnevezes}");
		}

		public void FizetesiModTorlese()
		{
			Console.WriteLine($"Fizetési mód törölve: {Megnevezes}");
		}

		public void FizetesiModModositasa(string ujLeiras)
		{
			Leiras = ujLeiras;
		}

		public void FizetesiModLetrehozas()
		{
			Console.WriteLine($"Fizetési mód létrehozva: {Megnevezes}");
		}
	}
}

