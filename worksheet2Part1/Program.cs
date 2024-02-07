

using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Mworksheet2Part1
{
    public class Program
    {

        // This program contains the methods for Worksheet Week2 Part 1
        // along with a set of tests for each of the methods.
        static void Main(string[] args)

        {
            #region Q1Tests

            //Console.WriteLine(SumOddNumbers(2, 5) == 8);
            //Console.WriteLine(SumOddNumbers(-2, 5) == 8);
            //Console.WriteLine(SumOddNumbers(-3, 10) == 21);
            //Console.WriteLine(SumOddNumbers(2, -1) == 0);
            //Console.WriteLine(SumOddNumbers(-2, -5) == -8);
            //Console.WriteLine(SumOddNumbers(2, 2) == 0);
            //Console.WriteLine(SumOddNumbers(3, 3) == 3);
            //Console.WriteLine(SumOddNumbers(3, -1) == 3);

            #endregion

            #region Q2tests

            //int[] testArray = { };
            //Console.WriteLine(IsSortedAscending(testArray) == true);
            //int[] testArray2 = { 30, 40, 50, 60 };
            //Console.WriteLine(IsSortedAscending(testArray2) == true);
            //int[] testArray3 = { -90, 5600, 50, 60, 40, 20 };
            //Console.WriteLine(IsSortedAscending(testArray3) == false);
            //int[] testArray4 = { -90 };
            //Console.WriteLine(IsSortedAscending(testArray4) == true);
            //int[] testArray5 = { 40, 40, 100, 100, 56, 56 };
            //Console.WriteLine(IsSortedAscending(testArray5) == false);
            //int[] testArray6 = { 40, 40, 100, 100, 156, 156 };
            //Console.WriteLine(IsSortedAscending(testArray6) == true);

            #endregion

            #region Q3tests
            //Console.WriteLine(IsValidAge(17) == false);
            //Console.WriteLine(IsValidAge(18) == true);
            //Console.WriteLine(IsValidAge(19) == true);
            //Console.WriteLine(IsValidAge(21) == true);
            //Console.WriteLine(IsValidAge(22) == false);

            #endregion

            #region Q4tests

            //int[] testArray1 = { 1, 2, 3 };
            //AllTheNines(testArray1);
            //Console.WriteLine((testArray1[0] == 9) && (testArray1[1] == 9)
            //     && (testArray1[2] == 9) == true);
            ;
            #endregion

            #region Q5tests
            //int[] marks = { };
            //Console.WriteLine(CountPasses(marks) == 0);
            //int[] marks2 = { 30, 40, 50, 60 };
            //Console.WriteLine(CountPasses(marks2) == 3);
            //int[] marks3 = { -90, 5600, 50, 60, 40, 20 };
            //Console.WriteLine(CountPasses(marks3) == 4);
            //int[] marks4 = { -90, 39, 10, 23 };
            //Console.WriteLine(CountPasses(marks4) == 0);
            //int[] marks5 = { 40, 40, 100, 60, 56, 96 };
            //Console.WriteLine(CountPasses(marks5) == 6);

            #endregion

            #region Q6tests
            //int[] marks6 = { };
            //Console.WriteLine(CountPasses(marks6, 40) == 0);
            //Console.WriteLine(CountPasses(marks6, 0) == 0);
            //int[] marks7 = { 30, 40, 50, 60 };
            //Console.WriteLine(CountPasses(marks7, 40) == 3);
            //Console.WriteLine(CountPasses(marks7, 30) == 4);
            //int[] marks8 = { -90, 5600, 50, 60, 40, 20 };
            //Console.WriteLine(CountPasses(marks8, 40) == 4);
            //Console.WriteLine(CountPasses(marks8, -10) == 5);
            //int[] marks9 = { -90, 39, 10, 23 };
            //Console.WriteLine(CountPasses(marks9, 40) == 0);
            //Console.WriteLine(CountPasses(marks9, 39) == 1);
            //int[] marks10 = { 40, 40, 100, 60, 56, 96 };
            //Console.WriteLine(CountPasses(marks10, 40) == 6);

            #endregion

            #region Q7tests
            //Console.WriteLine(GetProductCost("ABC") == 10.10m);
            //Console.WriteLine(GetProductCost("FR45") == 34m);
            //Console.WriteLine(GetProductCost("XYZ") == 69.34m);
            //Console.WriteLine(GetProductCost("G65") == 5m);
            //Console.WriteLine(GetProductCost("AS34") == -999m);
            //Console.WriteLine(GetProductCost("S34") == 5m);
            #endregion

            #region Q8tests
            //opps this was a repeat of Q1 - did you notice??

            #endregion

            #region Q9tests

            // do these yourself  :)

            #endregion
            #region Q10tests

            // do these yourself  :)

            #endregion


            #region Q11tests

            // note: you need to be careful when testing numbers
            // that are the float type.
            // calculations with floating numbers can be slighly imprecise so
            // if you are using equality you will sometimes get failed tests even
            // though the difference is minimal.
            // This doesn't really apply in this case but when doing programming with
            // lots of repeating calculations on floating numbers you normally specify
            // how precisely you want the answers to be compared.

            //Console.WriteLine(CalculateCompoundBalance(200, .05m, 3) == 231.525m);

            //Console.WriteLine(CalculateCompoundBalance(200, .05m, 0) == 200);
            //Console.WriteLine(Math.Round(CalculateCompoundBalance(5000, .06m, 7), 2) == 7518.15m);

            // should have some more tests

            #endregion


            #region Q12 tests

            Console.WriteLine(Encrypt("abc") == "bac");
            Console.WriteLine(Encrypt("abcd") == "badc");
            Console.WriteLine(Encrypt("") == "");
            Console.WriteLine(Encrypt("d") == "d");
            Console.WriteLine(Encrypt("my secrets") == "yms ceerst");

            #endregion




        }

        /// <summary>
        /// that accepts an int array as an argument and stores the value 9 in each element.
        /// It is different than the other methods as it changes the values that are stored in the argument
        /// which is passed to it. This is because int[] is a reference type.
        /// So a reference to the location where the data is stored is passed into the method
        /// rather than a copy of the values in the array.
        /// </summary>
        /// <param name="anArray"></param>
        static void AllTheNines(int[] anArray)
        {
            for (int i = 0; i < anArray.Length; i++)
            {
                anArray[i] = 9;
            }
        }

        static decimal GetProductCost(string productCode)
        {
            decimal cost;
            switch (productCode)
            {

                case "ABC":
                    cost = 10.10m;
                    break;
                case "XYZ":
                    cost = 69.34m;
                    break;
                case "FR45":
                    cost = 34m;
                    break;
                case "S34" or "G65":
                case "F34":
                    cost = 5;
                    break;
                default:
                    cost = -999;
                    break;
            }

            return cost;
            //return productCode switch
            //{
            //    "ABC" => 10.10m,
            //    "XYZ" => 69.34m,
            //    "FR45" => 34m,
            //    "S34" or "G65" or "F34" => 5m,
            //    _ => -999
            //};

            //    case "FR45":
            //        cost = 34m;
            //        break;
            //    case "S34":
            //    case "G65":
            //    case "F34":
            //        cost = 5;
            //        break;
            //    default:
            //        cost = -999;
            //        break;
            //  }



        }


        static int CountPasses(int[] marks)
        {
            int count = 0;
            foreach (int i in marks)
            {
                if (i >= 40)
                {
                    count++;
                }
            }
            return count;
        }

        static int CountPasses(int[] marks, int passValue)
        {
            int count = 0;
            foreach (int i in marks)
            {
                if (i >= passValue)
                {
                    count++;
                }
            }
            return count;
        }

        /// <summary>
        /// Returns true if the age is between 18 and 21 inclusive.
        /// This can also be done using an if statement (or 2 if statements)
        /// which do you think is the neater way of doing things??
        /// </summary>
        /// <param name="age"></param>
        /// <returns></returns>
        static bool IsValidAge(int age)
        {
            return (age >= 18 && age <= 21);
        }

        /// <summary>
        /// Takes two integers and returns the sum of the odd numbers between them.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        static int SumOddNumbers(int num1, int num2)
        {
            int sum = 0;


            // swap if the second number is bigger than the first
            if (num1 > num2)
            {
                int temp = num1;
                num1 = num2;
                num2 = temp;
            }


            for (int i = num1; i <= num2; i++)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                }
            }

            return sum;
        }

        static int GetRentalCharge(int numberOfDays)
        {
            int cost = 0;

            if (numberOfDays <= 5)
            {
                cost = numberOfDays * 5;
            }
            else
            {
                cost = 25 + (numberOfDays - 5) * 8;
            }

            return Math.Min(15, cost);

        }

        static bool IsSortedAscending(int[] anArray)
        {

            if (anArray.Length == 0 || anArray.Length == 1)
                return true;

            for (int i = 0; i < anArray.Length - 1; i++)
            {
                if (anArray[i] > anArray[i + 1])
                {
                    return false;
                }
            }

            return true;
        }

        static int GetNewBalance(int balance, int deposit)
        {
            return (balance + deposit);
        }

        static decimal CalculateCompoundBalance(decimal balance, decimal rate, int term)
        {
            for (int i = 0; i < term; i++)
            {
                balance += balance * rate;
            }
            return balance;
        }



        static decimal GetDiscountRate(int numberOfChildren)
        {
            decimal rate;

            //switch
            //    {
            //    case 0:
            //        rate =0m
            //            break;
            //        case 
            //}

            return rate = 0;
        }



        static string Encrypt(string str)
        {
            char[] charArray = str.ToCharArray();

            for (int i = 0; i < charArray.Length - 1; i += 2)
            {
                char temp = charArray[i];
                charArray[i] = charArray[i + 1];
                charArray[i + 1] = temp;
            }

            return new string(charArray);
        }
    }


}
