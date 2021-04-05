using Microsoft.AspNetCore.Mvc;
using Stimulsoft.Report;
using Stimulsoft.Report.Mvc;

namespace MovContainer.Controllers
{
    public class EditorController : Controller
    {
        public IActionResult GetReport()
        {
            StiReport report = new StiReport();
            return StiNetCoreDesigner.GetReportResult(this, report);
        }

        public IActionResult PreviewReport()
        {
            StiReport report = StiNetCoreDesigner.GetActionReportObject(this);
            return StiNetCoreDesigner.PreviewReportResult(this, report);
        }

        public IActionResult DesignerEvent()
        {
            return StiNetCoreDesigner.DesignerEventResult(this);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
