using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C__Console_Applications___SOFDES.activities.practice.classes;

namespace C__Console_Applications___SOFDES.activities.practice {
    internal class Practice_AdvancedSyntax {
        static void maximumNumber() {
            int[] numbers = { 12, 5, 7, 20, 15 };
            int max = numbers[0];

            foreach (int num in numbers) {
                if (num > max) {
                    max = num;
                }
            }

            Console.WriteLine($"The largest number is {max}.");
        }

        static void countVowels() {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine().ToLower();
            int vowelCount = 0;

            foreach (char c in input) {
                if ("aeiou".Contains(c)) {
                    vowelCount++;
                }
            }

            Console.WriteLine($"The number of vowels is {vowelCount}.");
        }

        static void reverseArray() {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int length = numbers.Length;

            Console.Write("Reversed array: ");
            for (int i = length - 1; i >= 0; i--) {
                Console.Write(numbers[i] + " ");
            }
        }

        static void studentInformation() {
            Practice_Advanced_StudentInformation student = new Practice_Advanced_StudentInformation();
            student.Name = "Jerjerking";
            student.Age = 69;
            student.Course = "Computer Engineering";

            student.DisplayInfo();
        }

        static void shapeCalculation() {
            Practice_Advanced_Rectangle rectangle = new Practice_Advanced_Rectangle();
            rectangle.Length = 5;
            rectangle.Width = 10;

            Console.WriteLine($"Area of the rectangle is {rectangle.CalculateArea()}");
        }

        static void Main(string[] args) {
            while (true) {
                Console.Clear();
                Console.WriteLine("==== Advanced Syntax Menu ====");
                Console.WriteLine("1. Find the Maximum Number");
                Console.WriteLine("2. Count Vowels in a String");
                Console.WriteLine("3. Reverse an Array of Numbers");
                Console.WriteLine("4. Student Information");
                Console.WriteLine("5. Calculate the Area for Rectangle");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                Console.Clear();

                switch (choice) {
                    case "1":
                        maximumNumber();
                        break;
                    case "2":
                        countVowels();
                        break;
                    case "3":
                        reverseArray();
                        break;
                    case "4":
                        studentInformation();
                        break;
                    case "5":
                        shapeCalculation();
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
