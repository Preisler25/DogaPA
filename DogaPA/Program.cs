namespace DogaPA;

class Program
{
    static void Main(string[] args)

    {
        // Teszteljük a Termek osztályt
        Console.WriteLine("1. Termek osztály tesztelése:");
        Console.WriteLine();

        // 1.1 Termék létrehozása és adatainak kiírása
        Termek termek1 = new Termek(1, "Laptop", 1000, 50);
        Termek termek2 = new Termek(2, "Smartphone", 500, 100);
        Termek termek3 = new Termek(3, "Táblagép", 800, 30);

        Console.WriteLine("1.1 Termék létrehozása és adatainak kiírása:");
        termek1.TermekAdatainakKiirasa();
        termek2.TermekAdatainakKiirasa();
        termek3.TermekAdatainakKiirasa();
        Console.WriteLine();

        // 1.2 Raktárfrissítés és rendelés
        Console.WriteLine("1.2 Raktárfrissítés és rendelés:");
        termek1.RaktarFrissites(10);
        termek2.RaktarFrissites(-5);

        termek1.TermekAdatainakKiirasa();
        termek2.TermekAdatainakKiirasa();
        termek3.TermekAdatainakKiirasa();
        Console.WriteLine();

        // Teszteljük a Kosar osztályt
        Console.WriteLine("2. Kosar osztály tesztelése:");
        Console.WriteLine();

        // 2.1 Termék hozzáadása és törlése a kosárból
        Kosar kosar = new Kosar();
        kosar.TermekHozzaadasa(termek1);
        kosar.TermekHozzaadasa(termek2);
        kosar.TermekHozzaadasa(termek3);

        Console.WriteLine("2.1 Termék hozzáadása a kosárhoz:");
        kosar.KosarTartalma();

        kosar.TermekTorlese(termek2);
        Console.WriteLine("2.1 Termék törlése a kosárból:");
        kosar.KosarTartalma();
        Console.WriteLine();

        // 2.2 Kosár összértékének ellenőrzése
        Console.WriteLine("2.2 Kosár összértékének ellenőrzése:");
        kosar.KosarAra();
        Console.WriteLine();

        // Teszteljük a Felhasznalo osztályt
        Console.WriteLine("3. Felhasznalo osztály tesztelése:");
        Console.WriteLine();

        // 3.1 Felhasználó létrehozása és profiladatainak megjelenítése
        Felhasznalo felhasznalo1 = new Felhasznalo(1, "John Doe", "john.doe@example.com");
        Felhasznalo felhasznalo2 = new Felhasznalo(2, "Jane Doe", "jane.doe@example.com");

        Console.WriteLine("3.1 Felhasználó létrehozása és profiladatainak megjelenítése:");
        felhasznalo1.ProfilAdatainakKiirasa();
        felhasznalo2.ProfilAdatainakKiirasa();
        Console.WriteLine();

        // 3.2 Felhasználó rendeléseinek ellenőrzése
        Console.WriteLine("3.2 Felhasználó rendeléseinek ellenőrzése:");
        felhasznalo1.Kosar.TermekHozzaadasa(termek1);
        felhasznalo1.Kosar.TermekHozzaadasa(termek2);
        felhasznalo1.RendeleseimListazasa();
        Console.WriteLine();

        // Teszteljük a FizetesiMod osztályt
        Console.WriteLine("4. FizetesiMod osztály tesztelése:");
        Console.WriteLine();

        // 4.1 Fizetési módok kezelése
        FizetesiMod fizetes1 = new FizetesiMod(1, "Bankkártya", "Bankkártyás fizetés");
        FizetesiMod fizetes2 = new FizetesiMod(2, "Utánvét", "Készpénzzel a futárnak");

        Console.WriteLine("4.1 Fizetési módok kezelése:");
        fizetes1.FizetesiModAdatainakKiirasa();
        fizetes2.FizetesiModAdatainakKiirasa();

        fizetes1.FizetesiModTorlese();
        Console.WriteLine("4.1 Fizetési mód törlése:");
        fizetes2.FizetesiModAdatainakKiirasa();
        Console.WriteLine();

        // 4.2 Új fizetési mód hozzáadása
        Console.WriteLine("4.2 Új fizetési mód hozzáadása:");
        fizetes1.FizetesiModLetrehozas();
        fizetes1.FizetesiModAdatainakKiirasa();

        Console.ReadKey();
    }
}
