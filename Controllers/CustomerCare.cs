using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace FisherInsurance.Controllers
{
    [Route("customer")]
    public class CustomerCare : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return Ok("This is the index of the CustomerCareController");
        }
        [Route ("claim")]
        [Route ("fileclaim")]
        public IActionResult NewClaim()
        {
            return Ok("Claims from Care");
        }
        [Route ("claimstatus")]
        public IActionResult ClaimHistory()
        {
            return Ok("claim status/history");
        }
    }

}
