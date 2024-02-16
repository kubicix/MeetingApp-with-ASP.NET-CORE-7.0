using MeetingApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MeetingAp.Controllers
{
    public class MeetingController : Controller
    {
        
        [HttpGet]
        public IActionResult Apply(){
            return View();
        }

		[HttpPost]
		public IActionResult Apply(UserInfo model)
		{
            // optional database insert

            // list
            Repository.CreateUser(model);
            ViewBag.UserCount=Repository.Users.Where(user=>user.WillAttend==true).Count();
			return View("Thanks",model);
		}

		public IActionResult List(){
            return View(Repository.Users);
        }

        //meeting/details/2
		public IActionResult Details(int id)
		{
			return View(Repository.GetById(id));
		}
	}
}
