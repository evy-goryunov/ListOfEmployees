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
		public string _department { get; private set; }

		public Employee(string firstName, string secondName, string age, string salary, string department)
		{
			this._firstName = firstName;
			this._secondName = secondName;
			this._age = age;
			this._salary = salary;
			this._department = department;
		}
		//переопределим для корректного отображения данных в box
		public override string ToString()
		{
			return "Имя: " +_firstName + "\n" + "Фамилия: " + _secondName + "\n" +
				   "Возраст: " + _age + "\n" + "Зарплата: " + _salary + "\n" + "Отдел :" + _department;
		}

		public void SetAge(string age)
		{
			this._age = age;
		}

	}
}
