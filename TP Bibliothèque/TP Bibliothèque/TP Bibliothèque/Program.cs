using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dllBibliothèque;


namespace TP_Bibliothèque
{
    class Program
    {
        static void Main(string[] args)
        {
            Bibliotheque b = Bibliotheque.CreateBibliotheque("bibliotheque.txt");
            

            char choix = ' ';
            while (choix != 'z')
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

        private static void CreerLivreAuteur(Bibliotheque b) //corriger erreur instanciation auteur
        {
            
            string nomAuteur, prenomAuteur;
            int anneeNaissanceAuteur, anneeDecesAuteur; 
            string titreLivre, genreLivre, auteurLivre; 
            int dateParution;
            
            /* L'utilisateur saisit pour l'auteur */
            Console.WriteLine("Saisir le nom de l'auteur");
            nomAuteur = Console.ReadLine();

            Console.WriteLine("Saisir le prénom de l'auteur");
            prenomAuteur = Console.ReadLine();

            Console.WriteLine("Saisir l'année de naissance de l'auteur");
            anneeNaissanceAuteur = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Saisir l'année de décès l'auteur");
            anneeDecesAuteur = Convert.ToInt32(Console.ReadLine());

            /* L'utilisateur saisit pour le livre */
            Console.WriteLine("Saisir le titre du livre");
            titreLivre = Console.ReadLine();

            Console.WriteLine("Saisir le genre du livre");
            genreLivre = Console.ReadLine();

            Console.WriteLine("Saisir la date de parution du livre");
            dateParution = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Saisir l'auteur");
            auteurLivre = Console.ReadLine();

            Auteur.CreateAuteur(anneeNaissanceAuteur, anneeDecesAuteur, nomAuteur, prenomAuteur);
            Livre.CreateLivre(titreLivre, genreLivre, , dateParution);
            
            Console.WriteLine("Un livre à été ajouté à la bibliothèque");

            


        }

        private static void RechercheLivreTitre(Bibliotheque b) 
        {
            Livre Lelivre;
            string titre;
            Console.WriteLine("Veuillez entrer le titre du livre");
            titre = Console.ReadLine();
            Lelivre = b.GetLivre(titre);
            if (Lelivre != null)
            {
                Console.WriteLine("{0}/{1}", Lelivre.GetTitre(), Lelivre.GetAuteur(), Lelivre.GetAnneeSortie());
            }
            else
            {
                Console.WriteLine("Le livre n'est pas présent");
            }
            
            
        }

        private static void RechercheLivrePosition(Bibliotheque b)
        {
            int num;
            Console.WriteLine("Saisir le numéro du livre");
            num = Convert.ToInt32(Console.ReadLine());
            if (num < 0)
            {
                Console.WriteLine("Veuillez tapez un nombre entre 0 et le nombres de livres que possède la bibliothèque");
            }
            else
                if (num >= 0)
                {
                    Livre l;
                    l = b.GetLivre(num);
                    Console.WriteLine(l.GetTitre());
                }
                else
                    if (num > b.GetCountLivres())
                    {
                        Console.WriteLine("Pas de livre existant");
                    }
        }

        private static void AfficherLivresAuteur(Bibliotheque b)
        {
            Console.WriteLine("Titre/Genre/DateParution/NomAuteur/PrénomAuteur");
            Livre l;
            Auteur a;
            int i = 0;
            while(i<b.GetCountLivres())
            {
                l = b.GetLivre(i);
                a = b.GetAuteur(i); //plante au lieux de retourner sur les choix
                Console.WriteLine("{0}/{1}/{2}/{3}/{4}",l.GetTitre(), l.GetGenre(), l.GetAnneeSortie(), a.GetNom(), a.GetPrenom());
                i++;
            }
        }

        private static void AfficherAuteurs(Bibliotheque b)
        {
            Console.WriteLine("Nom/Prénom/AnnéeNaissance/AnnéeDécès/Age");
            Auteur a;
            int i = 0;
            while (i < b.GetCountAuteurs())
            {
                a= b.GetAuteur(i);
                Console.WriteLine("{0}/{1}/{2}/{3}/{4}", a.GetNom(), a.GetPrenom(), a.GetAnneeNaissance(), a.GetAnneeDeces(), a.GetAnneeDeces()-a.GetAnneeNaissance());
                i++;
                
            }
        }


        private static void CaracteristiqueBibliotheque(Bibliotheque b)
        {
            Console.WriteLine("La bibliothèque contient {0} livres \n écrits par {1} auteurs \n elle a été chargé à partir du fichier {2}", b.GetCountLivres(), b.GetCountAuteurs(), b.GetFichier());  
        }

        private static void AfficherLivres(Bibliotheque b)
        {
            Console.WriteLine("Titre/Genre/date de parution");
            Livre l;
            int i = 0;
            while (i < b.GetCountLivres())
            {
                l = b.GetLivre(i);
                Console.WriteLine("{0}/{1}/{2}", l.GetTitre(), l.GetGenre(), l.GetAnneeSortie());
                i++;
                
            }
        }
    }
}
