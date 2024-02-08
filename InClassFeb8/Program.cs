namespace InClassFeb8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int initalPopulation = GetPositiveIntegerFromUser("Please enter the initial population > ");

            // int percentageIncrease = GetPositiveIntegerFromUser("Enter the percentage increase > ")


           // int userChoice = GetMenuChoice();

            string[] choices =
            {
                "1: for first choice",
                "2: for second choice",
                "3: to exit"
            };


            int userChoice = GetMenuChoice(choices);


            while (userChoice != 3)
            {
                switch (userChoice)
                {
                    case 1:
                        Console.WriteLine("one");
                        break;
                    case 2:
                        Console.WriteLine("two");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }

                userChoice = GetMenuChoice();

            }
        }

        private static int GetMenuChoice()
        {
            Console.WriteLine("Main Menu");
            Console.WriteLine("1: for first choice");
            Console.WriteLine("2: for second choice");
            Console.WriteLine("3: To exit");

            int userChoice = int.Parse(Console.ReadLine());
            return userChoice;
        }

       static int GetMenuChoice(string[] menuChoices)
        {
            Console.WriteLine("Main Menu");
            for (int i=0; i<menuChoices.Length; i++)
            {
                Console.WriteLine(menuChoices[i]);
            }

            int userChoice = int.Parse(Console.ReadLine());
            return userChoice;
        }





        static int GetPositiveIntegerFromUser(string prompt)
        {
            Console.Write(prompt);
            int userInput = int.Parse(Console.ReadLine());

            while (userInput <= 0)
            {
                Console.WriteLine("Input must be greater than or equal to zero");
                Console.Write(prompt);
                userInput = int.Parse(Console.ReadLine());
            }

            return userInput;
        }


        
    }

}