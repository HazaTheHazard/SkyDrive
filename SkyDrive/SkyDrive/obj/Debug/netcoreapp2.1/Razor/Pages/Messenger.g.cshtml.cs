#pragma checksum "C:\Users\Matt\Desktop\New folder\SkyDrive\SkyDrive\SkyDrive\Pages\Messenger.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63de2f05a2151181fc3958203b7a16ba0b0819fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SkyDrive.Pages.Private.Pages_Messenger), @"mvc.1.0.razor-page", @"/Pages/Messenger.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Messenger.cshtml", typeof(SkyDrive.Pages.Private.Pages_Messenger), null)]
namespace SkyDrive.Pages.Private
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63de2f05a2151181fc3958203b7a16ba0b0819fc", @"/Pages/Messenger.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fdbd2ed934aa5382503d7da0e58ead575a1b157", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Messenger : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\Users\Matt\Desktop\New folder\SkyDrive\SkyDrive\SkyDrive\Pages\Messenger.cshtml"
  
    ViewData["Title"] = "Messenger";

#line default
#line hidden
            BeginContext(110, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(115, 17, false);
#line 7 "C:\Users\Matt\Desktop\New folder\SkyDrive\SkyDrive\SkyDrive\Pages\Messenger.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(132, 11, true);
            WriteLiteral("</h1>\r\n<h2>");
            EndContext();
            BeginContext(144, 13, false);
#line 8 "C:\Users\Matt\Desktop\New folder\SkyDrive\SkyDrive\SkyDrive\Pages\Messenger.cshtml"
Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(157, 9, true);
            WriteLiteral("</h2>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(184, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 11 "C:\Users\Matt\Desktop\New folder\SkyDrive\SkyDrive\SkyDrive\Pages\Messenger.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MessengerModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MessengerModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MessengerModel>)PageContext?.ViewData;
        public MessengerModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
