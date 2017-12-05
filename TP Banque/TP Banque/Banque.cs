using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace TP_Banque
{
    class Banque //En tulisant les collections typées
    {
        // Les données membres de la classe Banque
        List<Compte> lesComptes;
        string nomBanque;
        string titulaire;
        decimal solde;
        decimal decouvertMax;
        decimal debitMax;

        public Banque(string nomBanque)
        {
            this.lesComptes = new List<Compte>();
            this.nomBanque = nomBanque;
        }

        public void Add(Compte nouveauCompte)
        {
            Compte nouveau = new Compte(titulaire, solde, decouvertMax, debitMax);
            lesComptes.Add(nouveau);
        }

        

        public int GetCount()
        {
            return this.lesComptes.Count;
        }

        public int Count
        {
            get
            {
                return this.GetCount();
            }
        }

        public Compte GetCompte(int position)
        {
            if (position >= 0 && position < this.lesComptes.Count)
            {
                return this.lesComptes[position];
            }
            else
            {
                return null;
            }
        }

        public Compte this[int position]
        {
            get
            {
                return this.lesComptes[position];
            }
        }

        /*public int CountSoldesNégatifs()
        {
            
            for (int i = 0; i < this.Count; i++) 
            {
                decimal cumul = 0;
                Compte c = this.GetCompte(i);
                c = (Compte)this.lesComptes[i];
                if (c.Solde < 0)
                {
                    
                }
            }
        } */

        public decimal ValeurDepotBanque()
        {
            decimal cumul = 0;
            for (int i = 0; i < this.Count; i++)
			{
			    Compte c= this.GetCompte(i);
                c=(Compte)this.lesComptes[i];
                cumul = cumul + ((Compte)this.lesComptes[i]).GetSolde();
                cumul=cumul+c.GetSolde();
			}
            return cumul;
        }
    }
}
