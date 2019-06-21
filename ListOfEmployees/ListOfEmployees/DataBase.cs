using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfEmployees
{
/// <summary>
/// временно храним данные в оперативке с помощью этого класса,
/// потом будем использовать для подключения к настоящей БД
/// надеюсь пойму как всё хранить в sql на 7 занятии :)
/// </summary>
	static class DataBase
	{
		public static ObservableCollection<Employee> dbEmployee { get; set; } = new ObservableCollection<Employee>();
		public static ObservableCollection<Department> dbDepartment { get; set; } = new ObservableCollection<Department>();

	}
}
