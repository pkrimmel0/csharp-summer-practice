
// Console.WriteLine("enter some text");
// var myVar = Console.ReadLine();
// var myVar = "asdf";
// Console.WriteLine("the text was " + myVar);

//var rnd = new Random();

class MyRandom
{
    public static void Main()
    {
        var rnd = new Random();
        Console.WriteLine("enter the 1st number");
        var NumOne = int.Parse(Console.ReadLine());
        Console.WriteLine("enter the 2nd number");
        var NumTwo = int.Parse(Console.ReadLine());
        Console.WriteLine("a number between " + NumOne + " and " + NumTwo + " is: ");
        Console.WriteLine(rnd.Next(NumOne, NumTwo));

    }
}


/*
class AwesomeApp
{
    public static void Main()
    {
        Console.WriteLine("notice me senpai");
    }
    public AwesomeApp()
    {

    }
}
*/

