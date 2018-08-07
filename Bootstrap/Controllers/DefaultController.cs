using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bootstrap.Controllers
{
    public class DefaultController : Controller
    {
        private WU_Auditoria wu_auditoria  = new WU_Auditoria();
        // GET: Default
        public ActionResult Index()
        {
            return Redirect("Admin/Remesas");
        }
    }
}