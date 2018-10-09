using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TTDS.BLL;
using TTDS.Model;

namespace TTDS.UI.Controllers
{
    public class LoggingController : BaseController
    {
        private TireService tireService = new TireService();
        //private TireAmountService tireAmountService = new TireAmountService();

        // GET: Logging
        [Authorize]
        public ActionResult Logging()
        {
            return View();
        }

        public ActionResult Info()
        {
            List<tire> list = tireService.GetModels(p => true).ToList();
            return View(list);
        }

        public ActionResult PCRSection()
        {
            List<tire> list = tireService.GetModels(p => true).ToList();
            return View(list);
        }

        public ActionResult Pattern()
        {
            List<tire> list = tireService.GetModels(p => true).ToList();
            return View(list);
        }

        public ActionResult ContactGround()
        {
            List<tire> list = tireService.GetModels(p => true).ToList();
            return View(list);
        }

        [HttpPost]
        public void InfoSubmit(tire t)
        {
            bool isAdd = tireService.Update(t);
            if(isAdd)
            {
                //return Content("<script >alert('提交成功！');history.go(-1);</script >", "text/html");
            }
            else
            {
                //return Content("<script >alert('提交失败！');history.go(-1);</script >", "text/html");
            }
        }

        private FootprintService footprintService = new FootprintService();

        [HttpPost]
        public JsonResult ImportFootprint()
        {
            HttpPostedFileBase file = Request.Files["file-footprint"];

            Stream inputStream = file.InputStream;
            t_contactground footprint = new t_contactground();
            t_condition condition = new t_condition();
            try
            {
                XSSFWorkbook xSSFWorkbook = new XSSFWorkbook(inputStream);
                ISheet sheet = xSSFWorkbook.GetSheetAt(0);

                condition.FacilityID = sheet.GetRow(10).GetCell(3).ToString();  //设备编号
                condition.TestStandard = sheet.GetRow(15).GetCell(3).ToString();  //试验标准
                condition.Pressure = Convert.ToDecimal(sheet.GetRow(15).GetCell(11).NumericCellValue);  //气压
                condition.Loaded = Convert.ToDecimal(sheet.GetRow(15).GetCell(19).NumericCellValue);  //载荷
                
                footprint.t_condition = condition;

                footprint.ID = sheet.GetRow(8).GetCell(19).ToString();  //试验编号
                footprint.ContactLength = Convert.ToDecimal(sheet.GetRow(23).GetCell(0).NumericCellValue);  //接触长度
                footprint.ContactWidth = Convert.ToDecimal(sheet.GetRow(23).GetCell(3).NumericCellValue);  //接触宽带
                footprint.ContactArea = Convert.ToDecimal(sheet.GetRow(23).GetCell(6).NumericCellValue);  //接触面积
                footprint.NetContactArea = Convert.ToDecimal(sheet.GetRow(23).GetCell(9).NumericCellValue);  //净接触面积
                footprint.LeftRectangularity = Convert.ToDecimal(sheet.GetRow(23).GetCell(15).NumericCellValue);  //左侧矩形率
                footprint.RightRectangularity = Convert.ToDecimal(sheet.GetRow(23).GetCell(18).NumericCellValue);  //右侧矩形率

                //footprintService.Add(footprint);
            }
            finally
            {
                inputStream.Close();
            }
            return Json(footprint, JsonRequestBehavior.AllowGet);  
        }

        [HttpPost]
        public void FootprintSubmit(t_contactground fp,t_condition cdt)
        {
            fp.t_condition = cdt;
            bool isAdd = footprintService.Add(fp);

        }

        [HttpPost]
        public JsonResult Download(string value)
        {
            List<tire> list = tireService.GetModels(p => (p.TireID == value)).ToList();
            if(list.Count == 0)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
            else
            {
                tire t = list[0];
                String dt = t.CreateTime.ToString();
                
                return Json(t, JsonRequestBehavior.AllowGet);
            }
            
        }
    }
}

