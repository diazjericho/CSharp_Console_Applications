using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using C__Console_Applications___SOFDES.examples.classes.basics;

namespace C__Console_Applications___SOFDES.examples {
    internal class AdvancedSyntax {

        /* 1) Create an array of 3 integers and calculate their sum. */
        static void example1() {
            int[] values = { 5, 10, 15 };
            int sum = values[0] + values[1] + values[2];

            Console.WriteLine($"The sum is: {sum}");

        }

        /* 2) Check if a string contains a specific word. */
        static void example2() {
            string sentence = "ganyan po ba dapat ang boses ng nagtatanong, maem?";
            bool containsWord = sentence.Contains("maem");

            Console.WriteLine($"Contains 'maem': {containsWord}");

        }

        /* 3) Print an array of numbers {2, 4, 6, 8} using foreach loop. */
        static void example3() {
            int[] numbers = { 2, 4, 6, 8 };

            foreach (int number in numbers) {
                Console.WriteLine($"Number: {number}");
            }
        }

        /* 4) Create a class Car with properties Make, Model, and a method DisplayInfo that prints car details. */
        static void example4() {
            Car car = new Car();
            car.Make = "Toyota";
            car.Model = "Hilux Conquest";

            car.displayInfo();
        }
        static void Main(string[] args) {
            while (true) {
                Console.Clear();
                Console.WriteLine("==== Example Menu ====");
                Console.WriteLine("1. Example 1");
                Console.WriteLine("2. Example 2");
                Console.WriteLine("3. Example 3");
                Console.WriteLine("4. Example 4");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                Console.Clear();

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
