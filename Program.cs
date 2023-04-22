using System;
namespace app;

class Practice{
    static void Main(string[] args)
    {
        //String Interpolation
        string hello = "Hello Shubham!";
        string sayhello="Shubham";
        Console.WriteLine(sayhello.Replace("Shubham","Vineet"));
        //Numbers and Operators
        int d=7;
        int b=6;
        int c=b+d;
        Console.WriteLine(c);
        //Precision
        int min=int.MinValue;
        int max=int.MaxValue;
        Console.WriteLine($"the min value is {min} and max value is {max}");
        //Area of a circle
        double radius=10;
        double area=Math.PI*radius*radius;
        Console.WriteLine($"the area is {area}");

        Console.WriteLine($"the output is {hello}");
        //OOPS
        BankAccount account=new BankAccount("Shubham","Ravi",1000);
        account.Deposit(300,200);
        Console.WriteLine($"the objects are {account.v2}");
        var a = new List<string> { "Shubham", "Ayush" };
        //Adding in a collection
        a.Add("Ravi");
        a.Add("Ayush");
        a.Add("Elina");
        a.Remove("Ayush");
        //index
        var index=a.IndexOf("Elina");
        Console.WriteLine($"the count of elents is {index}");
        a.Sort();

        foreach (var z in a)
        {
            Console.WriteLine(z.ToLower());


        }
        int[] scores = { 97, 92, 81, 60 };

// Define the query expression.
IEnumerable<int> scoreQuery =
    from score in scores
    where score > 80
    select score;

// Execute the query.
foreach (int i in scoreQuery)
{
    Console.WriteLine(i + " ");
}
    }
}




