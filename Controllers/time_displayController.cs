using System; 
using Microsoft.AspNetCore.Mvc;
namespace FirstWeb.Controllers
{
    public class time_displayController :Controller
    {   
        //gluing a url pattern to functionality
        [HttpGet("")]
        public IActionResult Index()
        {
            DateTime CurrentTime = DateTime.Now;
            ViewBag.Date = CurrentTime.ToString("MMMM dd, yyyy");
            ViewBag.Time = CurrentTime.ToString("hh:mm tt");
            return View();
        }

    }
} 