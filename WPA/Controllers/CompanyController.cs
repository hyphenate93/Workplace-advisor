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
        [HttpPost]
        public IActionResult Add(CompanyModel model)
        {
            // new random guid for company id
            model.CompanyId = Guid.NewGuid();
            _dbContext.Add(model);
            _dbContext.SaveChanges();
            return View();
        }
        [HttpPost]
        public IActionResult Edit(CompanyModel model)
        {
            _dbContext.Update(model);
            _dbContext.SaveChanges();
            return View();
        }
        [HttpPost]
        public IActionResult Delete(CompanyModel model)
        {
            _dbContext.Remove(model);
            _dbContext.SaveChanges();

            return View();
        }
        
    }
}
