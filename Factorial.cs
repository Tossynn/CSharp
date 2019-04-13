using System ;
class Factorial
{
    double result;
    public double calcFactorial(int num)
    {
        if ( num == 1)
        {
            return 1; 
        }
        else
        {
            result = calcFactorial(num - 1) * num ;
            return result ;
        }
    }
    static void Main()
    {
        Console.Write(" Enter the fucking number \t- ") ;
        int x = Convert.ToInt16(Console.ReadLine());
        Factorial f = new Factorial();
        double ans = f.calcFactorial(x);
        System.Console.WriteLine(" {0}! is {1}", x, ans);
    }
}