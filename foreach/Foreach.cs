﻿using System;
using System.Collections.Generic;
using System.Collections;

namespace Vsite.CSharp
{
    class Foreach
    {
        static void Main(string[] args)
        {
            string[] imena = new string[] { "Pero", "Janko", "Mijo" };
            Ispiši(imena);

            int[] brojevi = new int[] { 1, 5, 3, 11 };
            Ispiši(brojevi);

            List<double> dablovi = new List<double>();
            dablovi.Add(3.14);
            // : Dodati još 4 različita broja te pozvati metodu Ispiši. Rezultat ispisa prekopirati u datoteku "Foreach.txt" pridruženu projektu
            dablovi.Add(8.14);
            dablovi.Add(4);
            dablovi.Add(-314);
            Ispiši(dablovi);
            Console.ReadKey();
            

        }

        static void Ispiši(IEnumerable kolekcija)
        {
            foreach (var element in kolekcija)
                Console.WriteLine(element);
        }
    }
}
