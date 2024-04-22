using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testpowtórzeniowy
{
    public class Tablice
    {
        public void Wyswietl(int[] tab) 
        {
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(tab[i]+ ", ");
            }
        }
        public int[] Tworzenie_tablicy()
        {
            //pobierammy długość tablicy od użytkownika
            Console.WriteLine("Ile znaków ma mieć tablica?");
            int d=int.Parse(Console.ReadLine());
            //tworsymy pustą tablice
            int[] ints = new int[d];

            //dodajemy kolejne elementy do tablicy
            for (int i = 0; i < d; i++)
            {
                Console.Write("Podaj kolejny element: ");
                ints[i] = int.Parse(Console.ReadLine());
            }
            return ints;
        }
    }
}
