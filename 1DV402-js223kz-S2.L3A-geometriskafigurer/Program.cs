using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402_js223kz_S2.L3A_geometriskafigurer
{
    class Program
    {

        //method that handles lenght and witdth, creates the object an returns a reference to that object
        private static Shape CreateShape(KindOfShape shapeType)
        {
            double lenght = 0.0;
            double width = 0.0;

            switch (shapeType)
            {
                case KindOfShape.shapeEllipse:

                    lenght = ReadDoubleGreaterThanZero("Ange längden: ");
                    width = ReadDoubleGreaterThanZero("Ange bredden: ");
                    Ellipse ellipse = new Ellipse(lenght, width);

                    return ellipse;

                case KindOfShape.shapeRectangle:
                    lenght = ReadDoubleGreaterThanZero("Ange längden: ");
                    width = ReadDoubleGreaterThanZero("Ange bredden: ");
                    Rectangle rectangle = new Rectangle(lenght, width);

                    return rectangle;

                default:
                    throw new Exception("Ett oväntat fel inträffade");
            }
        }

        static void Main(string[] args)
        {

            do
            {
                ViewMenu();


                int pressedKey = int.Parse(Console.ReadLine());
                Shape shapeType = null;


                switch (pressedKey)
                {
                    case 0:
                        return;

                    case 1:
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(" ============================ ");
                        Console.WriteLine(" =                          = ");
                        Console.WriteLine(" =          Ellips          = ");
                        Console.WriteLine(" =                          = ");
                        Console.WriteLine(" ============================ ");
                        Console.WriteLine();
                        Console.ResetColor();

                        shapeType = CreateShape(KindOfShape.shapeEllipse);
                        break;
                    case 2:
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(" ============================ ");
                        Console.WriteLine(" =                          = ");
                        Console.WriteLine(" =         Rektangel        = ");
                        Console.WriteLine(" =                          = ");
                        Console.WriteLine(" ============================ ");
                        Console.WriteLine();
                        Console.ResetColor();

                        shapeType = CreateShape(KindOfShape.shapeRectangle);
                        break;
                }

                ViewShapeDetail(shapeType);

                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Press any key to continue");
                Console.ResetColor();


            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

        }
        
        //Handles userinput and returns a value
        private static double ReadDoubleGreaterThanZero(string prompt)
        {
            double value = 0.0;
            string userInput = "";
            bool isValid = false;

            do
            {
                try
                {
                    Console.Write(prompt);
                    userInput = Console.ReadLine();
                    value = double.Parse(userInput);
                    if (value <= 0)
                    {
                        throw new ArgumentException("Värdet kan inte vara mindre noll");
                    }
                    isValid = true;
                }
                catch (ArgumentException e)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("{0}", e.Message);
                    Console.ResetColor();
                }
                catch (FormatException)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Kan inte tolkas som ett giltigt tal!");
                    Console.ResetColor();
                }


            } while (isValid == false);

            return value;

        }

        //Presenting the user menu
        private static void ViewMenu()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ============================ ");
            Console.WriteLine(" =                          = ");
            Console.WriteLine(" =   Geometriska figurer    = ");
            Console.WriteLine(" =                          = ");
            Console.WriteLine(" ============================ ");
            Console.ResetColor();

            Console.WriteLine("0. Avsluta.");
            Console.WriteLine("1. Ellips.");
            Console.WriteLine("2. Rektangel.");

            Console.WriteLine(" ============================ ");
            Console.WriteLine("Ange menyval [0-2]");


        }

        //Presents the details of the shape, area and, perimeter
        private static void ViewShapeDetail(Shape shapeType)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine(" ============================ ");
            Console.WriteLine(" =          Detaljer        = ");
            Console.WriteLine(" ============================ ");
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine(shapeType.ToString());

        }
    }
}