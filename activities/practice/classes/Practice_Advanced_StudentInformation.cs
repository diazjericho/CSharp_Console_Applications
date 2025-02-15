using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Console_Applications___SOFDES.activities.practice.classes {
    class Practice_Advanced_StudentInformation {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Course { get; set; }

        public void DisplayInfo() {
            Console.WriteLine($"Student Name: {Name}, Age: {Age}, Course: {Course}");
        }
    }
}
