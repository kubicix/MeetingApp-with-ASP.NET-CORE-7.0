using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers{

    //localhost/home
    public class HomeController : Controller{
        public IActionResult Index(){
            //model olarak göndermek
            //pratik değil view içine de geçmirmeli parametre olarak
            int hour=DateTime.Now.Hour;
            // var greeting=hour > 12 ? "Have a nice day!":"Good Morning!";

            //ViewBag normal şekilde gönderir
            ViewBag.Greeting = hour > 12 ? "Have a nice day!":"Good Morning!";
            //ViewBag.Username="Kubi";

            //ViewData ise Json yani key value şeklinde
            //O yüzden bi tık daha güvenli
            ViewData["Greeting"]=hour > 12 ? "Have a nice day!":"Good Morning!";
            int UserCount=ViewBag.UserCount=Repository.Users.Where(user=>user.WillAttend==true).Count();
            //ViewData["Username"]="Kubi";

            var meetingInfo = new MeetingInfo()
            {
                Id = 1,
                Location = "Istanbul Fetih Congress Center",
                Date = new DateTime(2024,03,20,20,0,0),
                NumberOfPeople=UserCount,
            };

            return View(meetingInfo);
        }
    }
}