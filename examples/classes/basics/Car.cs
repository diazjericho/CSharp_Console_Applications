using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Console_Applications___SOFDES.examples.classes.basics {
    class Car {
        public string Make {  get; set; }
        public string Model { get; set; }

        public void displayInfo() {
            Console.WriteLine($"Your car is {Make} {Model}.");
        }
    }
}