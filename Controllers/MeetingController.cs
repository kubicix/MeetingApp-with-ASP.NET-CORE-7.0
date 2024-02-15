using MeetingApp.Models;
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


        [HttpGet]
        public IActionResult Apply(){
            return View();
        }

		[HttpPost]
		public IActionResult Apply(UserInfo model)
		{
            
			return View();
		}

		public IActionResult List(){
            return View();
        }
    }
}
