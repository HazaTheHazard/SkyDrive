#pragma checksum "C:\Users\Matt\Desktop\New folder\SkyDrive\SkyDrive\SkyDrive\Pages\Notes\Notes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1fe210351007db939de290e189e374fd2b33f78f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SkyDrive.Pages.Notes.Pages_Notes_Notes), @"mvc.1.0.razor-page", @"/Pages/Notes/Notes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Notes/Notes.cshtml", typeof(SkyDrive.Pages.Notes.Pages_Notes_Notes), null)]
namespace SkyDrive.Pages.Notes
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fe210351007db939de290e189e374fd2b33f78f", @"/Pages/Notes/Notes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fdbd2ed934aa5382503d7da0e58ead575a1b157", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Notes_Notes : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./EditNote", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\Users\Matt\Desktop\New folder\SkyDrive\SkyDrive\SkyDrive\Pages\Notes\Notes.cshtml"
  
    ViewData["Title"] = "Notes";

#line default
#line hidden
            BeginContext(100, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(105, 17, false);
#line 7 "C:\Users\Matt\Desktop\New folder\SkyDrive\SkyDrive\SkyDrive\Pages\Notes\Notes.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(122, 11, true);
            WriteLiteral("</h1>\r\n<h2>");
            EndContext();
            BeginContext(134, 13, false);
#line 8 "C:\Users\Matt\Desktop\New folder\SkyDrive\SkyDrive\SkyDrive\Pages\Notes\Notes.cshtml"
Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(147, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(159, 23, false);
#line 9 "C:\Users\Matt\Desktop\New folder\SkyDrive\SkyDrive\SkyDrive\Pages\Notes\Notes.cshtml"
Write(Model.DeleteNotifcation);

#line default
#line hidden
            EndContext();
            BeginContext(182, 9, true);
            WriteLiteral("</h3>\r\n\r\n");
            EndContext();
#line 11 "C:\Users\Matt\Desktop\New folder\SkyDrive\SkyDrive\SkyDrive\Pages\Notes\Notes.cshtml"
 foreach (var item in Model.Notes)
{

#line default
#line hidden
            BeginContext(230, 179, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d691a56b1f254a918e9e5a1e16eeb391", async() => {
                BeginContext(274, 26, true);
                WriteLiteral("\r\n    <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 300, "\"", 316, 1);
#line 14 "C:\Users\Matt\Desktop\New folder\SkyDrive\SkyDrive\SkyDrive\Pages\Notes\Notes.cshtml"
WriteAttributeValue("", 308, item.ID, 308, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(317, 60, true);
                WriteLiteral(" name=\"id\" />\r\n    <input class=\"btn btn-info\" type=\"submit\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 377, "\"", 396, 1);
#line 15 "C:\Users\Matt\Desktop\New folder\SkyDrive\SkyDrive\SkyDrive\Pages\Notes\Notes.cshtml"
WriteAttributeValue("", 385, item.Title, 385, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(397, 5, true);
                WriteLiteral(" />\r\n");
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
            BeginContext(409, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 17 "C:\Users\Matt\Desktop\New folder\SkyDrive\SkyDrive\SkyDrive\Pages\Notes\Notes.cshtml"
}

#line default
#line hidden
            BeginContext(414, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "908e6129da344c2ab5fa3e1ded29f7e6", async() => {
                BeginContext(461, 17, true);
                WriteLiteral("Create a new Note");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(482, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 20 "C:\Users\Matt\Desktop\New folder\SkyDrive\SkyDrive\SkyDrive\Pages\Notes\Notes.cshtml"
 if (Model.ActiveNote != null)
{

#line default
#line hidden
            BeginContext(521, 98, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0c79d4e9eca4fd4b7fd40c4ef4841a6", async() => {
                BeginContext(606, 9, true);
                WriteLiteral("Edit Note");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 22 "C:\Users\Matt\Desktop\New folder\SkyDrive\SkyDrive\SkyDrive\Pages\Notes\Notes.cshtml"
                                                   WriteLiteral(Model.ActiveNote.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(619, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(621, 192, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c358fc588e14cbb93dca4613e0de0f3", async() => {
                BeginContext(665, 26, true);
                WriteLiteral("\r\n    <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 691, "\"", 719, 1);
#line 24 "C:\Users\Matt\Desktop\New folder\SkyDrive\SkyDrive\SkyDrive\Pages\Notes\Notes.cshtml"
WriteAttributeValue("", 699, Model.ActiveNote.ID, 699, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(720, 86, true);
                WriteLiteral(" name=\"Delete\" />\r\n    <input class=\"btn btn-danger\" type=\"submit\" value=\"Delete\" />\r\n");
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
            BeginContext(813, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 27 "C:\Users\Matt\Desktop\New folder\SkyDrive\SkyDrive\SkyDrive\Pages\Notes\Notes.cshtml"
}

#line default
#line hidden
            BeginContext(818, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 29 "C:\Users\Matt\Desktop\New folder\SkyDrive\SkyDrive\SkyDrive\Pages\Notes\Notes.cshtml"
 if (Model.ActiveNote != null)
{

#line default
#line hidden
            BeginContext(855, 73, true);
            WriteLiteral("<div class=\"jumbotron\">\r\n    <h2 class=\"display-4 text-center\">\r\n        ");
            EndContext();
            BeginContext(929, 22, false);
#line 33 "C:\Users\Matt\Desktop\New folder\SkyDrive\SkyDrive\SkyDrive\Pages\Notes\Notes.cshtml"
   Write(Model.ActiveNote.Title);

#line default
#line hidden
            EndContext();
            BeginContext(951, 30, true);
            WriteLiteral("\r\n    </h2>\r\n    <hr>\r\n    <p>");
            EndContext();
            BeginContext(982, 21, false);
#line 36 "C:\Users\Matt\Desktop\New folder\SkyDrive\SkyDrive\SkyDrive\Pages\Notes\Notes.cshtml"
  Write(Model.ActiveNote.Body);

#line default
#line hidden
            EndContext();
            BeginContext(1003, 14, true);
            WriteLiteral("</p>\r\n</div>\r\n");
            EndContext();
#line 38 "C:\Users\Matt\Desktop\New folder\SkyDrive\SkyDrive\SkyDrive\Pages\Notes\Notes.cshtml"
}

#line default
#line hidden
            BeginContext(1020, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1040, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 41 "C:\Users\Matt\Desktop\New folder\SkyDrive\SkyDrive\SkyDrive\Pages\Notes\Notes.cshtml"
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
