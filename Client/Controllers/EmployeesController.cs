using API.Models;
using Client.Base;
using Client.Repositories.Data;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Client.Controllers
{
    public class EmployeesController : BaseController<University, EmployeeRepository, string>
    {
        private readonly EmployeeRepository repository;
        public EmployeesController(EmployeeRepository repository) : base(repository)
        {
            this.repository = repository;
        }

        /*[HttpGet]
        public async Task<JsonResult> GetByProvinceId(int id)
        {
            var result = await repository.GetByProvinceId(id);
            return Json(result);
        }*/
        [HttpGet]
        public async Task<IActionResult> MasterData()
        {
            var result = await repository.GetMasterData();
            return Json(result);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
