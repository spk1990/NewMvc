using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.AspNetCore.Identity;

namespace NewsMvc.Controllers
{
    public class Reports : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        
    }
}