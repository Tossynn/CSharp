using System ;
class prime
{
    static void Main()
    {
        int counter = 0;
        for (int a=1; a<100; a++)
        {
            //System.Console.WriteLine("The value of a is {0}", a);
            int count = 0;
            for (int b=1; b<=a; b++)
            {
                if (a%b==0)
                {
                    count ++;
                }
            }
            if (count == 2)
            {
                counter ++;
                Console.WriteLine(a+" is a prime number") ;
            }
        }
        Console.WriteLine("\nThere are {0} prime numbers between 1 & 1000 ", counter);
    }
}