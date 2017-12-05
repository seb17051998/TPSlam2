using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tp_Classe_Bidon
{
    class Bidon
    {
        // données membres de l'objet
        private int contenance;
        private int contenanceMax;
        private string couleur;
        private bool bouchon = false;
        

        // constructeur
        public Bidon(string laCouleur, int laContenanceMax)
        {
            contenance = 0;
            couleur = laCouleur;
            contenanceMax = laContenanceMax;
        }
        // Accesseurs
        //public int GetContenance
        //{
            //return get this.contenance;
        //}

        // méthodes: fonctions ou procédures
        
        //Ouvrir le bouchon
        public void Ouvrir()
        {
            bouchon = true;
        }

        //Fermer le bouchon
        public void Fermer()
        {
            bouchon = false;
        }

        public void Remplir(int quantite)
        {
            if (bouchon == true)
            {
                if (contenance + quantite > contenanceMax)
                {
                    int surplus = contenance + quantite - contenanceMax;
                    Console.WriteLine("ça déborde de {0} litre(s) sur le bidon de couleur {1}", surplus, couleur);
                    contenance = contenanceMax;
                }
                else
                {
                    contenance = contenance + quantite;
                }
            }
            else if (bouchon == false)
            {
                Console.WriteLine("Erreur, le bouchon est fermé du bidon {0}", couleur);
            }
        }

        //Remplir au maximum le bidon
        public void RemplirMax()
        {
            if (bouchon == true)
            {
                contenance = contenanceMax - contenance;
            }
            else if (bouchon == false)
            {
                Console.WriteLine("Erreur, le bouchon est fermé du bidon {0}", couleur);
            }
        }

        public void Vider(int quantite)
        {
            if (bouchon == true)
            {
                if (contenance - quantite < 0)
                {
                    int sousquantite = contenance - quantite;
                    Console.WriteLine("Vous n'avez pu prélever que {0} litres sur les {1} demandés sur le bidon de couleur {2}", sousquantite, quantite, couleur);
                }
                else
                {
                    contenance = contenance - quantite;
                }
            }
            else if (bouchon == false)
            {
                Console.WriteLine("Erreur, le bouchon est fermé du bidon {0}",couleur);
            }
        } 

        //Vider entierement le bidon
        public void ViderMax()
        {
            if (bouchon == true)
            {
                contenance = contenance - contenance;
            }
            else if (bouchon == false)
            {
                Console.WriteLine("Erreur, le bouchon est fermé du bidon {0}",couleur);
            }
        }

        public void TransvaderDans(int couleur, int quantite)
        {
            contenance = contenance - contenance;
            quantite = contenance + contenance;
        }

        // méthode retournant un bidon sous la forme d'une chaine de caractère
        public string ToString()
        {
            return string.Format("Un bidon de {0} litre(s) contenant {1} litre(s) de couleur {2}, le bouchon est {3}", contenanceMax, contenance, couleur, bouchon);
        }
    }
}
