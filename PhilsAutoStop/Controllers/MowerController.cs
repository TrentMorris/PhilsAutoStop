using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhilsAutoStop.Controllers
{
    public class MowerController : Controller
    {
        // GET: Mower
        public ActionResult All()
        {
            return View();
        }

        public ActionResult Raptor()
        {
            return View();
        }

        public ActionResult RaptorFlipUp()
        {
            return View();
        }
    }
}