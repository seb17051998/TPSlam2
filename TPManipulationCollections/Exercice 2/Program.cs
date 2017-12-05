using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Exercice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList voyelle;
            voyelle = new ArrayList();

            voyelle.Add("A");
            voyelle.Add("E");
            voyelle.Add("I");
            voyelle.Add("O");
            voyelle.Add("U");
            voyelle.Add("Y");

            foreach (string s in voyelle)
            {
                Console.WriteLine("L'élement qui est dans la collection contenant une voyelle est : {0}",s);
            }

            Console.ReadLine();
        }
    }
}
