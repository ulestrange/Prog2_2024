namespace Worksheet2Part2Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // some tests
            

            CalculatePopulationPerDay(2, 20, 5);
            CalculatePopulationPerDay(2, 100, 20);
            CalculatePopulationPerDay(2, 100, 20);
        }


        static int GetInitialPopulationFromUser()
        {
            Console.Write("Please enter the inital population > ");
            int initalPopulation = int.Parse(Console.ReadLine());

            while (initalPopulation <= 0)
            {
                Console.WriteLine("Initial population must be greater than or equal to zero");
                Console.Write("Please enter the inital population > > ");
                initalPopulation = int.Parse(Console.ReadLine());
            }

            return initalPopulation;
        }
        static int GetPercentageIncreateFromUser()
        {
            Console.Write("Please enter the percentage increaase > ");
            int perentageIncrease = int.Parse(Console.ReadLine());

            while (perentageIncrease <= 0)
            {
                Console.WriteLine("Percentage Increate  must be greater than or equal to zero");
                Console.Write("Please enter the percentage increase > ");
                perentageIncrease = int.Parse(Console.ReadLine());
            }

            return perentageIncrease;
        }

        static int GetNumberOfDaysFromUser()
        {
            Console.Write("Please enter the number of days > ");
            int numberOfDays = int.Parse(Console.ReadLine());

            while (numberOfDays <= 0)
            {
                Console.WriteLine("Number of Days  must be greater than or equal to zero");
                Console.Write("Please enter the number of days >  ");
                numberOfDays = int.Parse(Console.ReadLine());
            }

            return numberOfDays;
        }
        static int CalculatePopulationPerDay (int startPopulation, int percentageIncrease, int duration)
        {
            // note we keep the population as an integer as you cannot have part of
            // an organism. So we will use integer division to round down to the nearest whole number.

            int currentPopulation = startPopulation;

            for (int i=0;i<duration; i++)
            {
                currentPopulation += (currentPopulation * percentageIncrease)/ 100;
                Console.WriteLine($"After {i+1} days population is {currentPopulation}");
            }

            return currentPopulation;
        }



    }
}