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
		EmployeeWindow winEmployee;
		AboutWindow abWin;

		public MainWindow()
		{
			InitializeComponent();
		}
		//добавить отдел
		private void Button_Click(object sender, RoutedEventArgs e)
		{
			//проверяем нет ли пустых полей
			if (textBoxDepName.Text != "")
			{
				dep = new Department(textBoxDepName.Text);
				DataBase.dbDepartment.Add(dep);
				cmbDepartments.ItemsSource = DataBase.dbDepartment;
			}
			else { MessageBox.Show("Введите название отдела."); }
		}
		//добавить сотрудника
		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			//проверяем нет ли пустых полей или букв в возрасте и зарплате
			if (textBoxName.Text != "" && textBoxSecondName.Text != "" && textBoxAge.Text != "" && textBoxSalary.Text != ""
				&& textBoxAge.Text.All(char.IsDigit) != false && textBoxSalary.Text.All(char.IsDigit) != false)
			{
				emp = new Employee(textBoxName.Text.ToString(), textBoxSecondName.Text, Int32.Parse(textBoxAge.Text), Int32.Parse(textBoxSalary.Text), textBoxDepName.Text);
				DataBase.dbEmployee.Add(emp);
				lb.ItemsSource = DataBase.dbEmployee;
				cmbEmployees.ItemsSource = DataBase.dbEmployee;
				cmbDepartments.ItemsSource = DataBase.dbDepartment;
				//this.Title = DataBase.dbEmployee.Count.ToString();
				DataBase.SetId(DataBase.dbEmployee.IndexOf(emp));
			}
			else { MessageBox.Show("Заполнены не все поля или неверный формат ввода."); }
			
		}
		//кнопка Выход в контекстном меню
		private void AppExit_Click(object sender, RoutedEventArgs e)
		{
			Application.Current.Shutdown();
		}
		//кнопка О программе в контекстном меню
		private void About_Click(object sender, RoutedEventArgs e)
		{
			if (abWin != null)
			{
				try
				{
					abWin.Show();
				}
				catch
				{
					abWin = new AboutWindow();
					abWin.Show();
				}
			}
			else
			{
				abWin = new AboutWindow();
				abWin.Show();
			}
		}
		//вызов окна редактирования
		private void Lb_GotMouseCapture(object sender, MouseEventArgs e)
		{
			if (winEmployee != null)
			{
				try
				{
					winEmployee.Show();
				}
				catch
				{
					winEmployee = new EmployeeWindow();
					winEmployee.Show();
				}
			}
			else
			{
				winEmployee = new EmployeeWindow();
				winEmployee.Show();
			}
		}
		//вызов окна редактирования
		private void RefreshBtn_Click(object sender, RoutedEventArgs e)
		{
			if (winEmployee != null)
			{
				try
				{
					winEmployee.Show();
				}
				catch
				{
					winEmployee = new EmployeeWindow();
					winEmployee.Show();
				}
			}
			else
			{
				winEmployee = new EmployeeWindow();
				winEmployee.Show();
			}
		}
	}
}
