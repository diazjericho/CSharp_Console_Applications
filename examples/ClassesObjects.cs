using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Console_Applications___SOFDES.examples {
    // encapsulation
    class BankAccount {
        private double balance;

        public void Deposit(double amount) {
            if (amount > 0) {
                // balance = balance + amount;
                balance += amount;
            }
        }

        public void Withdraw(double amount) {
            if (amount > 0 && amount <= balance) {
                balance -= amount;
            }
            else {
                Console.WriteLine("Insufficient funds. Please try again.");
            }
        }

        public double GetBalance() {
            return balance;
        }
    }

    // inheritance
    class Person {
        public string Name { get; set; }
        public int Age { get; set; }

        public void DisplayInfo() {
            Console.WriteLine($"Name: {Name} Age: {Age}");
        }
    }

    class Student : Person {
        public int StudentID { get; set; }

        public void ShowStudentInfo() {
            DisplayInfo();
            Console.WriteLine($"Student ID: {StudentID}");
        }
    }

    // polyphorm
    class Animal {
        public virtual void MakeSound() {
            Console.WriteLine("Arf");
        }
    }
    class Dog : Animal {
        public override void MakeSound() {
            Console.WriteLine("Arf arf");
        }
    }
    class Cat : Animal {
        public override void MakeSound() {
            Console.WriteLine("Meow meow");
        }
    }

    // abstract
    abstract class Shape {
        public abstract double CalculateArea();
    }

    class Circle : Shape {
        private double radius;

        public Circle(double radius) {
            this.radius = radius;
        }

        public override double CalculateArea() {
            return Math.PI * radius * radius;
        }
    }

    class Rectangle : Shape {
        private double width, height;

        public Rectangle(double width, double height) {
            this.width = width;
            this.height = height;
        }

        public override double CalculateArea() {
            return width * height;
        }
    }

    // interface
    interface IVehicle {
        void Start();
    }
    class Car : IVehicle {
        public void Start() {
            Console.WriteLine("Broom broom brrr");
        }
    }
    class Bike : IVehicle {
        public void Start() {
            Console.WriteLine("Peeeep");
        }
    }

    // enum
    enum DayOfWeek {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6,
        Sunday = 7,
    }

    static class ClassesObjects {
        static void encapsulation() {
            BankAccount bankAcct = new BankAccount();
            Console.WriteLine($"Current balance: {bankAcct.GetBalance()}");

            bankAcct.Deposit(1000000);
            Console.WriteLine($"Current balance: {bankAcct.GetBalance()}");

            bankAcct.Withdraw(99000);
            Console.WriteLine($"Current balance: {bankAcct.GetBalance()}");
        }

        static void inheritance() {
            Student studentInfo = new Student();
            studentInfo.Name = "Jericho Diaz";
            studentInfo.Age = 69;
            studentInfo.StudentID = 679;

            studentInfo.ShowStudentInfo();
        }

        static void polyphormism() {
            Animal myDog = new Dog();
            Animal myCat = new Cat();

            myDog.MakeSound();
            myCat.MakeSound();
        }

        static void abstraction() {
            Shape circle = new Circle(5);
            Shape rectangle = new Rectangle(5, 10);

            Console.WriteLine($"Circle Area: {circle.CalculateArea()}");
            Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea()}");
        }

        static void interfaceEx() {
            IVehicle car = new Car();
            IVehicle bike = new Bike();

            car.Start();
            bike.Start();
        }

        static void enumEx() {
            Console.WriteLine("Enter the number u want: ");
            int day = int.Parse(Console.ReadLine());

            if (day >= 1 && day <= 7) {
                DayOfWeek dayWeek = (DayOfWeek)day;
                Console.WriteLine($"You picked {dayWeek}");
            }
            else {
                Console.WriteLine("?????");
            }
        }
        static void Main(string[] args) {
            // encapsulation();
            // inheritance();
            // polyphormism();
            // abstraction();
            // interfaceEx();
            // enumEx();
        }
    }
}
