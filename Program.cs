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
                    
                    break;

                case 3:
                   

                    break;

                default:

                    break;


            }

        }
    }
}
