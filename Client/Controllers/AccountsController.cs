using API.Models;
using API.Models.ViewModels;
using Client.Base;
using Client.Repositories.Data;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Linq;
using Client.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;

namespace Client.Controllers
{
    public class AccountsController : BaseController<Account, AccountRepository, string>
    {
        private readonly AccountRepository repository;
        public AccountsController(AccountRepository repository) : base(repository)
        {
            this.repository = repository;
        }

        /*[HttpGet]
        public async Task<JsonResult> GetByProvinceId(int id)
        {
            var result = await repository.GetByProvinceId(id);
            return Json(result);
        }*/

        [HttpPost]
        public JsonResult Login(LoginVM loginVM)
        {
            var result = repository.Login(loginVM);
            if(result.JWT != null)
            {
                HttpContext.Session.SetString("JWToken", result.JWT);
            }
            return Json(result);
        }
        
        [HttpGet]
        public async Task<JsonResult> MasterData()
        {
            var result = await repository.GetMasterData();
            return Json(result);
        }

        [HttpPost]
        public JsonResult Register(RegisterVM registerVM)
        {
            var result = repository.Register(registerVM);
            return Json(result);
        }

        /*[HttpPut]
        public ActionResult UpdateData(MasterDataVM masterdataVM)
        {
            var result = repository.Update(masterdataVM);
            return Json(result);
        }*/
        public IActionResult Index()
        {
            return View();
        }

        /*public IActionResult Login()
        {
            return View();
        }*/
    }
}
