using Microsoft.AspNetCore.Mvc;
using WPA.Data;
using WPA.Models;
using static WPA.Models.CompanyModel;

namespace WPA.Controllers
{
    public class CompanyController : Controller
    {

        private readonly WpaContext _dbContext;
        public CompanyController(WpaContext context)
        {
            this._dbContext = context;
        }
        [Route("Company")]

        public IActionResult Index()
        {
            var companies = _dbContext.Company.ToList();

            List<CompanyModel> companyList = new List<CompanyModel>();
            ViewBag.companyList = companies;
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
        
    }
}
