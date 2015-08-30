using System.Collections.Generic;
using System.Web.Mvc;
using SocialNetwork1._1.Models;

namespace SocialNetwork1._1.Controllers
{
    public class HomeController : Controller
    {
        UserContext db = new UserContext();

        public ActionResult Index()
        {
            IEnumerable<User> users = db.Users;
            ViewBag.Users = users;
            return View();
        }

        [HttpPost]
        public ActionResult Register(User newUser)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(newUser);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(newUser);
        }

        public ActionResult Register()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
    }
}
