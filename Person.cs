using System;

namespace StudentManagementSystem
{
	class Person
	{
		private string _name;
		
		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		public Person(string name)
		{
			_name = name;
		}

		public virtual void DisplayDetails()
		{
			Console.WriteLine($"Name: {_name}");
		}
	}
}