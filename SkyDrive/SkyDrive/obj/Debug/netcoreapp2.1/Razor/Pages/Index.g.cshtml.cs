#pragma checksum "C:\Users\Matt\Desktop\New folder\SkyDrive\SkyDrive\SkyDrive\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a093a620633b5c2968261fa89c1b4a48238bf04e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SkyDrive.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(SkyDrive.Pages.Pages_Index), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a093a620633b5c2968261fa89c1b4a48238bf04e", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fdbd2ed934aa5382503d7da0e58ead575a1b157", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Matt\Desktop\New folder\SkyDrive\SkyDrive\SkyDrive\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
            BeginContext(71, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\Matt\Desktop\New folder\SkyDrive\SkyDrive\SkyDrive\Pages\Index.cshtml"
 if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
            BeginContext(113, 161, true);
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"jumbotron text-center\">\r\n            <h1 class=\"display-4\">Welcome back</h1>\r\n            <h2 class=\"display-4\">Name: ");
            EndContext();
            BeginContext(275, 60, false);
#line 12 "C:\Users\Matt\Desktop\New folder\SkyDrive\SkyDrive\SkyDrive\Pages\Index.cshtml"
                                   Write(User.Claims.FirstOrDefault(c => c.Type == "FullName")?.Value);

#line default
#line hidden
            EndContext();
            BeginContext(335, 48, true);
            WriteLiteral("</h2>\r\n            <h2 class=\"display-4\">Email: ");
            EndContext();
            BeginContext(384, 18, false);
#line 13 "C:\Users\Matt\Desktop\New folder\SkyDrive\SkyDrive\SkyDrive\Pages\Index.cshtml"
                                    Write(User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(402, 35, true);
            WriteLiteral("</h2>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 16 "C:\Users\Matt\Desktop\New folder\SkyDrive\SkyDrive\SkyDrive\Pages\Index.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(449, 199, true);
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"jumbotron text-center\">\r\n            <h1 class=\"display-4\">Welcome</h1>\r\n            <h2 class=\"display-4\">Please sign in</h2>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 25 "C:\Users\Matt\Desktop\New folder\SkyDrive\SkyDrive\SkyDrive\Pages\Index.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
