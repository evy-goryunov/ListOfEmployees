using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ListOfEmployees
{
	class Employee
	{
		public string _firstName { get; private set; }
		public string _secondName { get; private set; }
		public string _age { get; private set; }
		public string _salary { get; private set; }

		public Employee(string firstName, string secondName, string age, string salary)
		{
			this._firstName = firstName;
			this._secondName = secondName;
			this._age = age;
			this._salary = salary;
		}

		public static ObservableCollection<Employee> dbEmployee { get; set; } = new ObservableCollection<Employee>();

		public override string ToString()
		{
			return _firstName + " " + _secondName;
		}

	}
}
