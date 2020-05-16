using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace IntegerListe
{
    class Program
    {

        static List<int> intlist1;
        static List<int> intlist2;
      

        static void Main(string[] args)
        {

            Console.WriteLine("Länge der Listen angeben:");
            int list_length = Convert.ToInt32(Console.ReadLine());

            intlist1 = new List<int>();
            intlist2 = new List<int>();
           

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
    }
}
