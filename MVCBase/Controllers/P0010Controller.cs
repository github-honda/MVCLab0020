using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBase.Controllers
{
    public class P0010Controller : Controller
    {
        // GET: P0010
        //public ActionResult Index()
        //{
        //    return View();
        //}
        public string GetString1()
        {
            return "Controller.ActionMethod=P0010.GetString1().";
        }
        public string GetString2()
        {
            return "Controller.ActionMethod=P0010.GetString2().";
        }
      
        public DateTime GetNow()
        {
            // 若非回傳string, 則會自動以ToString()回傳. 
            return DateTime.Now;
        }

        [NonAction]
        public string GetString3()
        {
            // 若設定屬性=[NonAction]的方法，則不會成爲Controller.Action.
            return "若設定屬性=[NonAction]的方法，則不會成爲Controller.Action.";
        }

        string GetString4()
        {
            return "若非public的方法, 就不是Controller.Action";
        }
    }
}