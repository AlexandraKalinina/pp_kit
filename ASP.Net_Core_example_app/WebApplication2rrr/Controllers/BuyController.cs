using Microsoft.AspNetCore.Mvc;
using WebApplication2rrr.Models;

namespace WebApplication2rrr.Controllers
{
    public class BuyController : Controller
    {
        MobileContext db;
        public BuyController(MobileContext context)
        {
            db = context;
        }
        [HttpGet]
        public IActionResult Buy(int? id)
        {
         
            Phone phone = db.Phones.Find(id);
            return View("~/Views/Buy.cshtml", phone);
        }
    }
}
