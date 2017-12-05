using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Destination
{
    class Destination
    {
        private string unPays;
        private string unHebergement;

        public Destination(string pays, string hebergement)
        {
            // code du constructeur
            unPays = pays;
            unHebergement = hebergement;
        }

        public string ToString()
        {
            return this.unPays + " " + this.unHebergement;
        }


        

    }
}
