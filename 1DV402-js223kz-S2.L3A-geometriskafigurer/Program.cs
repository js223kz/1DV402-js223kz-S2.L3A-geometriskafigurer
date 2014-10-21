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
        private static void CreateShape(Shape shapeType)
        {

        }

        //ska anropa metoden ViewMenu för att visa menyn
        //Väljer användaren att inte avsluta applicationen anropas metode CreateShape
        //CreateShape skapar och returnerar en referens till ett ellips eller rektangel objekt
        //Referensen till objektet används vid anrop av ViewDetail() som presenterar figurens detaljer.
        // Då en beräkning är gjord ska menyn visas på nytt
        static void Main(string[] args)
        {
            ViewMenu();

        }

        //Ska returnera en double som är större än 0
        //det ska vara möjligt att skicka med ett argument till metoden
        //Argumentet ska vara en sträng med information som ska visas i anslutning till där inmatning av värdet sker
        /// <summary>
        /// Ange längden: tex Om det inmatade inte kan tolkas som ett korrekt värde ska användaren få en chans att
        /// göra en ny inmatning efter ett fellmeddelande visats FEL! Ange ett flyttal större än 0
        /// </summary>
        /// <returns></returns>
        private static double ReadDoubleGreaterThanZero(){

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

        }

        //ska presentera en figurs detaljer.
        //Vid anrop av metoden skickas ett argumnet med som refererar till figuren vars detaljer ska presenteras.
        //Parametern shape av TYpen Shape refererar till figuren
        //Genom att utnyttja att basklassen Shape överskugga metoden ToString() förenklas koden
        //väsentlgt då en figurs längd, bredd, omkrets och area ska presenteras.
        private static void ViewShapeDetail()
        {

        }

       


    }
}
