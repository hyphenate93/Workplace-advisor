using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WPA.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using WPA.Models;

namespace WPA.Models
{
    public class CompanyEditorModel 
    {
        public List<CompanyModel> CompanyList { get; set; }
        public CompanyEditorModel(List<CompanyModel> companyList)
        {
            CompanyList = companyList;
        }
        public void onGet()
        {
            
        }
    }
}
