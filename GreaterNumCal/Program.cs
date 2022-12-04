using System.Security.Cryptography.X509Certificates;

namespace MyProject;
class Program
{
    static void Main(string[] args)
    {
        int a;
        int b;
        string yes = "yes";

        Console.WriteLine("Wanna find out greater value? yes/no ");
        Convert.ToString(Console.ReadLine()); 

        if(yes == "yes")
        {
            Console.WriteLine("Enter value A: ");
            a = Convert.ToInt32(Console.ReadLine()); //This will convert value A to an integer in order to store it before calculating

            Console.WriteLine("Enter value B: ");
            b = Convert.ToInt32(Console.ReadLine()); //This will convert value B to an integer in order to store it before calculating

            Console.WriteLine("The greater value is: " + Math.Max(a, b)); //The a and b parameters represent the A and B user input values
        } else
        {
            Console.WriteLine("Ok bye.");
        }
    }
}