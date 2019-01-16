using Ekopay_Reports.Reports;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using ReportViewerForMvc;
using Microsoft.Reporting.WebForms;

namespace Ekopay_Reports.Controllers
{
    public class ReportController : Controller
    {
   

        Report_Customer ds = new Report_Customer();
        public ActionResult Index()
        {
            ReportViewer reportViewer = new ReportViewer();
            reportViewer.ProcessingMode = ProcessingMode.Local;
            reportViewer.SizeToReportContent = true;
            reportViewer.Width = Unit.Percentage(900);
            reportViewer.Height = Unit.Percentage(900);

            var connectionString = ConfigurationManager.ConnectionStrings["EkoInventoryDBConnectionString"].ConnectionString;


            SqlConnection conx = new SqlConnection(connectionString); SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM dbo.BalanceInquiryView", conx);

            adp.Fill(ds, ds.BalanceInquiryView.TableName);

            reportViewer.LocalReport.ReportPath = Request.MapPath(Request.ApplicationPath) + @"Reports\Report_Customer.rdlc";
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", ds.Tables[0]));

            ViewBag.ReportViewer = reportViewer;

            return View();
        }
        
    }

 
}