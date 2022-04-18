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
using Microsoft.Extensions.Logging;

namespace Client.Controllers
{
    public class HandlerController : Controller
    {
        private readonly ILogger<HandlerController> _logger;

        public HandlerController(ILogger<HandlerController> logger)
        {
            _logger = logger;
        }
        public  IActionResult Forbidden()
        {
            return View();
        }
        public new IActionResult Unauthorized()
        {
            return View();
        }
        public  IActionResult Notfound()
        {
            return View();
        }
    }
}
