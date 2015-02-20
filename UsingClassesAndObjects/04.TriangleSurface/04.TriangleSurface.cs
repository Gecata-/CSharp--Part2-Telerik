// Problem 4. Triangle surface

// Write methods that calculate the surface of a triangle by given:
// Side and an altitude to it;
// Three sides;
// Two sides and an angle between them;
// Use System.Math.
using System;


class TriangleSurface
{
    static double SideAlt(double a, double h)
    {
        double surface = (a * h) / 2;
        return surface;
    }
    static double SideAlt(int d, int b, int c)
    {
        double surface = (d + b + c) / 2;
        return surface;
    }
    static double SideAlt(double m, double n, double degrees)
    {
        double angle    = Math.PI * degrees / 180.0;
        double surface =  ((m * n)/2) * Math.Sin(angle);
        return surface;
    }
    static void Main()
    {

        double surface = 0;
        Console.WriteLine("Choose method:");
        Console.WriteLine("1) Side and an altitude to it;\n2) Three sides;\n3) Two sides and an angle between them;");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.WriteLine("By given side and an altitude to it surface");
                double a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                surface = SideAlt(a, h);
                break;
            case 2:
                Console.WriteLine("By given three sides");
                int d = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());
                surface = SideAlt(d, b, c);
                break;
            case 3:
                Console.WriteLine("By given two sides and an angle between them");
                double m = double.Parse(Console.ReadLine());
                double n = double.Parse(Console.ReadLine());
                double angle = double.Parse(Console.ReadLine());
                surface = SideAlt(m, n, angle);
                break;
        }

        Console.WriteLine(" The surface is {0}", surface);
    }
}

