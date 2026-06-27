using system;
using System.Collections.Generic

namespace studentmanager
{
     public class Student
    {
        // 1. Private Fields (Encapsulated state variables hidden from external view)
1
        private int _id;
        private string _name;
        private double _marks;
        
        // 2. Public Properties (Access control gates managing security logic)
        public int Id 
        { 
            get { return _id; } 
        }
        public string Name 
        { 
            get { return _name; } 
            set { _name = value; } 
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
        // 3. Constructor Contract (Mandatory instance initialization engine)
        public Student(int id, string name, double marks)
        {
            _id = id;
            _name = name;
            _marks = marks;
        }
        // 4. Instance Behavior Method
        public void DisplayDetails()
        {
            Console.WriteLine($"ID: {_id} | Name: {_name} | Marks: {_marks}%");
        }
    }
}