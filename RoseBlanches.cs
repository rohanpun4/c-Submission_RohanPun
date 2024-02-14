using System;

class RoseBlanches
{
    static void Main()
    {
        Console.Write("How much money did you receive from your aunt ($)? ");
        double totalAmount = double.Parse(Console.ReadLine());

        // To calculate the three quarter amount for the books and the supplies
        int booksAndSupplies = (int)(0.75 * totalAmount);

        double leftAmount = 0.25 * totalAmount;
        double rest_part = leftAmount / 3;

        // To calculate the cost of the following items:
        double coffeeCost = 2;
        double flashComputerCost = 4;
        double subwayTicketCost = 3;
 
        // To caculate the cost with the remaining amount for the number of coffees, Flash computers and subway tickets
        int countCoffees = (int)(rest_part / coffeeCost);
        int countFlashComputers = (int)(rest_part / flashComputerCost);
        int countSubwayTickets = (int)(rest_part / subwayTicketCost);

        // To calculate the cost spent on each item
        double spentOnCoffees = countCoffees * coffeeCost;
        double spentOnFlashComputers = countFlashComputers * flashComputerCost;
        double spentOnSubwayTickets = countSubwayTickets * subwayTicketCost;

        // To calcluate the remaining cost for white roses
        double countWhiteFlowers = leftAmount - spentOnCoffees - spentOnFlashComputers - spentOnSubwayTickets;

        // Display output
        Console.WriteLine($"\nBook and Supplies: {booksAndSupplies} $");
        Console.WriteLine($"You can then buy:");
        Console.WriteLine($"{countCoffees} coffees");
        Console.WriteLine($"\n{countFlashComputers} Flash Computer Numbers");
        Console.WriteLine($"{countSubwayTickets} subway Tickets");
        Console.WriteLine($"and you will have {countWhiteFlowers} dollars for the white roses.");
    }
}
/// The following program displays the output as aksed by the question.