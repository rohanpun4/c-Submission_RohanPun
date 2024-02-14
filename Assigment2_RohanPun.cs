using System;

class Program
{
    static void Main()
    {
        // Taking user input for a real number
        Console.Write("Please enter a real number: ");
        double x = double.Parse(Console.ReadLine());

        // Declaring the intervals
        double interval1Start = 2;
        double interval1End = 3;
        double interval2Start = 0;
        double interval2End = 1;
        double interval3Start = -10;
        double interval3End = -2;

        // Testing the membership
        bool condition1 = (x >= interval1Start) && (x < interval1End);
        bool condition2 = (x > interval2Start) && (x <= interval2End);
        bool condition3 = (x >= interval3Start) && (x <= interval3End);

        // Displaying output based on the logical operators
        if (((condition1 || condition2) || (condition3)))
        {
            Console.WriteLine("x belongs to I");
        }
        else
        {
            Console.WriteLine("x does not belong to I");
        }
    }
}
