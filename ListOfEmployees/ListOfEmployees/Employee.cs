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
		public string _firstName { get; private set; } //Имя
		public string _secondName { get; private set; }//Фамилия
		public int _age { get; private set; }          //Возраст
		public int _salary { get; private set; }       //Зарплата
		public string _department { get; private set; }//Отдел
		public int _id { get; private set; }           //ID

		public Employee(string firstName, string secondName, int age, int salary, string department)
		{
			this._firstName = firstName;
			this._secondName = secondName;
			this._age = age;
			this._salary = salary;
			this._department = department;
		}
		//переопределим для корректного отображения данных в listbox
		public override string ToString()
		{
			return "Имя: " + _firstName + "\n" + "Фамилия: " + _secondName + "\n" +
				   "Возраст: " + _age + "\n" + "Зарплата: " + _salary + "\n" + "Отдел: " + _department
				   + "\n" + "ID: " + _id;
		}
		//редактируем зарплату
		public void SetSalary(int salary) => _salary = salary;
		//редактируем отдел
		public void SetDepartment(string department) => _department = department;
		//добовляем ID
		public void SetId(int id) => _id = id;

	}
}
