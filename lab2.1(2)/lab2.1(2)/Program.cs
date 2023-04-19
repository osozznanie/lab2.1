using System;
using System.Globalization;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the coordinates of point A, separated by a space:");
        Console.WriteLine("In this form (xA, yA), but without ',' ");
        string[] inputA = Console.ReadLine().Split(' ');
        int xA = int.Parse(inputA[0]);
        int yA = int.Parse(inputA[1]);

        Console.WriteLine("Enter the coordinates of point B, separated by a space:");
        Console.WriteLine("In this form (xB, yB), but without ',' ");
        string[] inputB = Console.ReadLine().Split(' ');
        int xB = int.Parse(inputB[0]);
        int yB = int.Parse(inputB[1]);

        Console.WriteLine("Enter the coordinates of point C with a space:");
        Console.WriteLine("In this form (xC, yC), but without ',' ");
        string[] inputC = Console.ReadLine().Split(' ');
        int xC = int.Parse(inputC[0]);
        int yC = int.Parse(inputC[1]);

        Parallelogram p = new Parallelogram(xA, yA, xB, yB, xC, yC);

        Console.WriteLine("Square: {0}", p.Area().ToString(CultureInfo.InvariantCulture));
        Console.WriteLine("Perimeter: {0}", p.Perimeter());
        Console.WriteLine("Length of the diagonal 1: {0}", p.Diagonal1());
        Console.WriteLine("Length of the diagonal 2: {0}", p.Diagonal2());
        Console.WriteLine("Is that parallelogram valid: {0}", p.IsValid());
    }

}
