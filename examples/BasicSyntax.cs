using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Console_Applications___SOFDES.examples {
    internal class BasicSyntax {

        /* 1) Write a C# program that declares an integer variable age with a value of 25 and a string variable name with the value "Alex". 
         * Print them using a single Console.WriteLine() statement. */
        static void example1() {
            int age = 25;
            string name = "Alex";

            Console.WriteLine($"My name is {name} and my age is {age}.");
            Console.WriteLine("My name is " + name + " and my age is " + age);
        }

        /* 2) Write a C# program that asks the user for their name and age, and then prints a message like "Hello Alex, you are 25 years old!". */
        static void example2() {
            string name;
            int age;

            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            Console.Write("Enter your age: ");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine($"Hello {name}! Your age is {age}");
        }

        /* 3) Write a C# program that checks if a given number is positive, negative, or zero. Use if-else statements only.*/
        static void example3() {
            int number;

            Console.Write("Enter your number: ");

            number = int.Parse(Console.ReadLine());

            if (number > 0) {
                Console.Write($"{number} is positive.");
            }
            else if (number < 0) {
                Console.Write($"{number} is negative.");
            }
            else {
                Console.Write($"{number} is zero.");
            }
        }

        /* 4) Write a C# program that takes a number (1–3) as input and prints the corresponding day of the week (1 = Monday, 2 = Tuesday, 3 = Wednesday). 
         * If the number is not between 1 and 3, print "Invalid input.". Use switch statements only. */
        static void example4() {
            int number;

            Console.Write("Enter your number: ");

            number = int.Parse(Console.ReadLine());

            switch (number) {
                case 1:
                    Console.Write("Monday");
                    break;
                case 2:
                    Console.Write("Tuesday");
                    break;
                case 3:
                    Console.Write("Wednesday");
                    break;
                default:
                    Console.Write("Invalid input");
                    break;

            }
        }

        /* 5) Write a C# program that asks the user to input 5 numbers and calculates their total sum using a for loop. */
        static void example5() {
            int sum = 0;

            Console.WriteLine("Enter 5 numbers:");
            for (int i = 0; i <= 4; i++) {
                Console.Write($"Number {i}: ");
                int number = int.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine($"The sum of the numbers is {sum}.");
        }

        /* 6) Write a C# program that asks the user for a number and prints its multiplication table (1–10) using a while loop. */
        static void example6() {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int i = 1;

            Console.WriteLine($"Multiplication table for {number}:");
            while (i <= 10) {
                Console.WriteLine($"{number} x {i} = {number * i}");
                i++;
            }

        }

        static void Main(string[] args) {
            while (true) { 
                Console.Clear();
                Console.WriteLine("==== Example Menu ====");
                Console.WriteLine("1. Example 1");
                Console.WriteLine("2. Example 2");
                Console.WriteLine("3. Example 3");
                Console.WriteLine("4. Example 4");
                Console.WriteLine("5. Example 5");
                Console.WriteLine("6. Example 6");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                Console.Clear(); // Clear screen before running the example

                switch (choice) {
                    case "1":
                        example1();
                        break;
                    case "2":
                        example2();
                        break;
                    case "3":
                        example3();
                        break;
                    case "4":
                        example4();
                        break;
                    case "5":
                        example5();
                        break;
                    case "6":
                        example6();
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
