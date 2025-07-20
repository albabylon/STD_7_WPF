namespace EmployeeManagement.Models
{
    public interface IEmployeeRepository
    {
        public IEnumerable<Employee> GetAll();

        public Employee? GetById(Guid id);

        public void Add(Employee employee);

        public void Delete(Guid id);
    }
}
