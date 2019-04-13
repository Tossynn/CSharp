using System ;
class ArrayLoop
{
    static void Main()
    {
        string[] names = {"sunday","amos","tosin","rose","femi","Chang"} ;
        Console.WriteLine("The length of the array names is {0}",names.Length) ;
        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine("Element {0} is {1}",i+1 ,names[i].ToUpper()) ;
        }
        Console.WriteLine("Using FOREACH Loop to print out elements in an Array") ;

        foreach (string item in names)
        {
            Console.WriteLine(item) ;
        }

        Console.WriteLine() ;
        Console.WriteLine("Multidimensional Array") ;
        string[,] fname_sname = new string[5,2]{{"sunday","amos"},{"Rose","Imo"},{"Femi","Oba"},{"Tosin","Android"},{"Deb","Debo"}} ;
        for (int row = 0; row < 5; row++)
        {
            for (int col = 0; col < 2; col++)
            {
                Console.Write(fname_sname[row,col] + " ") ;
            }
           Console.WriteLine() ;
        }
    }
}