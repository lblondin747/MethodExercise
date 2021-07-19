using System;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your Favorite color?");
            string favColor = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string favAnimal = Console.ReadLine();
            Console.WriteLine("What is your favorite band");
            string favBand = Console.ReadLine();
            Console.WriteLine($"{name} went on a hike with a {favColor} {favAnimal} while {favBand} was having a concert in the woods.");
            Console.WriteLine("Enter an integer(a):");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter an integer(b):");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"a + b = {add(a,b)}" );
            Console.WriteLine($"a - b = {subtract(a, b)}");
            Console.WriteLine($"a * b = {multiply(a, b)}");
            Console.WriteLine($"a / b = {divide(a, b)}");
            Console.WriteLine($"a % b = {remainder(a, b)}");

        }
        public static int add(int a, int b)
        {
            return a + b;
        }
        public static int subtract(int a, int b)
        {
            return a - b;
        }
        public static int multiply(int a, int b)
        {
            return a * b;
        }
        public static double divide(int a, int b)
        {
            return a / b;
        }
        public static int remainder(int a, int b)
        {
            return a % b;
        }


    }
}
 