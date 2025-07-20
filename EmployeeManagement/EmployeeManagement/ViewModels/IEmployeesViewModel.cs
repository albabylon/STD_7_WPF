using EmployeeManagement.Models;
using System.Collections.ObjectModel;

namespace EmployeeManagement.ViewModels
{
    public interface IEmployeesViewModel
    {
        public ObservableCollection<Employee> Employees { get; set; }

        public string Filter { get; set; }

        public string FilterStatus { get; set; }
    }
}
