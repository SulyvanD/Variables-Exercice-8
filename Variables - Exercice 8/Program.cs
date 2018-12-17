using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables___Exercice_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int rayon;
            double perimetre;

            Console.WriteLine("Quel est le rayon du cercle ? (r)");
            rayon = int.Parse(Console.ReadLine());
            perimetre = 2 * Math.PI * rayon;

            Console.WriteLine("Le périmètre du cercles est de " + perimetre + " cm");
        }
    }
}
