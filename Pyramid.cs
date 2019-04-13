using System;
class Slearn
{
    static void DrawPyramid(int n)
    {
        for (int i=1; i<=n; i++)
        {
            for (int j=i; j<=n; j++)
            {
                Console.Write(" ");
            }
            for (int k = i; k <= 2 * i - 1; k++)
            {
                Console.Write("*" + " ");
            }
            Console.WriteLine();
        }
    }
    static void Main(string[] args)
    {
        //System.Console.WriteLine(Fact(5));
        //Console.WriteLine(DrawPyramid(5));
        DrawPyramid(5);
    }
}