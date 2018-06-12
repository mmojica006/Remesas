using Bootstrap.Areas.Admin.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bootstrap.Areas.Admin.Controllers
{
    //[Autenticado]
    public class RemesasController : Controller
    {
        // GET: Admin/Remesas
        public ActionResult Index()
        {
            return View();
        }
    }
}