using Bootstrap.Areas.Admin.Filters;
using Helper;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bootstrap.Areas.Admin.Controllers
{
    
    public class LoginController : Controller
    {

        private Usuario usuario = new Usuario();
        // GET: Admin/Login
        [NoLogin]
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Acceder(string email, string password)
        {

            var rm = usuario.Acceder(email, password);

            if (rm.response)
            {
                //RedirectToAction("~/admin/home");
                rm.href = Url.Content("~/admin/remesas");
            }
                return Json(rm);
        }

        public ActionResult Logout()
        {
            SessionHelper.DestroyUserSession();
           return Redirect("~/admin/login");
        }
    }
}