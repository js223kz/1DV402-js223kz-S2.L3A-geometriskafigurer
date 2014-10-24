using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402_js223kz_S2.L3A_geometriskafigurer
{
    class Program
    {

        //metoden ska läsa in en figurs längd och bredd, skapa objektet och returnera en referens till det
        //Metoden ska ha en parameter av typen ShapeType vars värde bestämmer om en ellips eller rektangel ska skapas
        //Den uppräkningsbara typen Shape Type används för att definiera vilka typer av figurer applikationen
        //kan hantera. Typen används då metoden Main() anropar CreateShape för att informera vilken typ
        //av figur som ska skapas.
        //Typen definieras lämpligen i filen Shape.cs men då utanför klassdefinitionen så att den inte blir en del av typen Shape.
        private static void CreateShape(KindOfShape shapeType)
        {
            double lenght = 0.0;
            double width = 0.0;

            switch (shapeType)
             {
                 case KindOfShape.shapeEllipse:
                     lenght = ReadDoubleGreaterThanZero("Ange längden: ");
                     width = ReadDoubleGreaterThanZero("Ange bredden: ");
                     Ellipse ellipse = new Ellipse(lenght, width);
                     ViewShapeDetail(ellipse);
                     break;
                 
                case KindOfShape.shapeRectangle:
                     lenght = ReadDoubleGreaterThanZero("Ange längden: ");
                     width = ReadDoubleGreaterThanZero("Ange bredden: ");
                     Rectangle rectangle = new Rectangle(lenght, width);
                     ViewShapeDetail(rectangle);
                     break;
             }
        }

        //Väljer användaren att inte avsluta applicationen anropas metode CreateShape
        //CreateShape skapar och returnerar en referens till ett ellips eller rektangel objekt
        //Referensen till objektet används vid anrop av ViewDetail() som presenterar figurens detaljer.
        // Då en beräkning är gjord ska menyn visas på nytt
        static void Main(string[] args)
        {
            ViewMenu();

            int pressedKey = int.Parse(Console.ReadLine());
            KindOfShape shapeType;
            
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


                    shapeType = KindOfShape.shapeEllipse;
                    CreateShape(shapeType);

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

                    shapeType = KindOfShape.shapeRectangle;
                    CreateShape(shapeType);
                   
                    break;
            }
        }

        private static double ReadDoubleGreaterThanZero(string prompt){
            double value = 0.0;
            Console.Write(prompt);
            try
            {
                prompt = Console.ReadLine();
                value = double.Parse(prompt);
            }
            catch (ArgumentException e)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("{0}", e.Message);
                Console.ResetColor();
            }
            return value; 
        }

        //ska bara presentera en meny någon inläsning ska inte göras
        private static void ViewMenu()
        {

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

        //ska presentera en figurs detaljer.
        //Vid anrop av metoden skickas ett argumnet med som refererar till figuren vars detaljer ska presenteras.
        //Parametern shape av TYpen Shape refererar till figuren
        //Genom att utnyttja att basklassen Shape överskugga metoden ToString() förenklas koden
        //väsentlgt då en figurs längd, bredd, omkrets och area ska presenteras.
        private static void ViewShapeDetail(Shape shapeType)
        {


        }

       


    }
}
