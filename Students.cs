using System;

namespace StudentManagementSystem
{
    // Inheritance: Student inherits all fields, properties, and methods from Person
    internal class Student : Person
    {
        // Private Fields unique to Student
        private int _id;
        private double _marks;

        // Public Properties
        public int Id
        {
            get { return _id; } // Read-Only Safety: Immutable identity after construction
        }

        public double Marks
        {
            get { return _marks; }
            set
            {
                // Data Validation Interceptor
                if (value >= 0 && value <= 100)
                {
                    _marks = value;
                }
            }
        }

        // Constructor Contract passing the name to the base Person constructor
        public Student(int id, string name, double marks) : base(name)
        {
            _id = id;
            _marks = marks;
        }

        // Polymorphism: Overriding the base class method to provide specialized behavior
        public override void DisplayDetails()
        {
            base.DisplayDetails(); // Invokes base Person display logic
            Console.WriteLine($" | ID: {_id} | Marks: {_marks}%");
        }
    }
}