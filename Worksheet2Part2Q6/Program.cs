namespace Worksheet2Part2Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = "";


            Console.WriteLine(GetCardValueAndSuit("QS"));
            Console.WriteLine(GetCardValueAndSuit("10H"));
            Console.WriteLine(GetCardValueAndSuit("9c"));
            Console.WriteLine(GetCardValueAndSuit("JD"));




        }

        static string GetCardValueAndSuit(string abbreviationOfCard)
        {
            char suitCharacter = abbreviationOfCard.ToUpper()[abbreviationOfCard.Length - 1];

            return $"{GetCardValue(abbreviationOfCard)} of {GetSuitName(suitCharacter)}";
        }
        static string GetCardValue(string inputString)
        {
            if (inputString.Length == 3)
            {
                return "Ten";
            }

            string value = "";

            switch (inputString[0])
            {
                case 'A':
                    value = "Ace";
                    break;
                case '2':
                    value = "Two";
                    break;
                case '3':
                    value = "Three";
                    break;
                case '4':
                    value = "Four";
                    break;
                case '5':
                    value = "Five";
                    break;
                case '6':
                    value = "Six";
                    break;
                case '7':
                    value = "Seven";
                    break;
                case '8':
                    value = "Eight";
                    break;
                case '9':
                    value = "Nine";
                    break;
                case 'J':
                    value = "Jack";
                    break;
                case 'Q':
                    value = "Queen";
                    break;
                case 'K':
                    value = "King";
                    break;
            }

            return value;
        }


        static string GetSuitName(char suitCharacter)
        {

            string suit = "";

            switch (suitCharacter)
            {
                case 'H':
                    suit = "Hearts";
                    break;
                case 'D':
                    suit = "Diamonds";
                    break;
                case 'C':
                    suit = "Clubs";
                    break;
                case 'S':
                    suit = "Spades";
                    break;
            }

            return suit;
        }
    }
}