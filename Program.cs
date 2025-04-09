using System.ComponentModel.Design;
using static System.Formats.Asn1.AsnWriter;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Function_ExercisesPart2
{
    internal class Program
    {
        //Add methods (Overloaded)________
        //to print int_____
        public static void printValue(int input)
        {
            Console.WriteLine("the result of this operation is: " + input);
        }

        //to print double______
        public static void printValue(double input)
        {
            Console.WriteLine("the result of this operation is: " + input);
        }
        //to print string_____
        public static void printValue(string input)
        {
            Console.WriteLine("the result of this operation is: " + input);
        }
        //to print char_____
        public static void printValue(char input)
        {
            Console.WriteLine("the result of this operation is: " + input);
        }
        //------------- EvenOrOddNumber (1)----------
        public static string GuessEvemnOrOdd(int number)
        {
            if (number % 2 == 0)
                return "Even";
            else
                return "Odd";
        }
        //---------the largest Number (2)------------
        public static int largestNumber(int num1, int num2, int num3)
        {

            int largest = num1;

            if (largest > num2)
            {
                if (largest > num3)
                    largest = num1;
            }
            else
            {
                largest = num2;

                if (largest > num3)
                    largest = num2;
                else
                    largest = num3;

            }
            return largest;
        }
        //----------Temperature Converter (3)--------------
        public static double TemperatureConverter(double celsius, double fahrenheit)
        {
            return fahrenheit = (celsius * 9 / 5) + 32;
        }
        //------------- Simple Discount Calculator (4)----------
        public static double SimpleDiscountCalculator(double price, double discount, double finalPrice)
        {
            if (price > 100)
            {
                return discount = (price / 100) * 10;
            }
            else
            {
                return finalPrice = price - discount;
            }

        }
        //------------Grading System (5)-------------------
        public static int GradingSystem(int score, char grade)
        {
            if (score >= 90)
                grade = 'A';
            else if (score >= 80)
                grade = 'B';
            else if (score >= 70)
                grade = 'C';
            else if (score >= 60)
                grade = 'D';
            else
                grade = 'F';

            return grade;
        }
        //-------------Swap Two Numbers(6)---------------
        public static string SwapTwoNumbers(int num1, int num2)
        {
            int number1, number2, temp;
            string message;

            temp = num1;
            number1 = num2;
            number2 = temp;

            message = "Your numbers after swap: \n" + "firstnumber:\n" + number1 +
                      "secondnumber:\n" + number2;

            return message;
        }

        //------Days to Weeks and Days Converte (7)------
        public static string DaysToWeeksAndDaysConverter(int input)
        {
            int weeks, days;
            string message;
            weeks = input / 7;
            days = input % 7;

            message = "Then number of weeks you have is:" + weeks +
                      "\n Then number of days you have is:" + days;
            return message;
        }

        //--------Electricity Bill Calculator (8)--------
        public static double ElectricityBillCalculator(double input)
        {
            double bill;

            if (input <= 100)
            {
                bill = 0.5 * input;
            }
            else if (input <= 300)
            {
                bill = 0.75 * input;
            }
            else
            {
                bill = 1 * input;
            }

            return bill;
        }


        static void Main(string[] args)
        {
            char choice;
            double balance = 1000;
            do
            {
                Console.WriteLine("Welcome to program menu \n 1. Check Even or Odd: \n 2. The Largest number is:  \n 3. Temperature in Fahrenheit: \n" +
                        " 4. the price of the item is: \n 5.The student's grade is:\n 6.Number after swapping:\n 7. Days to Weeks and Days Converter:\n" +
                        " 8. Electricity Bill Calculator is: \n 9. Simple Calculator:   ");
                int choice2 = int.Parse(Console.ReadLine());

                switch (choice2)
                {
                    case 1:
                        Console.WriteLine("Enter number");
                        int input = int.Parse(Console.ReadLine());
                        string result1 = GuessEvemnOrOdd(input);
                        printValue(result1);

                        break;

                    case 2:
                        Console.WriteLine(" Enter the first number: ");
                        int num1 = int.Parse(Console.ReadLine());

                        Console.WriteLine(" Enter the second number: ");
                        int num2 = int.Parse(Console.ReadLine());

                        Console.WriteLine(" Enter the third number: ");
                        int num3 = int.Parse(Console.ReadLine());

                        string result2 = largestNumber(num1, num2, num3).ToString();
                        printValue(result2);
                        break;

                    case 3:
                        Console.Write("Enter temperature in Celsius: ");
                        double celsius = double.Parse(Console.ReadLine());
                        double fahrenheit = double.Parse(Console.ReadLine());

                        string result3 = TemperatureConverter(celsius, fahrenheit).ToString();
                        printValue(result3);
                        break;
                    case 4:
                        Console.Write("enter the price of the item ");
                        double price = double.Parse(Console.ReadLine());
                        double discount = double.Parse(Console.ReadLine());
                        double finalPrice = double.Parse(Console.ReadLine());

                        string result4 = SimpleDiscountCalculator(price, discount, finalPrice).ToString();
                        printValue(result4);
                        break;
                    case 5:
                        Console.Write("enter the student's score ");
                        int score = int.Parse(Console.ReadLine());
                        char grade = char.Parse(Console.ReadLine());

                        string result5 = GradingSystem(score, grade).ToString();
                        printValue(result5);
                        break;
                    case 6:
                        int firestnumber, secondnumber;
                        Console.WriteLine(" enter the first number ");
                        firestnumber = int.Parse(Console.ReadLine());
                        Console.WriteLine(" enter the second number ");
                        secondnumber = int.Parse(Console.ReadLine());

                        string result6 = SwapTwoNumbers(firestnumber, secondnumber).ToString();
                        printValue(result6);
                        break;
                    case 7:

                        int remainingdays;
                        Console.WriteLine("Enter your the number of days:");
                        remainingdays = int.Parse(Console.ReadLine());

                        string result7 = DaysToWeeksAndDaysConverter(remainingdays);
                        printValue(result7);

                        break;
                    case 8:

                        double units;
                        Console.WriteLine("Enter the number of your consumed:");
                        units = double.Parse(Console.ReadLine());

                        double result8 = ElectricityBillCalculator(units);
                        printValue(result8);

                        break;





                    default:
                        Console.WriteLine("Wrong Choice!");
                        break;
                }

                Console.WriteLine("Do you want another operation ? y / n");
                choice = Console.ReadKey().KeyChar;

            } while (choice == 'y' || choice == 'Y');
            Console.WriteLine("Good-Bye!");
        }
    }
}