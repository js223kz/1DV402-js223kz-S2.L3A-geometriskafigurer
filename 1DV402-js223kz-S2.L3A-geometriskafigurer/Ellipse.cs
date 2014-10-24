using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402_js223kz_S2.L3A_geometriskafigurer
{
     class Ellipse : Shape
    {

        //ska ge ellipsens area
        public override double Area
        {
            get
            {
                Length = Length / 2;
                Width = Width / 2;
                return Math.PI * Length * Width;
            }
           
        }

        //ska ge ellipsens omkrets
        public override double Perimeter
        {
            get
            {
                return Math.PI * Math.Sqrt(2 * Length * Length + 2 * Width * Width);
            }
            
        }

        //genom anrop av basklassens konstruktor sätts objektets längd och bredd
        public Ellipse(double lenght, double width) :
            base(lenght, width)
        {
            Length = lenght;
            Width = width;
        }

    }
}
