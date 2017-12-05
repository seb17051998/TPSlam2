using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdressageIP;

namespace Exercice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            AdresseIP ip1, reseau;
            ip1 = AdresseIP.GetInstance(172, 10, 15, 17);
            reseau = AdresseIP.GetInstance(172, 10, 0, 0);
           // Masque = AdresseIP.GetInstance(ip1.Masque());
            
            Console.WriteLine("Adresse ip en binaire {0}",ip1.AdresseIpBinaire());
            Console.WriteLine("Masque en binaire {0}",ip1.Masque().AdresseIpBinaire());
            Console.WriteLine("Adresse réseau en binaire {0}",reseau.AdresseIpBinaire());
            
            
            
            Console.ReadLine();
        }
    }
}
