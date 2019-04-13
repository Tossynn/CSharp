using System ;
namespace Peri
{
    class Perimeter
    {
        static void Main()
        {
            const double pi = 3.1420 ;
            Console.Write("\nPlease supply the radius of your divk \t") ;
            double r = Convert.ToDouble(Console.ReadLine()) ;
            double perimeter = 2 * pi * r * r ;
            Console.WriteLine("\n THe Perimeter OF yOur Divk iS:\t {0}", perimeter) ;
            if (perimeter > 100)
            {
                Console.WriteLine(" Wow Nice Divk You've gat There ") ;
            }
            Console.WriteLine("\n \t You Try") ;
        }
    }
}