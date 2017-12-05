using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP_Dungeon_Crawler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Déclaration des variables
            
            Personnage p1;
            Personnage p2;
            Personnage p3;
            Personnage p4;
            Personnage p5;
            int pvmax;
            int laforce;
            int agi;
            string nompersonnage;
            string peuplepersonnage;

            //Instanciation
            p1 = new Personnage(120, 40, 15, "Azog", "Orc");
            p2 = new Personnage(80, 20, 50, "Bilbo", "Hobbit");

            p2.Frapper(p1, 5,"Orc");
            p2.Frapper(p1, 8, "Orc");
            p2.Frapper(p1, 10, "Orc");

            p1.BoirePotion(200);
            if (p1.EstVivant())
            {
                Console.WriteLine("Tout va bien");
            }
            else
            {
                Console.WriteLine("Je crois que j'ai une petite défaillance");
            }

            //Saisie du troisième personnage
            Console.WriteLine("Saisir le nombre de points de vie maximum");
            pvmax = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Saisir le nombre de points de force");
            laforce = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Saisir le nombre de points d'agilité");
            agi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Saisir le nom de votre personnage");
            nompersonnage = Console.ReadLine();
            Console.WriteLine("Saisir le nom du peuple de votre personnage");
            peuplepersonnage = Console.ReadLine();

            // instanciation du 3ème personnage
            p3 = new Personnage(pvmax, laforce, agi, nompersonnage, peuplepersonnage);

            // Saisie du 4ème personnage
            Console.WriteLine("Saisir le nombre de points de vie maximum");
            pvmax = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Saisir le nombre de points de force");
            laforce = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Saisir le nombre de points d'agilité");
            agi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Saisir le nom de votre personnage");
            nompersonnage = Console.ReadLine();
            Console.WriteLine("Saisir le nom du peuple de votre personnage");
            peuplepersonnage = Console.ReadLine();

            // instanciation du 4ème personnage
            p4 = new Personnage(pvmax, laforce, agi, nompersonnage, peuplepersonnage);

            // Saisie du 5ème personnage
            Console.WriteLine("Saisir le nombre de points de vie maximum");
            pvmax = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Saisir le nombre de points de force");
            laforce = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Saisir le nombre de points d'agilité");
            agi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Saisir le nom de votre personnage");
            nompersonnage = Console.ReadLine();
            Console.WriteLine("Saisir le nom du peuple de votre personnage");
            peuplepersonnage = Console.ReadLine();

            // Instanciation du 5ème personnage
            p5 = new Personnage(pvmax, laforce, agi, nompersonnage, peuplepersonnage);
           

            Console.ReadLine();
        }
    }
}
