using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tp_Classe_Bidon
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            Bidon bidonRouge;
            Bidon bidonBlanc;
            Bidon bidonBleu;
            Bidon bidonOrange;
           


            // Création des bidons
            bidonRouge = new Bidon("rouge", 5);
            bidonBlanc = new Bidon("blanc", 5);
            bidonBleu = new Bidon("bleu", 10);
            bidonOrange = new Bidon("orange", 20);
            

            //Manipulation
            //Manipulation sur le bidon rouge
            bidonRouge.Ouvrir();
            bidonRouge.Remplir(5);
            bidonRouge.Vider(2);

            //Manipulation sur le bidon orange
            bidonOrange.Ouvrir();
            bidonOrange.Remplir(12);
            bidonOrange.Vider(4);
            bidonOrange.TransvaderDans(bidonRouge, 1);

           

            //Manipulation sur le bidon bleu
            bidonBleu.Ouvrir();
            bidonBleu.Remplir(3);
            bidonBleu.Vider(4);
            bidonBleu.Remplir(5);

            //Manipulation sur le bidon blanc
            bidonBlanc.Ouvrir();
            bidonBlanc.RemplirMax();
            

            //Etat du bidon
            Console.WriteLine(bidonRouge.ToString());
            Console.WriteLine(bidonOrange.ToString());
            Console.WriteLine(bidonBleu.ToString());
            Console.WriteLine(bidonBlanc.ToString());
            Console.ReadLine();

            //4) Bidon unBidon;

            //unBidon.Remplir(10);
            //unBidon = new Bidon("vert", 1050, 50); //il n'accepte pas car le constructeur n'accepte pas le 3ème argument.
            //unBidon.contenance = 150; //il n'accepte pas car il est privé
            //unBidon.Vider(0);
            //Console.WriteLine(unBidon.couleur); //il n'accepte pas car il est privé
            //Bidon.Vider(10); //Une référence d'objet est requise pour la propriété, la méthode ou le champ non statique
        }
    }
}
