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
        //figurens längd
        private double _length;

        //figurens bredd
        private double _width;

        //Representerar figurens area
        public abstract double Area
        {
            get;
        }

        //Figurens längd. Kapslar in fältet _lenght. Set ska validera värdet som tilldelas egenskapen. Är värdet inte större än noll ArgumentEx.
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

        //Representerar figurens omkrets
        public abstract double Perimeter
        {
            get;

        }

        //Figurens bredd. Kapslar in fältet _width. Set ska validera att värdet är större än noll ArgumentEx.
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

        //konstruktorn ansvarar för att fälten via egenskaperna, tilldelas de värden konstruktorns parametrar har
        protected Shape(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        //Ska returnera en sträng respresenterande värdet av en instans. Strängen ska vara speciellt formaterad
      /*  public override string ToString(string figureDetails)
        {
            

            //string colon = ":";
            //return figureDetails.Format("Lenght{0}{1}" + "Bredd{0}{2}" + "Omkrets{0}{3}" + "Area{0}{4}", ":" Length, Width, Perimeter, Area); 
            
        }*/
    }
}
