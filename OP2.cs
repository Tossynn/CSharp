using System ;
namespace OPDemo
{
    class DemoOP2
    {
        static void Main()
        {
            int a = 5 ;
            int b = 10 ;
            a += b ;
            Console.WriteLine(a) ;
            Console.WriteLine(b) ;
            DemoOP2 dm = new DemoOP2() ;
            Console.WriteLine(typeof (DemoOP2)) ;
            string y = (5 < 10)? "Sunday" : "Monday" ;
            Console.WriteLine(y) ;
            string name = "Sunday" ;
            int age = 18 ;
            string gender = "Male" ;
            if (age < 20)
            {
                if (age > 18)
                {
                    Console.WriteLine(" NICE ONE") ;
                }
                else
                {
                    Console.WriteLine(" Kindergarten") ;
                }   
            }
            else
            {
                Console.WriteLine(" This Scheme is for you ") ;
            }
            Console.WriteLine(" Thank you ") ;
        }
    }
}