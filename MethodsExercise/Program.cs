using Microsoft.VisualBasic;
using System;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Exercise 1


            //Console.WriteLine("Hello, what is your first name?");
            //var userName = Console.ReadLine();

            //Console.WriteLine($"Hi {userName}, what is your favorite city?");
            //var city = Console.ReadLine();

            //Console.WriteLine($"{city} is my favorite city too! What is your favorite sport?");
            //var sport = Console.ReadLine();

            //Console.WriteLine($"{sport} is the best! Last question, what is your favorite band?");
            //var band = Console.ReadLine();

            //Console.WriteLine($"Thanks {userName}! Here is your complete profile:");
            //Console.WriteLine("==============================================");

            //Console.WriteLine($"First Name: {userName}");
            //Console.WriteLine($"Favorite City: {city}");
            //Console.WriteLine($"Favorite Sport: {sport}");
            //Console.WriteLine($"Favorite Band: {band}");
            //Console.WriteLine("==============================================");

            //Console.WriteLine($"Now, this is a story all about how" +
            //    $" {userName}'s life got flipped-turned upside down." +
            //    $" And I'd like to take a minute," +
            //    $" Just sit right there," +
            //    $" I'll tell you how {userName} became the prince of a town called {city}." +
            //    $" In West Philadelphia born and raised," +
            //    $" On the playground was where {userName} spent most of their days," +
            //    $" Chillin' out, maxin', relaxin', all cool," +
            //    $" And all playin' some {sport} outside of the school." +
            //    $" When a couple of guys who were up to no good," +
            //    $" Started making trouble in {userName}'s neighborhood." +
            //    $" They got in one little fight and their mom got scared." +
            //    $" She said, 'You're movin' with your auntie and uncle in {city}'." +
            //    $" {userName} begged and pleaded with her day after day," +
            //    $" But she packed {userName}'s suitcase and sent them on their way." +
            //    $" She gave {userName} a kiss and then she gave them the ticket." +
            //    $" {userName} put the Walkman on and said, 'I might as well kick it with {band}'.");

            Console.WriteLine("Please provide the 1st number to add.");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please provide the 2nd number.");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2, 2, 4, 6, 8);
            Console.WriteLine($"Challenge - The sum of the user defined values + static numbers (2, 4, 6, 8) is {sum}");
            Console.WriteLine("==============================================");

            Console.WriteLine("Please provide the 1st number to multiply.");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please provide the 2nd number.");
            num2 = int.Parse(Console.ReadLine());

            int product = Multiply(num1, num2);
            Console.WriteLine($"The product of those two numbers is {product}");

        }

        //Exercise 2 - Calculator - Challenge

        public static int Sum(params int[] list)
        {
            int sum = 0;
            for (int i = 0; i < list.Length; i++)
            {
                sum = sum + list[i];
            }
            return sum;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }

    }
}
