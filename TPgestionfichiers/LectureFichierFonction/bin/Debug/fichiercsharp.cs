using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercice_4_Menu_Fonction
{
    class Program
    {
        static int choix= 0;
        static int bs;
        static string Mes;
        static int nbrepeat;
        static double x, n;

        static void Main(string[] args) 
        {
            
            double resultat = 0;
            while (choix <= 4)
            {
                Console.WriteLine("1 - Somme des n premiers entiers");
                Console.WriteLine("2 - réplication de message");
                Console.WriteLine("3 - somme des carrés des n premiers nombres entiers");
                Console.WriteLine("4 - élévation à la puissance (x n)");
                Console.WriteLine("5 - fin du programme");
                choix = Convert.ToInt32(Console.ReadLine());
                switch (choix)
                {
                    case 1:
                        {
                            Console.WriteLine("Donner bs");
                            bs = Int32.Parse(Console.ReadLine());
                            resultat = SommeNPremiersEntiers(bs);
                            Console.WriteLine(resultat);
                            Console.ReadLine();
                            break;   
                        }
                    case 2:
                        {
                            Console.WriteLine("Saisir un nombre entier dont le nombre de fois le message s'affichera :");
                            nbrepeat = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Saisir le message à afficher");
                            Mes = Console.ReadLine();
                            resultat = Message(nbrepeat);
       
                            Console.ReadLine();
                            break;
                        }
                    case 3: 
                        {
                            Console.WriteLine("Saisir un nombre");
                            bs = Convert.ToInt32(Console.ReadLine());
                            resultat = nbcarre(bs);
                            Console.WriteLine(resultat);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Saisir un nombre entier");
                            x = Double.Parse(Console.ReadLine());


                            Console.WriteLine("Saisir n");
                            n = Double.Parse(Console.ReadLine());

                            resultat = puissance(n,x);
                            Console.WriteLine(resultat);
                            break;

                        }
                    
                    
                }

            }
        }
        static int SommeNPremiersEntiers(int borneSup) //Fonction SommeNPremiersEntiers
        {
            int i, result = bs;
            for (i = 1; i <= borneSup; i++)
            {
                result = result + i;
            }
            return result;
        }
        static int Message(int nbrepeat) //Fonction Message
        {
            int i, result = nbrepeat;
            for (i = 1; i <= nbrepeat; i++)
            {
                Console.WriteLine(Mes);
                
            }
            return result;
        }
        static double nbcarre(int bornsup) //Fonction Somme au carré
        {
            int i;
            double result = bs;
            for (i = 1; i <= bornsup; i++)
            {
                result = result + Math.Pow(i, 2);
            }
            return result;
        }
        static double puissance(double n, double x) //Fonction Elevation puissance
        {
            double resultat;
            resultat = Math.Pow(x, n);
            return resultat;
        }

       
    }
}