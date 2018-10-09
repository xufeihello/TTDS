using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TTDS.Model;
using TTDS.BLL;
using System.Collections;

namespace TTDS.UI.Controllers
{
    public class HomeController : BaseController
    {
        private TireAmountService tireAmountService = new TireAmountService();

        [Authorize]
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public JsonResult MapData()
        {
            ArrayList data = new ArrayList();
            List<vw_tire_amount> list = tireAmountService.GetModels(p => true).ToList();
            foreach (var item in list)
            {
                Dictionary<string, dynamic> mapItem = new Dictionary<string, dynamic>();
                mapItem.Add("name", item.PurchasePlace);
                mapItem.Add("value", item.amount);
                data.Add(mapItem);
            }
            JsonResult json = new JsonResult
            {
                Data = data  //创建json一个Data字段
            };
            return Json(json, JsonRequestBehavior.AllowGet);
        }
    }
}