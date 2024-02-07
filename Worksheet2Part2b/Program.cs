namespace Worksheet2Part2b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfYears = GetNumberOfYearsFromUser();
            int totalRainfall = 0;
            int numberOfMonths = 0;

            int[,] rainFallData = new int[numberOfYears,12];

            for (int i =0; i<numberOfYears; i++)
            {
                Console.WriteLine($"Year {i+1}");

                for (int j=0; j<12; j++)
                {
                    Console.Write($"Enter rainfall for year {i+1} month {j+1} >");
                    rainFallData[1,j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < numberOfYears; i++)
            {
              
                for (int j = 0; j < 12; j++)
                {
                   totalRainfall += rainFallData[i,j];
                    numberOfMonths++;
                }
            }

            Console.WriteLine($"Total Number of Months {numberOfMonths}");
            Console.WriteLine($"Total Rainfail {totalRainfall}");

        
            Console.WriteLine($"Average Rainfaill per month {(double)totalRainfall / numberOfMonths}");

        }

        /// <summary>
        ///  keeps asking the user for an integer until they enter one greater than 0 then
        ///  it returns that integer.
        /// </summary>
        /// <returns>and integer >0</returns>

        static int GetNumberOfYearsFromUser()
        {
            Console.Write("Please enter the number of years > ");
            int numberOfYears = int.Parse(Console.ReadLine());

            while (numberOfYears <= 0)
            {
                Console.WriteLine("Number of years must be greater than or equal to zero");
                Console.Write("Please enter the number of years > ");
               numberOfYears = int.Parse(Console.ReadLine());
            }

            return numberOfYears;
        }
    }
}