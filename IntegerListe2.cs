using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace IntegerListe
{
    class Program
    {

        static List<int> intlist1= new List<int>();
        static List<int> intlist2 = new List<int>();

      

        static void printIntListen()
        {
            Console.WriteLine("Ausgabe 1. Liste:");

            foreach (int zahl in intlist1)
                Console.Write(zahl);


            Console.WriteLine("\nAusgabe 2. Liste:");

            foreach (int zahl in intlist2)
                Console.Write(zahl);

            Console.WriteLine("\nNur in einer Liste vorhanden:");

            var result = intlist1.Union(intlist2) //union 
            .Except( //except
                intlist1.Intersect(intlist2) //common
                );


            foreach (int num in result)
            {
                Console.Write("{0} ", num);
            }
        }



        static List<int> readFile(string filepath)
        {

            List<int> fileintlist = new List<int>();            
            var lines = File.ReadLines(filepath);


            foreach (var line in lines)
            {
                fileintlist = line.Split(',').Select(x => int.Parse(x)).ToList();
            }

            return fileintlist;
            //            
        }



        static void Main(string[] args)
        {

            Console.WriteLine("# 1) Listen manuell eingeben");
            Console.WriteLine("# 2) Listen von Datei einlesen");

            int auswahl = Convert.ToInt32(Console.ReadLine());

            if(auswahl == 1)
            {
                //manuell

                Console.WriteLine("Länge der Listen angeben:");
                int list_length = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("1. Liste eingeben:");
                for (int x = 0; x < list_length; x++)
                {
                    int zahl = Convert.ToInt32(Console.ReadLine());
                    intlist1.Add(zahl);
                }

                Console.WriteLine("2. Liste eingeben:");
                for (int x = 0; x < list_length; x++)
                {
                    int zahl2 = Convert.ToInt32(Console.ReadLine());
                    intlist2.Add(zahl2);
                }


                printIntListen();


            }
            else
            {
                //von Datei

                Console.WriteLine("# 1. Pfad + Dateiname angeben:");
                string datei1 = Console.ReadLine();
                intlist1 = readFile(datei1);

                Console.WriteLine("# 2. Pfad + Dateiname angeben:");
                datei1 = Console.ReadLine();
                intlist2 = readFile(datei1);


                printIntListen();


            }




        }
    }
}
