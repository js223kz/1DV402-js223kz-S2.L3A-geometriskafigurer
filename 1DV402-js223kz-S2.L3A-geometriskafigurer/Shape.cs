using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402_js223kz_S2.L3A_geometriskafigurer
{
    public enum KindOfShape{
        shapeEllipse, 
        shapeRectangle
    };
    public abstract class Shape
    {
        private double _length;

        private double _width;

        //Represents area of the shape
        public abstract double Area
        {
            get;
        }

        //Shape lenght validates the value from userinput
        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Längden måste vara ett flyttal större än noll");
                }
                _length = value;
            }
        }

        //Represents the perimeter of shape
        public abstract double Perimeter
        {
            get;

        }

        //Width of shape validates value from user input
        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Bredden måste vara ett flyttal större än noll");
                }
                _width = value;
            }
        }

    
        protected Shape(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override string ToString()
        {

            string lenght = String.Format("{0,-8}{1,-3}{2,8:f1}", "Längd", ":", Length);
            string width = String.Format("{0,-8}{1,-3}{2,8:f1}", "Bredd", ":", Width);
            string area = String.Format("{0,-8}{1,-3}{2,8:f1}", "Area", ":", Area);
            string perimeter = String.Format("{0,-8}{1,-3}{2,8:f1}", "Omkrets", ":", Perimeter );

            return string.Format("{0}{1}{2}{3}", lenght + Environment.NewLine, width + Environment.NewLine, area + Environment.NewLine, perimeter + Environment.NewLine);
         
        }
    }
}
