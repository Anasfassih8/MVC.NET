using Microsoft.AspNetCore.Mvc;

namespace MVC.NET.Controllers
{
    public class MovieController:Controller
    {
       

        public IActionResult Index() {
            //ContentResult result = new ContentResult();
            //result.Content = "Welcome ybasha";
            //result.ContentType = "text/html";//Default
            //return result;
            return Content("Welcome ybasha", "text/html");
        
        }

        public IActionResult redirect()
        {
            //RedirectResult result = new RedirectResult("https://localhost:44325/Movie/Index");
            //return result;
            //return Redirect("https://localhost:44325/Movie/Index");
            return RedirectToAction("Index");
        }
    }
}
