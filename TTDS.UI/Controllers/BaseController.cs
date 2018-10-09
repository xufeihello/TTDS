using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TTDS.UI.Controllers
{
    public class BaseController : Controller
    {
        // GET: Base
        //public ActionResult Index()
        //{
        //    return View();
        //}

        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            if(filterContext.HttpContext.Session["User"] == null)
            {
                filterContext.HttpContext.Response.Redirect("/Authentication/Login");
            }
            base.OnActionExecuted(filterContext);
        }
    }
}