namespace Worksheet2Part2Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfStores = 5;

            int[] storesSales = new int[numberOfStores];


            for (int i =0; i < numberOfStores; i++)
            {
                Console.Write($"Enter sales for store {i+1}:");
                storesSales[i] = int.Parse(Console.ReadLine());
            }

            for (int i =0; i < numberOfStores; i++)
            {
                Console.Write($"Store{i+1}");

                for (int j=0;j < storesSales[i] /100; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}