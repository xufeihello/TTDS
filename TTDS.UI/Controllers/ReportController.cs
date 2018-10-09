using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TTDS.UI.Controllers
{
    public class ReportController : BaseController
    {
        // GET: Report
        [Authorize]
        public ActionResult Report()
        {
            return View();
        }

        public ActionResult CrownGrowth()
        {
            return View();
        }

        public ActionResult Pressure()
        {
            return View();
        }

        public ActionResult Performance()
        {
            return View();
        }
    }
}