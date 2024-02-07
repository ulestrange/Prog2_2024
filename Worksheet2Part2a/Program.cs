namespace Worksheet2Part2a
{


    // this solutions uses a single loop
    // but it is not what the question asked for
        internal class Program
        {
            static void Main(string[] args)
            {
                //int numberOfYears = GetNumberOfYearsFromUser();

                //int numberOfMonths = numberOfYears * 2;

                //int[] rainFallPerMonth = new int[numberOfMonths];

                // GetRainFallForEachMonth(rainFallPerMonth);

                //  PrintRainFallStats(rainFallPerMonth);


                int[] rainFallPerMonth = { 10, 4, 5, 7, 89, 32, 11, 12, 204, 5, 6, 7, 8, 9 };

                PrintRainFallStats(rainFallPerMonth);


            }

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

            static void GetRainFallForEachMonth(int[] monthArray)
            {
                for (int i = 0; i < monthArray.Length; i++)
                {
                    Console.Write($"Please enter rainfall for month {i + 1} > ");
                    monthArray[i] = int.Parse(Console.ReadLine());
                }

            }

            static void PrintRainFallStats(int[] rainFallPerMonth)
            {

                int totalRainfall = 0;
                for (int i = 0; i < rainFallPerMonth.Length; i++)
                {
                    totalRainfall += rainFallPerMonth[i];
                }
                int numberOfMonths = rainFallPerMonth.Length;

                Console.WriteLine($"Total Number of Months {numberOfMonths}");
                Console.WriteLine($"Total Rainfail {totalRainfall}");

            Console.WriteLine($"answerAverage Rainfaill per month {totalRainfall / numberOfMonths} opps wrong answer");

            // note: we need to cast total rainfall to a double because otherwise we just have
            // integer division.
            Console.WriteLine($"Average Rainfaill per month {(double)totalRainfall / numberOfMonths}");
            }
        }
    }
