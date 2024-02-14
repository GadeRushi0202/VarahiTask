using Microsoft.EntityFrameworkCore;
using VarahiTask.Data;
using VarahiTask.Model;

namespace VarahiTask.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext db;
        public EmployeeRepository(ApplicationDbContext db)
        {
           this.db = db;
        }
        public int AddEmployee(Employee employee)
        {
            int result = 0;
            db.Employees.Add(employee);
            result = db.SaveChanges();
            return result;
        }
    }
}
