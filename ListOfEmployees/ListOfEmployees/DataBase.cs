using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfEmployees
{
	class DataBase
	{
		public ObservableCollection<Employee> dbEmployee { get; private set; } = new ObservableCollection<Employee>();
		public ObservableCollection<Department> dbDepartment { get; private set; } = new ObservableCollection<Department>();

		public DataBase(Employee e)
		{
			this.dbEmployee.Add(e);
		}

		public DataBase(Department d)
		{
			this.dbDepartment.Add(d);
		}
	}
}
