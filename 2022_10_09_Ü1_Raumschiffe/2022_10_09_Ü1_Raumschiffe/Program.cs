//Usings#######################################################################
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//#############################################################################


//Classes######################################################################
class Raumschiff
{
    public double länge;
    public double breite;
    public double höhe;
}
//#############################################################################


namespace _2022_10_09_Ü1_Raumschiffe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Raumschiff Discovery = new Raumschiff();
            Raumschiff Enterprise = new Raumschiff();

            Discovery.länge = 23.24;
            Discovery.breite = 23.79;
            Discovery.höhe = 3.71;

            Enterprise.länge = 288.6;
            Enterprise.breite = 127.1;
            Enterprise.höhe = 72.6;

            Console.WriteLine("Discovery:");
            Console.WriteLine("Länge: {0}", Discovery.länge);
            Console.WriteLine("Breite: {0}", Discovery.breite);
            Console.WriteLine("Höhe: {0}\n", Discovery.höhe);

            Console.WriteLine("Enterprise:");
            Console.WriteLine("Länge: {0}", Enterprise.länge);
            Console.WriteLine("Breite: {0}", Enterprise.breite);
            Console.WriteLine("Höhe: {0}\n", Enterprise.höhe);

            Discovery.länge = Enterprise.länge;

            Console.WriteLine("Discovery:");
            Console.WriteLine("Länge: {0}", Discovery.länge);
            Console.WriteLine("Breite: {0}", Discovery.breite);
            Console.WriteLine("Höhe: {0}\n", Discovery.höhe);

            Console.WriteLine("Enterprise:");
            Console.WriteLine("Länge: {0}", Enterprise.länge);
            Console.WriteLine("Breite: {0}", Enterprise.breite);
            Console.WriteLine("Höhe: {0}\n", Enterprise.höhe);

            Discovery = Enterprise;

            Console.WriteLine("Discovery:");
            Console.WriteLine("Länge: {0}", Discovery.länge);
            Console.WriteLine("Breite: {0}", Discovery.breite);
            Console.WriteLine("Höhe: {0}\n", Discovery.höhe);

            Console.WriteLine("Enterprise:");
            Console.WriteLine("Länge: {0}", Enterprise.länge);
            Console.WriteLine("Breite: {0}", Enterprise.breite);
            Console.WriteLine("Höhe: {0}\n", Enterprise.höhe);

            Discovery.länge = 5;

            Console.WriteLine("Discovery:");
            Console.WriteLine("Länge: {0}", Discovery.länge);
            Console.WriteLine("Breite: {0}", Discovery.breite);
            Console.WriteLine("Höhe: {0}\n", Discovery.höhe);

            Console.WriteLine("Enterprise:");
            Console.WriteLine("Länge: {0}", Enterprise.länge);
            Console.WriteLine("Breite: {0}", Enterprise.breite);
            Console.WriteLine("Höhe: {0}\n", Enterprise.höhe);



            Console.WriteLine("Press ENTER to exit...");
            Console.ReadLine();
        }
    }
}
