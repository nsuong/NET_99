#pragma checksum "C:\Users\Welcome\source\repos\SinhVien\SinhVien\Views\SinhVien\edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14d671101fb629ab5334f316683d4790550e1510"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SinhVien_edit), @"mvc.1.0.view", @"/Views/SinhVien/edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SinhVien/edit.cshtml", typeof(AspNetCore.Views_SinhVien_edit))]
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
#line 1 "C:\Users\Welcome\source\repos\SinhVien\SinhVien\Views\_ViewImports.cshtml"
using SinhVien;

#line default
#line hidden
#line 2 "C:\Users\Welcome\source\repos\SinhVien\SinhVien\Views\_ViewImports.cshtml"
using SinhVien.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14d671101fb629ab5334f316683d4790550e1510", @"/Views/SinhVien/edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d56ff165aa16dded3052ef47d481f9683111c25a", @"/Views/_ViewImports.cshtml")]
    public class Views_SinhVien_edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SinhVien.Models.SinhVient>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Welcome\source\repos\SinhVien\SinhVien\Views\SinhVien\edit.cshtml"
  
    ViewData["Title"] = "create";

#line default
#line hidden
            BeginContext(78, 103, true);
            WriteLiteral("\r\n<h2>create</h2>\r\n\r\n<h4>SinhVien</h4>\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        ");
            EndContext();
            BeginContext(181, 1376, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f181ddadeba04bb080b3aa36439856dc", async() => {
                BeginContext(207, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(221, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58ff5f04f1864828aa8d5a7b31fd724a", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 14 "C:\Users\Welcome\source\repos\SinhVien\SinhVien\Views\SinhVien\edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(287, 56, true);
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                ");
                EndContext();
                BeginContext(344, 76, false);
#line 16 "C:\Users\Welcome\source\repos\SinhVien\SinhVien\Views\SinhVien\edit.cshtml"
           Write(Html.LabelFor(m => m.MaSV, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
                EndContext();
                BeginContext(420, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(439, 85, false);
#line 17 "C:\Users\Welcome\source\repos\SinhVien\SinhVien\Views\SinhVien\edit.cshtml"
           Write(Html.EditorFor(m => m.MaSV, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
                EndContext();
                BeginContext(524, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(543, 74, false);
#line 18 "C:\Users\Welcome\source\repos\SinhVien\SinhVien\Views\SinhVien\edit.cshtml"
           Write(Html.ValidationMessageFor(m => m.MaSV, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(617, 76, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
                EndContext();
                BeginContext(694, 77, false);
#line 21 "C:\Users\Welcome\source\repos\SinhVien\SinhVien\Views\SinhVien\edit.cshtml"
           Write(Html.LabelFor(m => m.TenSV, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
                EndContext();
                BeginContext(771, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(790, 86, false);
#line 22 "C:\Users\Welcome\source\repos\SinhVien\SinhVien\Views\SinhVien\edit.cshtml"
           Write(Html.EditorFor(m => m.TenSV, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
                EndContext();
                BeginContext(876, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(895, 75, false);
#line 23 "C:\Users\Welcome\source\repos\SinhVien\SinhVien\Views\SinhVien\edit.cshtml"
           Write(Html.ValidationMessageFor(m => m.TenSV, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(970, 76, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
                EndContext();
                BeginContext(1047, 80, false);
#line 26 "C:\Users\Welcome\source\repos\SinhVien\SinhVien\Views\SinhVien\edit.cshtml"
           Write(Html.LabelFor(m => m.NgaySinh, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
                EndContext();
                BeginContext(1127, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(1146, 89, false);
#line 27 "C:\Users\Welcome\source\repos\SinhVien\SinhVien\Views\SinhVien\edit.cshtml"
           Write(Html.EditorFor(m => m.NgaySinh, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
                EndContext();
                BeginContext(1235, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(1254, 78, false);
#line 28 "C:\Users\Welcome\source\repos\SinhVien\SinhVien\Views\SinhVien\edit.cshtml"
           Write(Html.ValidationMessageFor(m => m.NgaySinh, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(1332, 218, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <div class=\"form-group\">\r\n                    <input type=\"submit\" value=\"Create\" class=\"btn btn-default\" />\r\n                </div>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1557, 35, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1592, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b6f3e9951964e6f8ff7f98b2596d316", async() => {
                BeginContext(1614, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1630, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SinhVien.Models.SinhVient> Html { get; private set; }
    }
}
#pragma warning restore 1591