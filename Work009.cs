using System;
class Worke
{
    public string f;
    public string s;
    public string g;
    public string m;
    static void Main()
    {
        System.Console.WriteLine(" Please Input; ");
        Console.WriteLine("_________________________");
        Console.Write(" Your First Name: ");
        string f = Console.ReadLine();
        f = f.Remove(1) ;
        Console.Write(" Your Surname: ");
        string s = Console.ReadLine();
        Console.Write(" Gender: ");
        string g = Console.ReadLine();
        Console.Write(" Marital Status: ");
        string m = Console.ReadLine();
        if (g.Equals("male") || g.Equals("Male") || g.Equals("MALE"))
        {
            if (m.Equals("Married") || m.Equals("married") || m.Equals("married"))
            {
                s = s.Insert(0, "Mr. ");
            }
            else
            {
                s = s.Insert(0, "Master ");
            }
        }
        if (g.Equals("Female") || g.Equals("female") || g.Equals("FEMALE"))
        {
            if (m.Equals("Married") || m.Equals("married") || m.Equals("MARRIED"))
            {
                s = s.Insert(0, "Mrs. ");
            }
            else
            {
                s = s.Insert(0, "Miss ");
            }
        }
        /*Worke w = new Worke();
        w.Things();*/
        Console.WriteLine("\n Welcome {0} {1}.", s, f.ToUpper());
        //Console.WriteLine(f);
    }
}