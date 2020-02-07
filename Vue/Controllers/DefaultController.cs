using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vue.Models;
using System.Net.Http;

namespace Vue.Controllers
{
    public class DefaultController : Controller
    {
        dechengEntities db = new dechengEntities();

        // GET: Default
        public ActionResult Index(int? pageIndex)
        {
            if(Request.IsAjaxRequest())
            {
                int page = pageIndex ?? 1;
                int PageSize = 12;
                int skip = ((int)page - 1) * PageSize;

                return Json(db.dc_Log.OrderBy(m => m.AddTime).Skip(skip).Take(PageSize).ToList(), JsonRequestBehavior.AllowGet);
            }
            return View();
        }

        public ActionResult Api()
        {
            return View();
        }
    }
}