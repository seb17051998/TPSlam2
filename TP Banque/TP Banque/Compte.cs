using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP_Banque
{
    class Compte
    {
        private static int nombreComptes;

        private int numero;
        private string titulaire;
        private decimal solde;
        private decimal decouvertMax;
        private decimal debitMax;
        

        public Compte(string titulaire, decimal solde)
        {
            Compte.nombreComptes = Compte.nombreComptes + 1;
            this.titulaire = titulaire;
            this.solde = solde;
            this.debitMax = solde * 0.25m;
            this.decouvertMax = solde * 0.1m;
            this.numero = Compte.nombreComptes;
                
        }

        // Chainage
        public Compte(string titulaire, decimal solde, decimal decouvertMax, decimal debitMax/*, decimal debitMax */):
            this(titulaire,solde)
        {
            
            this.decouvertMax = decouvertMax;
            this.debitMax = debitMax;
            //this.depenseactuelle = depenseactuelle;
        }

        public void Crediter(decimal montant)
        {
            // augmente le solde
            this.solde = solde + montant;
        }

        public bool Debiter(decimal montant)
        {
            // diminue le solde
            if (montant > debitMax)
            {
                Console.WriteLine("Débit rejeté : le montant est supérieur au débit max");
            }
            else
            {
                if (solde < 0)
                {
                    Console.WriteLine("Attention vous êtes à découvert !");
                    if (solde < decouvertMax)
                    {
                        Console.WriteLine("Prélèvement rejeté");

                    }
                    else
                    {
                        this.solde = solde - montant;
                        return true;
                    }
                }
                else
                {
                    this.solde = solde - montant;
                    return true;
                }
            }

            return false;
            
            // retourn true ou false si l'opération a réussi.
            
        }

        public void Virement(Compte CompteDestinataire, decimal montant)
        {
            if (montant < debitMax)
            {

                if (solde < decouvertMax)
                {
                    Console.WriteLine("Erreur debit, vous dépassez votre autorisation de découvert");
                }
                else
                {
                    this.solde = solde - montant;
                    CompteDestinataire.Crediter(montant);
                }
            }
            else
            {
                Console.WriteLine("Erreur debit, Vous dépassez votre débit maximum");
            }
        }

        public string ToString()
        {
            return string.Format("Compte n°{0} \n Titulaire : {1} \n Solde : {2} \n Découvert Maximum : {3} \n Débit max {4}", numero, titulaire, solde, decouvertMax, debitMax);
        }

        public decimal GetSolde()
        {
            return this.solde;
        }

        public decimal Solde
        {
            get
            {
                return this.GetSolde();
            }
        }

        

        /*public int GetNombre()
        {
            return numero;
        }

        public int count
        {
            get
            {
                return this.numero;
            }
        }*/
    }
}
