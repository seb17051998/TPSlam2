using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Exercice_5
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList nbrelatif;
            nbrelatif = new ArrayList();
            int compteur;
            int nombre;

            Console.WriteLine("Combien de fois voulez vous entrez ce nombre");
            compteur = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < compteur; i++)
            {
                Console.WriteLine("Saisir le {0} nombre", i+1);
                nombre = Convert.ToInt32(Console.ReadLine());
                nbrelatif.Add(nombre);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Voici les nombres que vous avez saisit");
            foreach (int a in nbrelatif)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine(" ");
            for (int i = 0; i < nbrelatif.Count; i++)
            {

                if ((int)nbrelatif[i] < 0)
                {
                    Console.WriteLine("Le nombre {0} est négatif", nbrelatif[i]);
                }
                else
                {
                    Console.WriteLine("Le nombre {0} est positif", nbrelatif[i]);
                }
            }

            Console.ReadLine();

        }

       
    }
}
