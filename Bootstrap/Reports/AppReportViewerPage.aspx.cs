using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bootstrap.Reports
{
    public partial class AppReportViewerPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                RenderReport();
            }
            
        }

        private void RenderReport()
        {

            appReportViewer.Reset();
            appReportViewer.LocalReport.EnableExternalImages = true;
            appReportViewer.LocalReport.ReportPath = Server.MapPath("~/Reports/rptGeneraRemesas.rdlc");


            //With parameter
            appReportViewer.LocalReport.SetParameters(new Microsoft.Reporting.WebForms.ReportParameter("20180701", "20180722"));


            DataTable dtReportdata = new DataTable();
           

            appReportViewer.LocalReport.DataSources.Add(new Microsoft.Reporting.WebForms.ReportDataSource("DataSet1",new object()));
             

        }
    }
}