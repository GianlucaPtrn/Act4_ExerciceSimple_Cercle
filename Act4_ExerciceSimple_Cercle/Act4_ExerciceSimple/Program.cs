using System;

namespace Act4_ExerciceSimple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenu dans ce programme sur le cercle");
            Console.WriteLine("Tapez un rayon pour votre cercle");
            double Rayon = int.Parse(Console.ReadLine());

            Cercle cercle = new Cercle(Rayon);
            double airResult = cercle.CalculeAire();
            double perimResult = cercle.CalculePerimetre();

            Console.WriteLine(cercle.CaracteristiqueCercle(airResult, perimResult));
        }
    }
}
