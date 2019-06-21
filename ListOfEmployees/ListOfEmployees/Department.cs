using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfEmployees
{
	class Department
	{
		public string _departmentName { get; private set; }
		//public static int _countOfEmployees { get; private set; }

		public Department(string departmentName)
		{
			this._departmentName = departmentName;
		}
		public override string ToString()
		{
			return "Отдел:" + " " +_departmentName;
		}
	}
}
