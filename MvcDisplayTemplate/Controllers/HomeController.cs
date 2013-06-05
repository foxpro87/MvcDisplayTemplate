using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcDisplayTemplate.Models;

namespace MvcDisplayTemplate.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            User user = new User()
            {
                Id=101,
                Name = "주의사신",
                Reputation = 1234
            };
            return View(user);
        }

        public ActionResult About()
        {
            User user = new User()
            {
                Id=905,
                Name = "파워 개발자",
                Reputation = 54432
            };
            return View(user);
        }

    }
}
