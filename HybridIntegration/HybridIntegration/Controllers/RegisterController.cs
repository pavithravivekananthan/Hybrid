using HybridIntegration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HybridIntegration.Controllers
{
    public class RegisterController : Controller
    {
        //
        // GET: /Register/
        private AppdbContext db = new AppdbContext();
        private AppdbContext1 db1 = new AppdbContext1();

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Register Registration)
        {
            db.Registration.Add(Registration);
            db.SaveChanges();
            db1.Registration.Add(Registration);
            db1.SaveChanges();
            return View();
        }

    }
}
