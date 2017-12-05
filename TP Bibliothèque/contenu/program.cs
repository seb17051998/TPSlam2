using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dllBibliothèque;

namespace GestionBibliothèque
{
    class Program
    {
        static void Main(string[] args)
        {
            Bibliotheque b = Bibliotheque.CreateBibliotheque("bibliotheque.txt");
            char choix = ' ';
            while(choix!='z')
            {
                choix = Menu();
                Traiter(choix, b);
                Console.ReadLine();
                Console.Clear();
            }
        }

        private static char Menu()
        {
            char choix;
            Console.WriteLine("0 : Caractéristiques de la bibliothèque");
            Console.WriteLine("1 : Liste des livres");
            Console.WriteLine("2 : Liste des auteurs");
            Console.WriteLine("3 : Liste des livres avec leur auteur");
            Console.WriteLine("4 : Rechercher un livre par sa position");
            Console.WriteLine("5 : Rechercher un livre par son titre");
            Console.WriteLine("6 : Créer un Livre et son auteur");
            Console.WriteLine("7 : Créer un Livre en choisissant son auteur");
            Console.WriteLine("8 : Supprimer un Livre");
            Console.WriteLine("9 : Liste des Livres parus avant");
            Console.WriteLine("a : Liste des livres d'un genre");
            Console.WriteLine("b : Liste des livres d'un auteur");
            Console.WriteLine("y : Enregistrer les modifications");
            Console.WriteLine("z : Quitter \n");
            Console.Write("Votre choix : ");

            choix = Console.ReadLine()[0];
            return choix;
        }

        private static void Traiter(char choix, Bibliotheque b)
        {
            Console.WriteLine("");
            switch (choix)
            {
                case '0':
                    CaracteristiqueBibliotheque(b);
                    break;
                case '1':
                    AfficherLivres(b);
                    break;
                case '2':
                    AfficherAuteurs(b);
                    break;
                case '3':
                    AfficherLivresAuteur(b);
                    break;
                case '4':
                    RechercheLivrePosition(b);
                    break;
                case '5':
                    RechercheLivreTitre(b);
                    break;
                case '6':
                    CreerLivreAuteur(b);
                    break;
                case '7':
                    CreerLivreChoixAuteur(b);
                    break;
                case '8':
                    SupprimerLivre(b);
                    break;
                case '9':
                    ListeLivreDateParution(b);
                    break;
                case 'a':
                    ListeLivreGenre(b);
                    break;
                case 'b':
                    ListeLivreAuteur(b);
                    break;
                case 'y':
                    EnregistrerBibliotheque(b);
                    break;
            }
            if (choix != 'z')
            {
                Console.Write("continuer...");
            }
        }

        private static void EnregistrerBibliotheque(Bibliotheque b)
        {
            throw new NotImplementedException();
        }

        private static void ListeLivreAuteur(Bibliotheque b)
        {
            throw new NotImplementedException();
        }

        private static void ListeLivreGenre(Bibliotheque b)
        {
            throw new NotImplementedException();
        }

        private static void ListeLivreDateParution(Bibliotheque b)
        {
            throw new NotImplementedException();
        }

        private static void SupprimerLivre(Bibliotheque b)
        {
            throw new NotImplementedException();
        }

        private static void CreerLivreChoixAuteur(Bibliotheque b)
        {
            throw new NotImplementedException();
        }

        private static void CreerLivreAuteur(Bibliotheque b)
        {
            throw new NotImplementedException();
        }

        private static void RechercheLivreTitre(Bibliotheque b)
        {
            throw new NotImplementedException();
        }

        private static void RechercheLivrePosition(Bibliotheque b)
        {
            throw new NotImplementedException();
        }

        private static void AfficherLivresAuteur(Bibliotheque b)
        {
            throw new NotImplementedException();
        }

        private static void AfficherAuteurs(Bibliotheque b)
        {
            throw new NotImplementedException();
        }


        private static void CaracteristiqueBibliotheque(Bibliotheque b)
        {
			 throw new NotImplementedException();
        }

        private static void AfficherLivres(Bibliotheque b)
        {
			throw new NotImplementedException();
        }
    }
}
