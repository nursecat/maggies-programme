namespace the_beans;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, beans!");
        Console.WriteLine("enter text");
        var line = Console.ReadLine()!;
        Console.WriteLine("Your text: " + line.ToLower());
    }
}