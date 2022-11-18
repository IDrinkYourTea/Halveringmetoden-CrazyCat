using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halveringmetoden_CrazyCat
{
    internal class Program
    {
        static void Main(string[] args)
        {
 
            Console.Write("Skriv Nummer: ");
            int topnum = Convert.ToInt32(Console.ReadLine()); 

            Random num= new Random();
            int randnum = num.Next(topnum + 1);

            var rett = false;
            int gjetting = 0;
            while (rett == false)
            {
                int gjett = Convert.ToInt32(Console.ReadLine());
                gjetting++;
                if (gjett < randnum)
                {
                    Console.WriteLine("Tallet du skrev inn, er for lavt.");
                }
                else if (gjett > randnum)
                {
                    Console.WriteLine("Tallet du skrev inn, er for høyt");
                }
                else
                {
                    Console.WriteLine("Du gjettet helt rett!");
                    rett = true;
                }
            }
            Console.WriteLine("Du Brukte " + gjetting + " forsøk får å komme fram til rett svar.");
        }
    }
}
