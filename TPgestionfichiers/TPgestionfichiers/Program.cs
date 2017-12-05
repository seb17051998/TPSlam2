using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;



namespace TPgestionfichiers
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("monFichier.txt");
            
            /* 1ère possibilité */
            //string ligne = sr.ReadToEnd();
            //Console.WriteLine(ligne);

            /* 2ème possibilité */
            //char[] buffer = new char[4];
            //sr.Read(buffer, 0, 4);
            //Console.WriteLine(buffer);

            /* 3ème possibilité */
            //string ligne = sr.ReadLine();
            //Console.WriteLine(ligne);
            
            sr.Close();
            Console.ReadLine();
            
            

        }
    }
}
