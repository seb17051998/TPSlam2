                                            /* BUNEL Sébastien BTS SIO 1 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DllConcession;
using System.Collections;

namespace DSConcession
{
    class Program
    {
        public static string color;
        static void Main(string[] args)
        {

            Concession MontmorencyReparation;
            // CreateConcession méthode static vous permettant d'instancier des objets concession
            MontmorencyReparation = Concession.CreateConcession(12);
            ListeVoitureCouleur(MontmorencyReparation);
            //ValeurConcession(MontmorencyReparation);
            NouvelleVoiture(MontmorencyReparation);
            AfficherPrix(MontmorencyReparation.GetVoiture(0));
            Console.ReadLine();
        }

        static void ListeVoitureCouleur(Concession c)
        {
            int choix;
            
            Console.WriteLine("1 : Rouge");
            Console.WriteLine("2 : Jaune");
            Console.WriteLine("3 : Orange");
            Console.WriteLine("4 : Vert");
            Console.WriteLine("5 : Bleu");
            Console.WriteLine("6 : Gris");
            Console.WriteLine("7 : Noir");
            Console.WriteLine("8 : Marron");
            Console.WriteLine("9 : Violet");
            Console.WriteLine("10 : Blanc");
            Console.WriteLine(" ");
            Console.WriteLine("Choisissez votre couleur");
            choix = Convert.ToInt32(Console.ReadLine());
            

            switch (choix)
            {
                case 1:
                    color = "Rouge";
                    break;
                case 2:
                    color = "Jaune";
                    break;
                case 3:
                    color = "Orange";
                    break;
                case 4:
                    color = "Vert";
                    break;
                case 5:
                    color = "Bleu";
                    break;
                case 6:
                    color = "Gris";
                    break;
                case 7:
                    color = "Noir";
                    break;
                case 8:
                    color = "Marron";
                    break;
                case 9:
                    color = "Violet";
                    break;
                case 10:
                    color = "Blanc";
                    break;
                    
            }


        }

        /*static void ValeurConcession(Concession c) 
        {
        
        }*/

        static void NouvelleVoiture(Concession c)
        {
            
            string immat;
            string coul;
            bool stock;
            string name;
            string mark;
            int price;

            

            Console.WriteLine("Saisir le numéro d'immatriculation de la voiture : ");
            immat = Console.ReadLine();
            coul = color;
            Console.WriteLine("La voiture est il en stock ? Tapez true pour oui et false pour non");
            stock = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Saisir le nom de la voiture");
            name = Console.ReadLine();
            Console.WriteLine("Saisir la marque de la voiture");
            mark = Console.ReadLine();
            Console.WriteLine("Saisir son prix");
            price = Convert.ToInt32(Console.ReadLine());


            Modele mod = Modele.CreateModele(name, mark, price);
            //manque dépassement capacité
            Voiture v = Voiture.CreateVoiture(immat, coul, stock, mod);
            if (stock == true)
            {
                Console.WriteLine("La voiture est en stock");
            }
            else
            {
                Console.WriteLine("La voiture sera commandée");
            }
            c.AjouterVoiture(v);
            Console.WriteLine(v.GetImmatriculation() + v.GetCouleur() + v.GetEnStock() + v.GetModele().GetNom() + v.GetModele().GetMarque() + v.GetModele().GetPrix());
        }

        static void AfficherPrix(Voiture v)
        {
            Console.WriteLine("Immatriculation : {0} \n Modele : {1}\n Nom : {2}\n Marque : {3}\n Prix : {4}\n Direction assisté : {5}\n Airbag : {6}\n CD Autoradio : {7}\n Air Conditionné {8}\n", v.GetImmatriculation(), v.GetModele().GetNom(), v.GetModele().GetMarque(), v.GetModele().GetPrix(), v.GetOption(1).GetPrix(), v.GetOption(2).GetPrix(), v.GetOption(3).GetPrix(), v.GetOption(4).GetPrix());
        
        }

    }
}
