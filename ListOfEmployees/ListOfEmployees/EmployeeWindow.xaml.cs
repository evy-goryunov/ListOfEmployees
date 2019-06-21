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
using System.Windows.Shapes;

namespace ListOfEmployees
{
	/// <summary>
	/// Логика взаимодействия для EmployeeWindow.xaml
	/// </summary>
	public partial class EmployeeWindow : Window
	{
		public EmployeeWindow()
		{
			InitializeComponent();
			this.Title = "Окно редактирования сотрудника";
			tx1.Text = DataBase.dbEmployee.ToString();
			
		}

		private void Btn1_Click(object sender, RoutedEventArgs e)
		{
			DataBase.SetAge(tx2.Text, 0);
		}
	}
}
