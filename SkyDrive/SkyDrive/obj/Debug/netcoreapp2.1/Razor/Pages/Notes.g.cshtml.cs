#pragma checksum "C:\Users\Matt\Desktop\New folder\SkyDrive\SkyDrive\SkyDrive\Pages\Notes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "441c1298d4b6c6a7a7519a563e3990e4267d0555"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SkyDrive.Pages.Private.Pages_Notes), @"mvc.1.0.razor-page", @"/Pages/Notes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Notes.cshtml", typeof(SkyDrive.Pages.Private.Pages_Notes), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"441c1298d4b6c6a7a7519a563e3990e4267d0555", @"/Pages/Notes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fdbd2ed934aa5382503d7da0e58ead575a1b157", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Notes : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\Users\Matt\Desktop\New folder\SkyDrive\SkyDrive\SkyDrive\Pages\Notes.cshtml"
  
    ViewData["Title"] = "Notes";

#line default
#line hidden
            BeginContext(102, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(107, 17, false);
#line 7 "C:\Users\Matt\Desktop\New folder\SkyDrive\SkyDrive\SkyDrive\Pages\Notes.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(124, 11, true);
            WriteLiteral("</h1>\r\n<h2>");
            EndContext();
            BeginContext(136, 13, false);
#line 8 "C:\Users\Matt\Desktop\New folder\SkyDrive\SkyDrive\SkyDrive\Pages\Notes.cshtml"
Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(149, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(161, 23, false);
#line 9 "C:\Users\Matt\Desktop\New folder\SkyDrive\SkyDrive\SkyDrive\Pages\Notes.cshtml"
Write(Model.DeleteNotifcation);

#line default
#line hidden
            EndContext();
            BeginContext(184, 9, true);
            WriteLiteral("</h3>\r\n\r\n");
            EndContext();
#line 11 "C:\Users\Matt\Desktop\New folder\SkyDrive\SkyDrive\SkyDrive\Pages\Notes.cshtml"
 foreach (var item in Model.Notes)
{

#line default
#line hidden
            BeginContext(232, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(236, 191, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a70d29b2842499f977f5f08559e29fe", async() => {
                BeginContext(280, 30, true);
                WriteLiteral("\r\n        <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 310, "\"", 326, 1);
#line 14 "C:\Users\Matt\Desktop\New folder\SkyDrive\SkyDrive\SkyDrive\Pages\Notes.cshtml"
WriteAttributeValue("", 318, item.ID, 318, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(327, 64, true);
                WriteLiteral(" name=\"id\" />\r\n        <input class=\"btn btn-info\" type=\"submit\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 391, "\"", 410, 1);
#line 15 "C:\Users\Matt\Desktop\New folder\SkyDrive\SkyDrive\SkyDrive\Pages\Notes.cshtml"
WriteAttributeValue("", 399, item.Title, 399, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(411, 9, true);
                WriteLiteral(" />\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(427, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 17 "C:\Users\Matt\Desktop\New folder\SkyDrive\SkyDrive\SkyDrive\Pages\Notes.cshtml"
}

#line default
#line hidden
#line 18 "C:\Users\Matt\Desktop\New folder\SkyDrive\SkyDrive\SkyDrive\Pages\Notes.cshtml"
 if (Model.ActiveNote != null)
{

#line default
#line hidden
            BeginContext(467, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(471, 204, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65f2ae7a58094b0092d92f4e761930bd", async() => {
                BeginContext(515, 30, true);
                WriteLiteral("\r\n        <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 545, "\"", 573, 1);
#line 21 "C:\Users\Matt\Desktop\New folder\SkyDrive\SkyDrive\SkyDrive\Pages\Notes.cshtml"
WriteAttributeValue("", 553, Model.ActiveNote.ID, 553, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(574, 94, true);
                WriteLiteral(" name=\"Delete\" />\r\n        <input class=\"btn btn-danger\" type=\"submit\" value=\"Delete\" />\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(675, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 24 "C:\Users\Matt\Desktop\New folder\SkyDrive\SkyDrive\SkyDrive\Pages\Notes.cshtml"
}

#line default
#line hidden
#line 25 "C:\Users\Matt\Desktop\New folder\SkyDrive\SkyDrive\SkyDrive\Pages\Notes.cshtml"
 if (Model.ActiveNote != null)
{

#line default
#line hidden
            BeginContext(715, 85, true);
            WriteLiteral("    <div class=\"jumbotron\">\r\n        <h2 class=\"display-4 text-center\">\r\n            ");
            EndContext();
            BeginContext(801, 22, false);
#line 29 "C:\Users\Matt\Desktop\New folder\SkyDrive\SkyDrive\SkyDrive\Pages\Notes.cshtml"
       Write(Model.ActiveNote.Title);

#line default
#line hidden
            EndContext();
            BeginContext(823, 42, true);
            WriteLiteral("\r\n        </h2>\r\n        <hr>\r\n        <p>");
            EndContext();
            BeginContext(866, 21, false);
#line 32 "C:\Users\Matt\Desktop\New folder\SkyDrive\SkyDrive\SkyDrive\Pages\Notes.cshtml"
      Write(Model.ActiveNote.Body);

#line default
#line hidden
            EndContext();
            BeginContext(887, 18, true);
            WriteLiteral("</p>\r\n    </div>\r\n");
            EndContext();
#line 34 "C:\Users\Matt\Desktop\New folder\SkyDrive\SkyDrive\SkyDrive\Pages\Notes.cshtml"
}

#line default
#line hidden
            BeginContext(908, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(930, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 38 "C:\Users\Matt\Desktop\New folder\SkyDrive\SkyDrive\SkyDrive\Pages\Notes.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NotesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<NotesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<NotesModel>)PageContext?.ViewData;
        public NotesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
