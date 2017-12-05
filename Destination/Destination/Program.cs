using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Destination
{
    class Program
    {
        static void Main(string[] args)
        {
            //Données membres
            Destination v1 = new Destination("Maroc", "Club");
            int v2 = 4;
            Destination v3;
            Destination[] tabV;
            tabV = new Destination[v2];
            tabV[0] = v1;
            tabV[1] = new Destination("Auvergne", "Chambre d'hôtes");
            tabV[2] = tabV[1];

            Console.WriteLine(tabV[0].ToString());
            Console.WriteLine(tabV[1].ToString());
            Console.WriteLine(tabV[2].ToString());
            Console.WriteLine(tabV[3].ToString());
            Console.ReadLine();

        }
    }
}
