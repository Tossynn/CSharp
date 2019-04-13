using System ;
class AOC
{
    static void Main()
    {
        const double pi = 3.1423 ;
        System.Console.WriteLine("Supply the radius of the circle");
        double r = Convert.ToDouble(Console.ReadLine()) ;
        double area = pi * r * r ;
        Console.WriteLine(" The area of circle with radius {0} is {1}",r,area) ;
    }
}   