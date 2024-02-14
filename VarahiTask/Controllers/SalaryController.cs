using Microsoft.AspNetCore.Mvc;
using VarahiTask.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VarahiTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalaryController : ControllerBase
    {
        private readonly ISalaryService salaryService;

        public SalaryController(ISalaryService salaryService)
        {
            salaryService = salaryService;
        }


        [HttpPost]
        public ActionResult<decimal> CalculateSalary(int workingDay)
        {
            decimal salary = salaryService.CalculateSalary(workingDay);

            return Ok(salary);
        }
    }
}
