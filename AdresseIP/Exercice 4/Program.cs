using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdressageIP;

namespace Exercice_4
{
    class Program
    {
        static void Main(string[] args)
        {
            AdresseIP ip1, ip2, ip3;
            string[] adress = new string[2];;
            


            ip1 = AdresseIP.GetInstance(77, 180, 2, 81);
            ip2 = AdresseIP.GetInstance(172, 16, 0, 21);
            ip3 = AdresseIP.GetInstance(192, 168, 1, 36);

            

            
            Console.ReadLine();
        }
    }
}
