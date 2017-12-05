using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace TPManipulationCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList valnum;
            valnum = new ArrayList();

            valnum.Add(1);
            valnum.Add(2);
            valnum.Add(3);
            valnum.Add(4);
            valnum.Add(5);
            valnum.Add(6);
            valnum.Add(7);

            Console.WriteLine("Affichage des 7 éléments de la collection avant la remise à zéro");
            Console.WriteLine(" ");

            foreach (int a in valnum)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine(" ");
            Console.WriteLine("Affichage des 7 éléments de la collection après la remise à zéro");
            Console.WriteLine(" ");

            for (int i = 0; i < valnum.Count; i=i+1)
            {
                valnum[i] = 0;
            }

            foreach (int a in valnum)
            {
                Console.WriteLine(a);
            }

            Console.ReadLine();
        }
    }
}
