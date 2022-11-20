using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WPA.Data;
using WPA.Models;
using static WPA.Models.RatingPageModel;

namespace WPA.Controllers
{
    public class RatingPageController : Controller
    {
        private readonly WpaContext _dbContext;
        public RatingPageController(WpaContext context)
        {
            this._dbContext = context;
        }

        // GET
        [Route("RatingPage")]
        public IActionResult Index()
        {


            var companies = _dbContext.Company.ToList();

            var model = new RatingPageModel(companies);
            List<CompanyModel> companyList = new List<CompanyModel>();
        ViewBag.companyList = companies;
            model.CompanyList = companies;

            return View(model);
        }
    }
}