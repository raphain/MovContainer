#pragma checksum "C:\workspace\ContainerMov\MovContainer\MovContainer\Views\Viewer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9a64b00246d8addb29ffebf9d7d4008360f2ff4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Viewer_Index), @"mvc.1.0.view", @"/Views/Viewer/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\workspace\ContainerMov\MovContainer\MovContainer\Views\_ViewImports.cshtml"
using MovContainer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\workspace\ContainerMov\MovContainer\MovContainer\Views\_ViewImports.cshtml"
using MovContainer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\workspace\ContainerMov\MovContainer\MovContainer\Views\Viewer\Index.cshtml"
using Stimulsoft.Report.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9a64b00246d8addb29ffebf9d7d4008360f2ff4", @"/Views/Viewer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c994be82c9d9cb76cfec95a896ea3fbcff6ffbd", @"/Views/_ViewImports.cshtml")]
    public class Views_Viewer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\workspace\ContainerMov\MovContainer\MovContainer\Views\Viewer\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Relatório de Movimentação</h1>\r\n<div class=”container”>\r\n    ");
#nullable restore
#line 9 "C:\workspace\ContainerMov\MovContainer\MovContainer\Views\Viewer\Index.cshtml"
Write(Html.StiNetCoreViewer(new StiNetCoreViewerOptions()
      {
        Actions =
        {
         GetReport = "GetReport",
         ViewerEvent = "ViewerEvent"
        }
    }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
