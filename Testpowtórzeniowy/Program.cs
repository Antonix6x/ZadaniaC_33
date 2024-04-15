using Testpowtórzeniowy;

class PlikGłówny
{ //zmienna, która jest odwołaniem do innego skryptu
    
    static void Main(string[] args)
    {
        //To jest baza naszego projektu
        Tablice tab1 = new Tablice();

        int[] tab = tab1.Tworzenie_tablicy();

        for (int i = 0; i < tab.Length; i++)
        {
            Console.WriteLine(tab[i]);
        }
    }
    
}
