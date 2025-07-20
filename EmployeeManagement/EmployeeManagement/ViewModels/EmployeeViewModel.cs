using EmployeeManagement.Models;

namespace EmployeeManagement.ViewModels
{
    public class EmployeeViewModel : IEmployeeViewModel
    {
        private Employee? _employee;
        public Employee Employee
        {
            get
            {
                return _employee;
            }
            set
            {
                _employee = value;
            }
        }
    }
}
