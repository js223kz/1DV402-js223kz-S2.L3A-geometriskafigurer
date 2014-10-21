using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402_js223kz_S2.L3A_geometriskafigurer
{
    class Rectangle : Shape
    {

        //ska ge rektangelns area
        public override double Area
        {
            get
            {
                throw new NotImplementedException();
            }
            
        }

        //ska ge rektangelns omkrets
        public override double Perimeter
        {
            get
            {
                throw new NotImplementedException();
            }
            
        }

        public Rectangle(double lenght, double width) :
            base(lenght, width)
        {
            Length = lenght;
            Width = width;
        }
    }
}
