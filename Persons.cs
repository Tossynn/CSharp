using System ;
class Persons
{
    int NumberOfStudents, counter ;
    int NumberOfStudentDetails ;
    string[] _items ;
    string[][] stud;
    Persons()
    {
        this.NumberOfStudents = studnum() ;
        this.NumberOfStudentDetails = studrenum() ;
    }
    public int studnum()
    {
        System.Console.Write(" How many students do you wish to keep their records:  ");
        return int.Parse(Console.ReadLine()) ;
    }
    public int studrenum()
    {
        string txt = "" ;
        this.counter = 0 ;
        while (true)
        {
            Console.WriteLine(" \nWhat are the details you wish to record. You can press \"STOP\" to terminate") ;
            string t = Console.ReadLine() ;
            if ( t.Equals("STOP") )
            {
                break ;
            }
            if (txt.Equals(""))
            {
                txt += t;
            }
            else
            {
                txt += "," + t ;
            }
            this.counter++ ;
        }
        Console.WriteLine(txt) ;
        this._items = txt.Split(',') ;
        return this._items.Length ;
    }
    public void createArray()
    {
        stud = new string[this.NumberOfStudents][] ;
        for (int i = 0; i < stud.Length; i++)
        {
            stud[i] = new string[this.NumberOfStudentDetails] ;
        }
    }
    public void supplyRecords()
    {
        Console.WriteLine(" Total Number Students is: {0}", this.NumberOfStudents);
        for (int j = 0; j < NumberOfStudents; j++)
        {
            Console.WriteLine(" Supply Details for student " + (j+1)) ;
            Console.WriteLine("__________________________________________") ;
            for (int i = 0; i < this._items.Length; i++)
            {
                Console.Write(" Supply Students {0} : ", _items[i] ) ;
                stud[j][i] = Console.ReadLine() ;
            }
            Console.WriteLine() ;
        }
    }
    public static void Main(string[] args)
    {
        Persons sd = new Persons() ;
        sd.createArray() ;
        sd.supplyRecords() ;
    }
}