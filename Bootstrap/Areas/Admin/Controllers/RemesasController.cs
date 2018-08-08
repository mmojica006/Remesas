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
        private WU_TablaDato wu_tabladato = new WU_TablaDato();
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
            var CantCaracter = wu_tabladato.Obtener("caracteres",1);
            int CantMTCN = Convert.ToInt32(CantCaracter.Valor);
            string usuarioDominio = Helper.SessionHelper.GetUser().ToString();
            try
            {
                if (fileXml != null)
                {
                    rm = _remesas.GuardarFile(usuarioDominio, fileXml, CantMTCN);

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