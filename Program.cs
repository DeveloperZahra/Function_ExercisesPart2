using System.ComponentModel.Design;
using static System.Formats.Asn1.AsnWriter;

namespace Function_ExercisesPart2
{
    internal class Program
    {
        public static void printValue(string input)
        {
            Console.WriteLine("the result of this operation is: " + input);
        }
        public static string GuessEvemnOrOdd(int number)
        {
            if (number % 2 == 0)
                return "Even";
            else
                return "Odd";
        }

        public static int largestNumber(int num1 , int num2, int num3)
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

        public static double TemperatureConverter(double celsius,double fahrenheit)
        {
           return fahrenheit = (celsius * 9 / 5) + 32;
        }

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

        static void Main(string[] args)
                {
                    Console.WriteLine("Welcome to program menu \n 1. Check Even or Odd: \n 2. The Largest number is:  \n 3. Temperature in Fahrenheit: \n" +
                        " 4. the price of the item is: \n 5.The student's grade is:\n 6.Number after swapping:\n 7. Days to Weeks and Days Converter:\n" +
                        " 8. Electricity Bill Calculator is: \n 9. Simple Calculator:   ");
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
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

                default:

                            break;


                    }

                }
    }
}
