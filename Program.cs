namespace csharpRampUP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("weight in Pounds : ");
            double pounds = Convert.ToDouble(Console.ReadLine());

            Console.Write("Length in Miles : ");
            double miles = Convert.ToSingle(Console.ReadLine());

            Console.Write("Temperature in Fahrenheit: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            double celsius = (fahrenheit - 32) * 5 / 9;

            double sum = 0;
            int[] userInput = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter age of student {i}: ");
                userInput[i] = Convert.ToInt32(Console.ReadLine());
                sum += userInput[i];
            }
            double average = sum / 10;


            string name1 = "roy";
            string name2 = "kaloy";
            string kayamanan = "treasure";


            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");


            //OUTPUTS.
            Console.WriteLine("weight in Pounds (lbs) {2.f}: " + pounds);
            Console.WriteLine("weight in Kilograms (kg) {2.f}: " + pounds * 0.45359237);
            Console.WriteLine("======================================================");

            Console.WriteLine("Length in Miles (mi) : " + miles);
            Console.WriteLine("Length in Kilometer (km) : " + miles * 1.6);
            Console.WriteLine("======================================================");

            Console.WriteLine("Temperature in Fahrenheit (°F): " + fahrenheit);
            Console.WriteLine("Temperature in Celsius (°C): " + celsius);
            Console.WriteLine("======================================================");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Age of student {i + 1}: {userInput[i]}");
            }
            Console.Write("The average age of the students is: " + average);


            Console.WriteLine($"once upon a time, \r\nOnce in a quaint village nestled between rolling hills, two boys, {name1} and {name2}," +
            $"discovered an ancient map that promised hidden {kayamanan} in the nearby forest. " +
            "With hearts pounding, they embarked on an unforgettable adventure," +
            "facing challenges, solving riddles, and forging a bond that would last a lifetime. " +
            "The treasure they uncovered wasn't gold or jewels but the joy of shared exploration and enduring friendship.");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Part 2:");
            Console.WriteLine("Enter a number:");
            int number1 = Convert.ToInt32(Console.ReadLine());

            if (number1 > 0)
            {
                for (int i = 1; i <= number1; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j + " ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

            Console.WriteLine();
            Console.WriteLine("Enter a number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int sumNum2 = number2 * (number2 + 1) / 2;
            if (number2 > 0)
            {
                Console.Write("Formula: ");
                for (int i = 1; i <= number2; i++)
                {

                    Console.Write(i);
                    if (i < number2)
                    {
                        Console.Write("+");
                    }
                }
                Console.WriteLine();
                Console.WriteLine($"Sum: {sumNum2}");
            }
            else

            {
                Console.WriteLine("Invalid input");

            }

            if (number1 > 0)
            {

                for (int i = number1; i >= 1; i--)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j + " ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}