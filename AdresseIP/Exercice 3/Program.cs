using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdressageIP;
namespace Exercice_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int octet1, octet2,  octet3,  octet4;
            string s;
            AdresseIP ip;
            s = Console.ReadLine();
            ip = AdresseIP.GetInstance(s);

            Console.WriteLine("Saisir le 1er Octet");
            octet1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Saisir le 2er Octet");
            octet2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Saisir le 3er Octet");
            octet3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Saisir le 4er Octet");
            octet4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(ip.ToString());
            Console.ReadLine();

 
        }
    }
}
