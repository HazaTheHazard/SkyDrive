#pragma checksum "C:\Users\Matt\Desktop\New folder\SkyDrive\SkyDrive\SkyDrive\Pages\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d859aebe7a82af68d6db6dc702535f203e52e5a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SkyDrive.Pages.Pages_About), @"mvc.1.0.razor-page", @"/Pages/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/About.cshtml", typeof(SkyDrive.Pages.Pages_About), null)]
namespace SkyDrive.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Matt\Desktop\New folder\SkyDrive\SkyDrive\SkyDrive\Pages\_ViewImports.cshtml"
using SkyDrive;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d859aebe7a82af68d6db6dc702535f203e52e5a3", @"/Pages/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fdbd2ed934aa5382503d7da0e58ead575a1b157", @"/Pages/_ViewImports.cshtml")]
    public class Pages_About : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Matt\Desktop\New folder\SkyDrive\SkyDrive\SkyDrive\Pages\About.cshtml"
  
    ViewData["Title"] = "Student Body Statistics";

#line default
#line hidden
            BeginContext(102, 179, true);
            WriteLiteral("\r\n<h2>Student Body Statistics</h2>\r\n\r\n<table>\r\n    <tr>\r\n        <th>\r\n            Enrollment Date\r\n        </th>\r\n        <th>\r\n            Students\r\n        </th>\r\n    </tr>\r\n\r\n");
            EndContext();
#line 20 "C:\Users\Matt\Desktop\New folder\SkyDrive\SkyDrive\SkyDrive\Pages\About.cshtml"
     foreach (var item in Model.Student)
    {

#line default
#line hidden
            BeginContext(330, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(379, 49, false);
#line 24 "C:\Users\Matt\Desktop\New folder\SkyDrive\SkyDrive\SkyDrive\Pages\About.cshtml"
           Write(Html.DisplayFor(modelItem => item.EnrollmentDate));

#line default
#line hidden
            EndContext();
            BeginContext(428, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(484, 17, false);
#line 27 "C:\Users\Matt\Desktop\New folder\SkyDrive\SkyDrive\SkyDrive\Pages\About.cshtml"
           Write(item.StudentCount);

#line default
#line hidden
            EndContext();
            BeginContext(501, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 30 "C:\Users\Matt\Desktop\New folder\SkyDrive\SkyDrive\SkyDrive\Pages\About.cshtml"
    }

#line default
#line hidden
            BeginContext(544, 8, true);
            WriteLiteral("</table>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SkyDrive.Pages.AboutModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SkyDrive.Pages.AboutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SkyDrive.Pages.AboutModel>)PageContext?.ViewData;
        public SkyDrive.Pages.AboutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
