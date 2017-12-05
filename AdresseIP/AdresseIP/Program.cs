using System;
using System.Collections.Generic;
using System.Linq;
using AdressageIP;
using System.Text;



namespace AdressIP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Déclaration d'un objet de type Adresse IP
            AdresseIP ip1, ip2, ip3;

            // L'instanciation = la création d'un objet
            ip1 = AdresseIP.GetInstance("92.68.25.23");
            ip2 = AdresseIP.GetInstance("172.16.0.65");

            // Une autre instanciation par la 2ème surcharge
            ip3 = AdresseIP.GetInstance(192, 168, 1, 1);

            // Accesseur Get
            Console.WriteLine("Utilisation de l'accesseur Get :");
            Console.WriteLine(" ");

            Console.WriteLine("{0}.{1}.{2}.{3}", ip1.GetOctet1(), ip1.GetOctet2(), ip1.GetOctet3(), ip1.GetOctet4());
            Console.WriteLine("{0}.{1}.{2}.{3}", ip2.GetOctet1(), ip2.GetOctet2(), ip2.GetOctet3(), ip2.GetOctet4());
            Console.WriteLine("{0}.{1}.{2}.{3}", ip3.GetOctet1(), ip3.GetOctet2(), ip3.GetOctet3(), ip3.GetOctet4());
            Console.WriteLine(" ");

            // Méthode ToString
            Console.WriteLine("Utilisation de la méthode ToString :");
            Console.WriteLine(" ");

            Console.WriteLine(ip1.ToString());
            Console.WriteLine(ip2.ToString());
            Console.WriteLine(ip3.ToString());
            Console.WriteLine(" ");
            
            
            
            //Classe et Masque
            Console.WriteLine("Classe et Masque");
            Console.WriteLine(" ");
            Console.WriteLine(ip1.Masque()+" Classe A");
            Console.WriteLine(ip2.Masque() + " Classe B");
            Console.WriteLine(ip3.Masque() + " Classe C");
            Console.WriteLine(" ");

            //IP en Décimal et binaire
            Console.WriteLine("Adresse IP en décimal et en binaire");
            Console.WriteLine(" ");
            Console.WriteLine("Adresse IP en décimal : {0} Adresse IP en binaire : {1}", ip1.ToString(),ip1.AdresseIpBinaire());
            Console.WriteLine("Adresse IP en décimal : {0} Adresse IP en binaire : {1}", ip2.ToString(), ip2.AdresseIpBinaire());
            Console.WriteLine("Adresse IP en décimal : {0} Adresse IP en binaire : {1}", ip3.ToString(), ip3.AdresseIpBinaire());




            Console.ReadLine();

            


            


        }
    }
}
