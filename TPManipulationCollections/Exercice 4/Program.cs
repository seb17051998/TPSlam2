using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Exercice_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int addition = 0;
            double moyenne;
            ArrayList notes;
            notes = new ArrayList();

            notes.Add("Non noté");
            notes.Add("Non noté");
            notes.Add("Non noté");
            notes.Add("Non noté");
            notes.Add("Non noté");
            notes.Add("Non noté");
            notes.Add("Non noté");
            notes.Add("Non noté");
            notes.Add("Non noté");
            notes.Add("Non noté");

            AfficherString(notes);
            Console.WriteLine("Les {0} notes n'ont pas encore été saisit", notes.Count);
            Console.WriteLine(" ");

            for (int i = 0; i < notes.Count; i++)
            {
                Console.WriteLine("Saisir la {0} note", i + 1);
                n = Convert.ToInt32(Console.ReadLine());
                notes[i] = n;
            }
            Console.WriteLine(" ");
            Console.WriteLine("Voici les 10 notes que vous avez saisit");
            Console.WriteLine(" ");
            AfficherInt(notes);

            Console.WriteLine(" ");
            for (int i = 0; i < notes.Count; i++)
            {
                addition = addition + (int)notes[i];
            }
            Console.WriteLine(moyenne = addition / notes.Count);
            Console.ReadLine();

        }

        // Fonction afficher (chaine de caractère)
        static void AfficherString(ArrayList uneNote)
        {
            foreach (string s in uneNote)
            {
                Console.WriteLine(s);
            }

        }

        // Fonction afficher (entiers)
        static void AfficherInt(ArrayList uneNote)
        {
            foreach (int i in uneNote)
            {
                Console.WriteLine(i);
            }

        }

        
    }
}
