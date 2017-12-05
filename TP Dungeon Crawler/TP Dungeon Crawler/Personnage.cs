using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP_Dungeon_Crawler
{
    class Personnage
    {
        // Données membres

        private int age;
        private int agilité;
        private int force;
        private string nom;
        private string peuple;
        private int pointsDeVie;
        private int pointsDeVieMaximum;
        

        //Constructeur du personnage
        public Personnage(int pointsDeVieMaximum, int force, int agilité, string nom, string peuple)
        {
            this.age = 25;
            this.pointsDeVieMaximum = pointsDeVieMaximum;
            this.pointsDeVie = pointsDeVieMaximum;
            this.force = force;
            this.agilité = agilité;
            this.nom = nom;
            this.peuple = peuple;
        }

        //Constructeur peuple
                                                                                                                                         

        public void BoirePotion(int pointsDeVie)
        {
            this.pointsDeVie = this.pointsDeVie + pointsDeVie;
            if (this.pointsDeVie > pointsDeVieMaximum)
            {
                this.pointsDeVie = pointsDeVieMaximum;
            }
        }

        public void estFrappé(int dégats)
        {
            this.pointsDeVie = this.pointsDeVie - dégats;
            if (this.pointsDeVie <= 0)
            {
                this.mourir();
            }
        }

        public void Frapper(Personnage p1, int dégats, string peuple)
        {
            p1.estFrappé(dégats);
        }

        public void mourir()
        {   
            Console.WriteLine("Argh c'est la fin pour moi... rip†††");   
        }

        public bool EstVivant()
        {
            if (this.pointsDeVie>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

       

    }
}
