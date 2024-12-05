namespace YearPercentage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;

            Console.Write("Enter the 1st Number: ");
            String number = Console.ReadLine();

            Console.WriteLine(Environment.NewLine);

            try
            {
                num1 = int.Parse(number);
            }
            catch (Exception e)
            {
                Console.WriteLine("!!Uh-Oh!!");
                Console.WriteLine($"Not a number! Setting to 0");
                Console.WriteLine(Environment.NewLine);

                num1 = 0;
            }

            Console.Write("Enter the 2nd Number: ");
            number = Console.ReadLine();

            try
            {
                num2 = int.Parse(number);
            }
            catch (Exception e)
            {
                Console.WriteLine("!!Uh-Oh!!");
                Console.WriteLine($"Not a number! Setting to 0");
                Console.WriteLine(Environment.NewLine);

                num2 = 0;
            }

            DoMath(num1, num2);
        }

        public static void DoMath(int num1, int num2)
        {
            int result = num1 + num2;

            Console.WriteLine($"\n----\nThe result of Adding the numbers is '{result}'----\n");

            int result2 = num1 * num2;

            Console.WriteLine($"\n----\nThe result of these numbers Multiplied is '{result2}'\n----");
        }
    }
}
