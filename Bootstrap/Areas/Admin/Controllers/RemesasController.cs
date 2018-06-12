using Bootstrap.Areas.Admin.Filters;
using DAL;
using Helper;
using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bootstrap.Areas.Admin.Controllers
{
    //[Autenticado]
    public class RemesasController : Controller
    {
        private tbl_remesasDTO _remesas = new tbl_remesasDTO();
           

        // GET: Admin/Remesas
        public ActionResult Index()
        {
            return View();
        }


        public JsonResult Guardar(HttpPostedFileBase fileXml)
        {
            var rm = new responseResult();
            try
            {
                if (fileXml != null)
                {
                    rm = _remesas.GuardarFile(fileXml);

                    if (rm.response)
                    {


                    }
                }
                else
                {
                    rm.SetResponse(false, "Ha ocurrido en el envio del archivo");

                }
            }
            catch (Exception)
            {
                throw;
            }
            return Json(rm);




        }

      
    }
}