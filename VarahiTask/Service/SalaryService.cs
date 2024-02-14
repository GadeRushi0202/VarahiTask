using VarahiTask.Repository;

namespace VarahiTask.Service
{
    public class SalaryService
    {
        private readonly ISalaryRepository SalaryRepo;

        public SalaryService(ISalaryRepository SalaryRepo)
        {
            SalaryRepo = SalaryRepo;
        }
        public decimal CalculateSalary(int workingDay)
        {
            decimal dailyWage = 100;
            decimal salary = dailyWage * workingDay;

            SalaryRepo.SaveSalary(salary);

            return salary;
        }
    }
}
