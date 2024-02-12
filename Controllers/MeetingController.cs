using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MeetingAp.Controllers
{
    public class MeetingController : Controller
    {
        // GET: MeetingController
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Apply(){
            return View();
        }

        public IActionResult List(){
            return View();
        }
    }
}
