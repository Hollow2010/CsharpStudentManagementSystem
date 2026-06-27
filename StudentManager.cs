using System;
using System.Collections.Generic;

namespace StudentManagementSystem
{
     public class StudentManager
    {
        private List<Student> _students = new List<Student>(); 

        public void addStudent(int id,string name,double marks)
        {
            Student newStudent = new Student(id,name,marks);

           _students.Add(newStudent);
           Console.WriteLine("New Student saved");
        }

        public void disolayAllStudents()
        {
             if (_students.Count == 0)
            {
                Console.WriteLine("No records found in execution memory.");
                return;
            }
            foreach (Student student in _students)
            {
                student.DisplayDetails(); // Invoking individual instance behaviors
            }
        }

    }
}