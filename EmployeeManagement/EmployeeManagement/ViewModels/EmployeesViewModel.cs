using EmployeeManagement.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace EmployeeManagement.ViewModels
{
    public class EmployeesViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        
        private readonly EmployeeRepository _employeeRepository;

        public EmployeesViewModel()
        {
            _employeeRepository = new EmployeeRepository();
            FillListView();
            SetFilterStatus();
        }



        private ObservableCollection<Employee> _employees;
        public ObservableCollection<Employee> Employees
        {
            get => new(_employeeRepository.GetAll());
            set
            {
                _employees = value;
                OnPropertyChanged();
            }
        }

        private string _filter;
        public string Filter
        {
            get => _filter;
            set 
            {
                _filter = value;
                FillListView();
                SetFilterStatus();
            }
        }

        private string _filterStatus;
        public string FilterStatus
        {
            get => _filterStatus;
            set
            {
                _filterStatus = value;
                OnPropertyChanged();
            }
        }



        private void FillListView()
        {
            if (!string.IsNullOrEmpty(_filter))
            {
                Employees = new ObservableCollection<Employee>(
                  _employeeRepository.GetAll().Where(v => v.FirstName.Contains(_filter)));
            }
            else
                Employees = new ObservableCollection<Employee>(
                  _employeeRepository.GetAll());
        }

        private void SetFilterStatus()
        {
            if (string.IsNullOrEmpty(_filter))
            {
                FilterStatus = "Введите данные для поиска";
            }
            else
                FilterStatus = $"По вашему запросу найдено: {Employees.Count}";
        }
    }
}
