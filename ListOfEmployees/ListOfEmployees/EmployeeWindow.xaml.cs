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
		}
		// редактирование зарплаты
		private void Btn1_Click(object sender, RoutedEventArgs e)
		{
			if (txChangeSalary.Text != "" && txChangeID.Text != "" && txChangeSalary.Text.All(char.IsDigit) != false && txChangeID.Text.All(char.IsDigit) != false)
			{
				DataBase.SetSal(Int32.Parse(txChangeSalary.Text), Int32.Parse(txChangeID.Text));
				((MainWindow)Application.Current.MainWindow).lb.Items.Refresh();
			}
			else { MessageBox.Show("Заполнены не все поля или неверный формат ввода."); }
		}
		// редактирование отдела
		private void Button_Click(object sender, RoutedEventArgs e)
		{
			if (txChangeDepartment.Text != "" && txChangeID.Text != "" && txChangeID.Text.All(char.IsDigit) != false)
			{
				DataBase.SetDep(txChangeDepartment.Text, Int32.Parse(txChangeID.Text));
				((MainWindow)Application.Current.MainWindow).lb.Items.Refresh();
			}
			else { MessageBox.Show("Заполнены не все поля или неверный формат ввода."); }
		}
	}
}
