using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TTDS.Model;
using TTDS.BLL;

namespace TTDS.UI.Controllers
{
    public class ManagementController : BaseController
    {
        private UserService userService = new UserService();

        // GET: Management
        [Authorize]
        public ActionResult Users()
        {
            return View();
        }

        [Authorize]
        public JsonResult GetUsers(int limit, int offset, string department, string name)
        {
            List<user> list;
            if (department != "" && name != "")
            {
                list = userService.GetModels(p => (p.UDepartment.Contains(department) && p.UName.Contains(name))).ToList();
            }
            else if(department != "")
            {
                list = userService.GetModels(p => p.UDepartment.Contains(department)).ToList();
            }
            else if (name != "")
            {
                list = userService.GetModels(p => p.UName.Contains(name)).ToList();
            }
            else
            {
                list = userService.GetModels(p => true).ToList();
            }

            var total = list.Count;
            var rows = list.Skip(offset).Take(limit).ToList();
            return Json(new { total = total, rows = rows }, JsonRequestBehavior.AllowGet);
        }

        
        public ActionResult LoginUser()
        {
            //从数据库中重新获得登陆用户信息
            string uid = Session["UserID"].ToString();
            List<user> list = userService.GetModels(p => p.UID.Equals(uid)).ToList();
            user u = list[0];
            Session["User"] = u;
            Session["UserName"] = u.UName;
            Session["Group"] = u.UGroup;
            Session["Role"] = u.URole;
            TempData["User"] = u;
            return RedirectToAction("EditUser");
        }

        [HttpPost]
        public void TransferUser(user u)
        {
            TempData["User"] = u;
        }

        
        public ActionResult EditUser()
        {
            user u = TempData["User"] as user;
            return View(u);
        }

        [HttpPost]
        public void ModifiedUser(user u)
        {
            bool isUpdate = userService.Update(u);
            
        }

        [HttpPost]
        public bool DeleteUser(List<user> us)
        {
            bool isDelete = false;
            foreach (user u in us)
            {
                isDelete = userService.Delete(u);
            }
            return isDelete;
        }

        [HttpPost]
        public bool AddUser(user u)
        {
            bool isAdd = userService.Add(u);
            return isAdd;
        }
    }
}