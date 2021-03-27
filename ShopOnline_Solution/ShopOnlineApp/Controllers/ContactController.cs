using Microsoft.AspNetCore.Mvc;

namespace ShopOnlineApp.Controllers
{
    public class ContactController : Controller
    {
        [Route("contact.html")]
        public IActionResult Index()
        {
            return View();
        }
    }
}