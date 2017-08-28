using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace reflection.Controllers
{
    [Describe(Describe = "这是testController", Name = "testController")]

    public class testController : Controller
    {
        [Describe(Describe = "这是Index", Name = "Index")]

        // GET: test
        public ActionResult Index()
        {
            return View();
        }
    }
}