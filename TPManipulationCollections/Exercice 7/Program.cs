using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Exercice_7
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList collection1;
            collection1 = new ArrayList();

            ArrayList collection2;
            collection2 = new ArrayList();
            int compteur;
            int c1;
            int c2;
            int addition = 0;

            Console.WriteLine("Saisir le nombre de chiffres au maximum dans une collection");
            compteur = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < compteur; i++)
            {
                Console.WriteLine("Saisir le {0} nombre de la première collection", i + 1);
                c1 = Convert.ToInt32(Console.ReadLine());
                collection1.Add(c1);
            }

            for (int i = 0; i < compteur; i++)
            {
                Console.WriteLine("Saisir le {0} nombre de la deuxième collection", i+1);
                c2 = Convert.ToInt32(Console.ReadLine());
                collection2.Add(c2);
            }

            /*foreach (int a in collection1)
            {
                Console.WriteLine(a);
            }

            foreach (int b in collection2)
            {
                Console.WriteLine(b);
            }*/

            for (int i = 0; i < collection1.Count; i++)
            {
                addition = (int)collection1[i] + (int)collection2[i];
                Console.WriteLine("Le résultat de la {0} case est {1}",i+1 ,addition);
            }

            
            Console.ReadLine();
        }
    }
}
