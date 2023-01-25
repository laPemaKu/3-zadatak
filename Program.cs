using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Zad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Fibonaccijev niz definiran je na sljedeći način: 
            • prvi član niza je 0 
            • drugi član niza je 1 
            • svaki sljedeći član niza jednak je zbroju prethodna dva člana 
            Napišite program koji će zatražiti od korisnika da unese broj n, te će izračunati n-ti član 
            Fibonaccijevog niza.
            */

            Console.WriteLine("Upisi te n broj: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] Fibonaccijev = new int[100];
            Fibonaccijev[0] = 0;
            Fibonaccijev[1] = 1;
            for (int i = 1; i <= n; i++)
            {
                Fibonaccijev[i+1] = Fibonaccijev[i] + Fibonaccijev[i-1];
            }
            Console.WriteLine("Fibonaccijev {0}. broj je: {1}", n, Fibonaccijev[n]);

            Console.ReadKey();
        }
    }
}
