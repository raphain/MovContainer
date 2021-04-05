using Microsoft.AspNetCore.Mvc;
using Stimulsoft.Report;
using Stimulsoft.Report.Mvc;

namespace MovContainer.Controllers
{
    public class ViewerController : Controller
    {
        public ActionResult GetReport()
        {
            StiReport report = new StiReport();
            report.Load(StiNetCoreHelper.MapPath(this, "Report/Report.mrt"));
            return StiNetCoreViewer.GetReportResult(this, report);
        }

        public ActionResult ViewerEvent()
        {
            return StiNetCoreViewer.ViewerEventResult(this);
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
