using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace reflection.Controllers
{
    [Describe(Describe = "这是home控制器", Name = "HomeController")]
    public class HomeController : Controller
    {
        [Describe(Describe = "这是About页面", Name = "Index")]
        public ActionResult Index()
        {
            return View();
        }
        [Describe(Describe="这是About页面",Name = "About")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [Describe(Describe = "这是Contact页面", Name = "Contact")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [Describe(Describe = "这是Reflection页面", Name = "Reflection")]
        public ActionResult Reflection() {
            IEnumerable<Type> ts = Assembly.GetExecutingAssembly().GetTypes().Where(p => p.BaseType == typeof(Controller));

            return View(ts);
        }
    }
}