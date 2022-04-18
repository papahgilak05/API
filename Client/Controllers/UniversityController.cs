using API.Models;
using API.Models.ViewModels;
using Client.Base;
using Client.Repositories.Data;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Linq;
using Client.ViewModel;
using Microsoft.AspNetCore.Http;

namespace Client.Controllers
{
    public class UniversityController : BaseController<University, UniversityRepository, int>
    {
        private readonly UniversityRepository repository;
        public UniversityController(UniversityRepository repository) : base(repository)
        {
            this.repository = repository;
        }
    }
}
