using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP_Banque
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*---Test Banque---*");
            Banque b1 = new Banque("LCL");
            Banque b2 = new Banque("Banque populaire");

            Compte c1 = new Compte("Harry tuttle", 0, -200,3000);
            Compte c2 = new Compte("Jill layton", 100, -100, 3000);
            Compte c3 = new Compte("Pikachu", 400, -1000, 10000);

            b1.Add(c1);
            b1.Add(c2);
            c1.Debiter(150);

            

            

            for (int i = 0; i < b1.Count; i++)
            {
                Compte lcl = b1.GetCompte(i);
                Console.WriteLine(lcl.ToString());
            }
            
            Console.WriteLine(b1.ValeurDepotBanque());

           
            Console.ReadLine();
        }
    }
}
