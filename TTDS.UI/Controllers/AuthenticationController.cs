using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TTDS.Model;
using TTDS.BLL;
using System.Web.Security;

namespace TTDS.UI.Controllers
{
    public class AuthenticationController : Controller
    {
        // GET: Authentication
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DoLogin(user u)
        {
            UserService userService = new UserService();
            List<user> users = userService.GetModels(p => true).ToList();
            bool isValidUser = false;
            foreach (var item in users)
            {
                if(u.UID == item.UID && u.UPassword == item.UPassword)
                {
                    isValidUser = true;
                    u = item;
                }
            }
            if (isValidUser)
            {
                FormsAuthentication.SetAuthCookie(u.UID, false);
                Session["User"] = u;
                Session["UserID"] = u.UID;
                Session["UserName"] = u.UName;
                Session["Group"] = u.UGroup;
                Session["Role"] = u.URole;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("CredentialError", "用户名或密码不正确！");
                return View("Login");
            }
        }
        public ActionResult Logout()
        {
            HttpContext.Request.Cookies.Remove(FormsAuthentication.FormsCookieName);
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}