using EmployeeManagement.Models;
using EmployeeManagement.ViewModels;
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

namespace EmployeeManagement.View
{
    /// <summary>
    /// Логика взаимодействия для EmployessView.xaml
    /// </summary>
    public partial class EmployeesView : Window
    {
        IEmployeesViewModel _employeesViewModel;
        IEmployeeViewModel _employeeViewModel;

        public EmployeesView(IEmployeesViewModel employeesViewModel, IEmployeeViewModel employeeViewModel)
        {
            InitializeComponent();
            DataContext = employeesViewModel;

            _employeesViewModel = employeesViewModel;
            _employeeViewModel = employeeViewModel;
        }

        private void ListView_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var item = (sender as ListView).SelectedItem;

            if (item is null)
                return;

            var employee = item as Employee;

            _employeeViewModel.Employee = employee;

            var employeeView = new EmployeeView(_employeeViewModel);
            employeeView.Owner = this;
            employeeView.Show();
        }
    }
}
