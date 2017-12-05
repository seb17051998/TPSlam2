using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdressageIP;

namespace Exercice_6
{
    class Program
    {
        static void Main(string[] args)
        {
            AdresseIP[] tabIP = new AdresseIP[5];
            int i;
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Entrer une adresse IP");
                string s = Console.ReadLine();
                tabIP[i] = AdresseIP.GetInstance(s);
            }
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine(tabIP[i].ToString());
                Console.WriteLine(tabIP[i].Masque());
            }

            Console.ReadLine();
        }
    }
}
