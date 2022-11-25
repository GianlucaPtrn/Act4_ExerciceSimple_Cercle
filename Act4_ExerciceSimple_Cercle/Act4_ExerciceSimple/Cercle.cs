using System;
using System.Collections.Generic;
using System.Text;

namespace Act4_ExerciceSimple
{
    class Cercle
    {
        private double _rayon;

		public double Rayon
		{
			get{ 
				return _rayon; 
			}
			set{
				_rayon = value; 
			}
		}

        //constructeur 
        public Cercle (double rayon)
        {
            _rayon = rayon;
        }

        public double CalculeAire()
		{
			double airResult = Math.PI * _rayon * _rayon;
            return airResult;
		}

        public double CalculePerimetre()
        {
            double perimetreResult = Math.PI * _rayon * 2;
            return perimetreResult;
        }

        public string CaracteristiqueCercle(double airResult, double perimetreResult)
        {
            string Caracteristique = "le cercle de rayon :" + " " + _rayon + " " + "a pour périmetre : " + " " + perimetreResult.ToString("f2") + " " + "et une aire de : " + " " + airResult.ToString("f2");
            return Caracteristique;
        }

    }
}
