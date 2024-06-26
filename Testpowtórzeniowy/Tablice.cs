﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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
                Console.WriteLine(tab[i] + ", ");
            }
        }
        public int[] Tworzenie_tablicy()
        {
            //pobierammy długość tablicy od użytkownika
            Console.WriteLine("Ile znaków ma mieć tablica?");
            int d = int.Parse(Console.ReadLine());
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

        public void Sortowanie_babelkowe(int[] tab)
        {
            int k = tab.Length;
            while (k > 0)
            {
                for (int i = 0; i < k-1;i++)
                {
                    if (tab[i] > tab[i+1])
                    {
                        int nazwa = tab[i];
                        tab[i] = tab[i+1];
                        tab[i+1] = nazwa;
                    }
                }
                k--;
            }
                
        
        } 
        public void Przeszukaj(int[] tab)
        {
            Console.WriteLine("Jakie liczby Pan szuka?");
            int liczba = int.Parse(Console.ReadLine());
            bool szukana = false;
            int ile_powtorzen = 0;
            for (int i = 0;i < tab.Length;i++)
            {
                if (tab[i]==liczba)
                {
                    szukana = true;
                    ile_powtorzen++;
                }
                
            }
            if(szukana == true)
            {
                Console.WriteLine($"Liczby jest w tablicy, występuje {ile_powtorzen} razy.");
            }
            else { Console.WriteLine("Nie występuje"); }
        }
       
    }
}
