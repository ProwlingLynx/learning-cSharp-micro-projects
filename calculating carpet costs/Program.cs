namespace calculating_carpet_costs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double costPerSquareFoot = 4.65; // cost in dollars
            Console.WriteLine("Please input the first side of the room in feet:");
            double firstLength = double.Parse(Console.ReadLine());
            Console.WriteLine("Please input the second side of the room in feet:");
            double secondLength = double.Parse(Console.ReadLine());

            double areaOfRoom = firstLength * secondLength;
            double totalCostOfCarpet = areaOfRoom * costPerSquareFoot;
            Console.WriteLine("The cost of the carpet is: {0} per sq. ft. Total cost for an area of {1} is ${2}",
                costPerSquareFoot, areaOfRoom, totalCostOfCarpet);
        }
    }
}