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
    [Autenticado]
    public class RemesasController : Controller
    {
        private tbl_remesasDTO _remesas = new tbl_remesasDTO();
        private WU_Apos wu_apos = new WU_Apos();
           

        // GET: Admin/Remesas
        public ActionResult Index()
        {
            ViewBag.usuario = Helper.SessionHelper.GetUser().ToString();
            return View();
        }

        public JsonResult Listar (AnexGRID grid, string usuario)
        {
            return Json(wu_apos.Listar(grid, usuario));

        }


        public JsonResult Guardar(HttpPostedFileBase fileXml)
        {
            var rm = new responseResult();
            string usuarioDominio = Helper.SessionHelper.GetUser().ToString();
            try
            {
                if (fileXml != null)
                {
                    rm = _remesas.GuardarFile(usuarioDominio, fileXml);

                    if (rm.response)
                    {


                    }
                }
                else
                {
                    rm.SetResponse(false, "Ha ocurrido en el envio del archivo");

                }
            }
            catch (Exception ex)
            {
        
                rm.SetResponse(false, ex.Message );
            }
            return Json(rm);




        }

      
    }
}