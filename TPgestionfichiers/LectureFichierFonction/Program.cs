using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace LectureFichierfct
{
    class Program
    {
        static void Main(string[] args)
        {

            Lecture("monfichier.txt");
            
            ReadLine();
            //Read();
            //ReadToEnd();
            Console.ReadLine();
        }

        static void Lecture(string nomfichier)
        {
            StreamReader sr = null;
            try
            {
                //bloc de code à protéger
                sr = new StreamReader(nomfichier);
                Console.WriteLine("Le fichier existe");
                Console.WriteLine(" ");
                
                     
                //lecture et manipulation du fichier
            }

            catch (Exception ex)
            {
                //que fait on en cas d'erreur
                Console.WriteLine("Le fichier {0} n'existe pas", nomfichier);
                Console.WriteLine(ex.Message);
            }

            finally
            {
                //dans tous les cas on exécute ce bloc
                sr.Close();
            }

        }

     

        static void ReadToEnd()
        {
            Console.WriteLine("Méthode ReadToEnd");
            StreamReader sr = new StreamReader("fichiercsharp.cs");
            string s = sr.ReadToEnd();
            Console.WriteLine(s);
            Console.WriteLine(" ");
            sr.Close();
        }

        static void Read()
        {
            
            Console.WriteLine("Méthode Read");
            StreamReader sr = new StreamReader("monfichier.txt");
            char[] buffer = new char[6];
            while (sr.EndOfStream == false)
            {
                Console.Write(buffer);
                sr.Read(buffer, 0, 6); 
            }
            
            Console.WriteLine(" ");
            sr.Close();
        }

        static void ReadLine()
        {
            Console.WriteLine("Méthode ReadLine");
            StreamReader sr = new StreamReader("monfichier.txt");
            string s = sr.ReadLine();
            while (sr.EndOfStream == false)
            {
                Console.WriteLine(s);
                s = sr.ReadLine();
                
            }
            Console.WriteLine(" ");
            int a = sr.Peek();
            Console.WriteLine(a);
            sr.Close();
        }

       

        
    }
}
