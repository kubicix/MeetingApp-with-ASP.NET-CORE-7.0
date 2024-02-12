using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers{

    //localhost/home
    public class HomeController : Controller{
        public IActionResult Index(){
            return View();
        }
    }
}