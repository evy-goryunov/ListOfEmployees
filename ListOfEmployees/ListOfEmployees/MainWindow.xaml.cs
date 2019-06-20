using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
/// <summary>
///Создать сущности Employee и Department и заполнить списки сущностей начальными данными.

///Для списка сотрудников и списка департаментов предусмотреть визуализацию(отображение). 
///Это можно сделать, например, с использованием ComboBox или ListView.

///Предусмотреть редактирование сотрудников и департаментов.
///Должна быть возможность изменить департамент у сотрудника.
///Список департаментов для выбора можно выводить в ComboBox, и все это можно выводить на дополнительной форме.

///Предусмотреть возможность создания новых сотрудников и департаментов.
///Реализовать это либо на форме редактирования, либо сделать новую форму.
/// </summary>
namespace ListOfEmployees
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		Department dep;
		Employee emp;
		DataBase db;
		public MainWindow()
		{
			InitializeComponent();

			
			
		}
		//отдел
		private void Button_Click(object sender, RoutedEventArgs e)
		{
			dep = new Department(textBoxDepName.Text);
			db = new DataBase(dep);
		}
		//добавить сотрудника
		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			
			emp = new Employee(textBoxName.Text, textBoxSecondName.Text, textBoxAge.Text, textBoxSalary.Text);
			db = new DataBase(emp);
			lb.ItemsSource = db.dbEmployee;
			cmbEmployees.ItemsSource = db.dbEmployee;
		}
		
		

	}
}
