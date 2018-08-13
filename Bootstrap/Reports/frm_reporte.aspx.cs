using Microsoft.Reporting.WebForms;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bootstrap.Reports
{
    public partial class frm_reporte : System.Web.UI.Page
    {
        tbl_remesasDTO _tbl_remesasDto = new tbl_remesasDTO();

        protected void Page_Load(object sender, EventArgs e)
        {
            var id = int.Parse(Request.QueryString["id"]);
            var tipo = byte.Parse(Request.QueryString["tipo"]);
            var fInicio = Request.QueryString["f1"];
            var fFin = Request.QueryString["f2"];

            if (!IsPostBack)
            {
                ImprimirOrden(id, tipo, fInicio, fFin);
            }


        }

        private void ImprimirOrden(int id, byte tipo,string fechaInicio, string fechaFin)
        {
            //string fechaInicio = "01/06/2018";
            //string fechaFin = "30/06/2018";

               


            ReportViewer1.LocalReport.DataSources.Clear();
            ReportViewer1.LocalReport.DataSources.Add(
                new ReportDataSource("DS_COMPLETA", _tbl_remesasDto.listadoRemesas( DateTime.Parse(fechaInicio), DateTime.Parse(fechaFin))));
            switch (tipo)
            {
                case 1:
                    ReportViewer1.LocalReport.ReportPath = "Reports/rpt_voucher_carta.rdlc";
                    break;
                case 2:
                    ReportViewer1.LocalReport.ReportPath = "Reports/rpt_orden_media_carta.rdlc";
                    break;
                case 3:
                    ReportViewer1.LocalReport.ReportPath = "Reports/rpt_orden_pos.rdlc";
                    break;
                default:
                    ReportViewer1.LocalReport.ReportPath = "Reports/rpt_orden_carta.rdlc";
                    break;
            }

            ReportViewer1.Visible = true;

            ReportViewer1.LocalReport.Refresh();






        }
    }
}