using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        void DisplayWelcome() {
            Console.WriteLine("Dear guest, Welcome!");
        }

        PromptUserName();
        string PromptUserName() {
            Console.Write("Please! Enter your full name: ");
            string name = Console.ReadLine();
            return name;
        }

        PromptUserNumber();
        int PromptUserNumber() {
            Console.Write("Please! Enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        SquareNumber(4);
        int SquareNumber(int a) {
            int square = a^2;
            return square;
        }

        DisplayResult();
        void DisplayResult() {
            Console.Write("Please! Enter your full name: ");
            string name = Console.ReadLine();
            Console.Write("Please! Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int square = number*number;
            Console.WriteLine($"Dear {name}, the square of your number is {square}");
        }
    }
}