using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace FisherInsurance.Controllers
{
    public class AutoController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return Ok("auto index");
        }
        public IActionResult Quote()
        {
            return Ok("auto quote");
        }
    }
}
