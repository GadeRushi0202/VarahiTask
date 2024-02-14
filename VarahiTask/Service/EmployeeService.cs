using VarahiTask.Model;
using VarahiTask.Repository;

namespace VarahiTask.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository repo;
        public EmployeeService(IEmployeeRepository repo)
        {
            this.repo = repo;
        }
        public int AddEmployee(Employee employee)
        {
            employee.IsActive = 1;
            return repo.AddEmployee(employee);
        }
    }
}
