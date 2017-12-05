using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Exercice_6
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList somme;
            somme = new ArrayList();
            int compteur;
            int nb;
            int addition = 0;

            Console.WriteLine("Saisir le nombre de termes à additionner");
            compteur = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < compteur; i++)
            {
                Console.WriteLine("Saisir le {0}e terme", i+1);
                nb = Convert.ToInt32(Console.ReadLine());
                somme.Add(nb);
            }

            Console.WriteLine(" ");
            Console.WriteLine("Voici les termes que vous avez saisit :");
            foreach (int i in somme)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(" ");

            for (int i = 0; i < somme.Count; i++)
            {
                addition = addition + (int)somme[i];
            }
            Console.WriteLine("Le résultat de cette somme est {0}",addition);

            Console.ReadLine();
        }
    }
}
