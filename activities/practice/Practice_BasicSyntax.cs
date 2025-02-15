using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Console_Applications___SOFDES.activities.practice {
    internal class Practice_BasicSyntax {
        static void determineGrade() {
            Console.Write("Enter your score: ");
            int score = int.Parse(Console.ReadLine());

            if (score >= 90)
                Console.WriteLine("Your grade is A.");
            else if (score >= 80)
                Console.WriteLine("Your grade is B.");
            else if (score >= 70)
                Console.WriteLine("Your grade is C.");
            else if (score >= 60)
                Console.WriteLine("Your grade is D.");
            else
                Console.WriteLine("Your grade is F.");
        }

        static void factorial() {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            int factorial = 1;
            int i = 1;

            while (i <= num) {
                factorial *= i;
                i++;
            }

            Console.WriteLine($"Factorial of {num} is {factorial}");
        }


        static void numberCompare() {
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2) {
                Console.WriteLine($"{num1} is greater than {num2}.");
            }
            else if (num1 < num2) {
                Console.WriteLine($"{num1} is less than {num2}.");
            }
            else {
                Console.WriteLine($"{num1} is equal to {num2}.");
            }
        }

        static void userInfo() {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine($"Hello {name}, you are {age} years old.");

            switch (age) {
                case < 18:
                    Console.WriteLine("You are a minor.");
                    break;
                default:
                    Console.WriteLine("You are an adult.");
                    break;
            }
        }

        static void displayNumbers() {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Numbers from 1 to " + n + ":");
            for (int i = 1; i <= n; i++) {
                Console.Write(i + " ");
            }
        }

        static void Main(string[] args) {
            while (true) {
                Console.Clear();
                Console.WriteLine("==== Basic Syntax Menu ====");
                Console.WriteLine("1. Determine the Grade Level");
                Console.WriteLine("2. Factorial");
                Console.WriteLine("3. Comparison of Two Numbers");
                Console.WriteLine("4. User Information");
                Console.WriteLine("5. Display Numbers using For Loop");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                Console.Clear();

                switch (choice) {
                    case "1":
                        determineGrade();
                        break;
                    case "2":
                        factorial();
                        break;
                    case "3":
                        numberCompare();
                        break;
                    case "4":
                        userInfo();
                        break;
                    case "5":
                        displayNumbers();
                        break;
                    case "0":
                        Console.WriteLine("Exiting program...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }

                Console.WriteLine("\nPress any key to return to the menu...");
                Console.ReadKey();
            }
        }
    }
}
