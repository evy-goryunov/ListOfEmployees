﻿using System;
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

		public MainWindow()
		{
			InitializeComponent();
		}
		//добавить отдел TODO переопредели ToString у Department добавить отображение в ListBox и ComboBox
		private void Button_Click(object sender, RoutedEventArgs e)
		{
			dep = new Department(textBoxDepName.Text);
			DataBase.dbDepartment.Add(dep);
			cmbDepartments.ItemsSource = DataBase.dbDepartment;
		}
		//добавить сотрудника TODO добавить отображение в ListBox через ToString
		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			//проверяем нет ли пустых полей
			if (textBoxName.Text != "" && textBoxSecondName.Text != "" && textBoxAge.Text != "" && textBoxSalary.Text != "")
			{
				emp = new Employee(textBoxName.Text.ToString(), textBoxSecondName.Text, textBoxAge.Text, textBoxSalary.Text);
				DataBase.dbEmployee.Add(emp);
				lb.ItemsSource = DataBase.dbEmployee;
				cmbEmployees.ItemsSource = DataBase.dbEmployee;
				this.Title = DataBase.dbEmployee.Count.ToString();
			}
			else { MessageBox.Show("Заполните все поля."); }
			
		}
		//кнопка Выход в контекстном меню
		private void AppExit_Click(object sender, RoutedEventArgs e)
		{
			Application.Current.Shutdown();
		}
		//открываем окно редактирования
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
	}
}
