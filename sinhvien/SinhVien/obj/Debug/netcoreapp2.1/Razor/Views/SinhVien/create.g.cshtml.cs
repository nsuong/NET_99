#pragma checksum "C:\Users\Welcome\source\repos\SinhVien\SinhVien\Views\SinhVien\create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba2754cb46dc733db982bbd400619b35f7ce7ce6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SinhVien_create), @"mvc.1.0.view", @"/Views/SinhVien/create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SinhVien/create.cshtml", typeof(AspNetCore.Views_SinhVien_create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba2754cb46dc733db982bbd400619b35f7ce7ce6", @"/Views/SinhVien/create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d56ff165aa16dded3052ef47d481f9683111c25a", @"/Views/_ViewImports.cshtml")]
    public class Views_SinhVien_create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SinhVien.ViewModels.CreateSinhVienViewModels>
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
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Welcome\source\repos\SinhVien\SinhVien\Views\SinhVien\create.cshtml"
  
    ViewData["Title"] = "create";

#line default
#line hidden
            BeginContext(97, 103, true);
            WriteLiteral("\r\n<h2>create</h2>\r\n\r\n<h4>SinhVien</h4>\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        ");
            EndContext();
            BeginContext(200, 2101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6479ef7c826a472f9260456d7e2cbce0", async() => {
                BeginContext(226, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(240, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d89e43487d249eb9b5d217b264464aa", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 14 "C:\Users\Welcome\source\repos\SinhVien\SinhVien\Views\SinhVien\create.cshtml"
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
                BeginContext(306, 56, true);
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                ");
                EndContext();
                BeginContext(363, 85, false);
#line 16 "C:\Users\Welcome\source\repos\SinhVien\SinhVien\Views\SinhVien\create.cshtml"
           Write(Html.LabelFor(m => m.sinhVien.MaSV, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
                EndContext();
                BeginContext(448, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(467, 94, false);
#line 17 "C:\Users\Welcome\source\repos\SinhVien\SinhVien\Views\SinhVien\create.cshtml"
           Write(Html.EditorFor(m => m.sinhVien.MaSV, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
                EndContext();
                BeginContext(561, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(580, 83, false);
#line 18 "C:\Users\Welcome\source\repos\SinhVien\SinhVien\Views\SinhVien\create.cshtml"
           Write(Html.ValidationMessageFor(m => m.sinhVien.MaSV, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(663, 76, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
                EndContext();
                BeginContext(740, 86, false);
#line 21 "C:\Users\Welcome\source\repos\SinhVien\SinhVien\Views\SinhVien\create.cshtml"
           Write(Html.LabelFor(m => m.sinhVien.TenSV, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
                EndContext();
                BeginContext(826, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(845, 95, false);
#line 22 "C:\Users\Welcome\source\repos\SinhVien\SinhVien\Views\SinhVien\create.cshtml"
           Write(Html.EditorFor(m => m.sinhVien.TenSV, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
                EndContext();
                BeginContext(940, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(959, 84, false);
#line 23 "C:\Users\Welcome\source\repos\SinhVien\SinhVien\Views\SinhVien\create.cshtml"
           Write(Html.ValidationMessageFor(m => m.sinhVien.TenSV, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(1043, 76, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
                EndContext();
                BeginContext(1120, 89, false);
#line 26 "C:\Users\Welcome\source\repos\SinhVien\SinhVien\Views\SinhVien\create.cshtml"
           Write(Html.LabelFor(m => m.sinhVien.NgaySinh, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
                EndContext();
                BeginContext(1209, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(1228, 98, false);
#line 27 "C:\Users\Welcome\source\repos\SinhVien\SinhVien\Views\SinhVien\create.cshtml"
           Write(Html.EditorFor(m => m.sinhVien.NgaySinh, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
                EndContext();
                BeginContext(1326, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(1345, 87, false);
#line 28 "C:\Users\Welcome\source\repos\SinhVien\SinhVien\Views\SinhVien\create.cshtml"
           Write(Html.ValidationMessageFor(m => m.sinhVien.NgaySinh, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(1432, 76, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
                EndContext();
                BeginContext(1509, 87, false);
#line 31 "C:\Users\Welcome\source\repos\SinhVien\SinhVien\Views\SinhVien\create.cshtml"
           Write(Html.LabelFor(m => m.sinhVien.MaKhoa, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
                EndContext();
                BeginContext(1596, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(1615, 139, false);
#line 32 "C:\Users\Welcome\source\repos\SinhVien\SinhVien\Views\SinhVien\create.cshtml"
           Write(Html.DropDownListFor(m => m.sinhVien.MaKhoa, new SelectList(Model.khoa, "MaKhoa", "TenKhoa"), "chọn khoa", new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(1754, 76, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
                EndContext();
                BeginContext(1831, 87, false);
#line 35 "C:\Users\Welcome\source\repos\SinhVien\SinhVien\Views\SinhVien\create.cshtml"
           Write(Html.LabelFor(m => m.sinhVien.MonHoc, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
                EndContext();
                BeginContext(1918, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(1937, 139, false);
#line 36 "C:\Users\Welcome\source\repos\SinhVien\SinhVien\Views\SinhVien\create.cshtml"
           Write(Html.DropDownListFor(m => m.sinhVien.MaMon, new SelectList(Model.monHoc, "TenMon", "TenMmon"), "chọn môn", new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(2076, 218, true);
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
            BeginContext(2301, 35, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2336, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd9582dde30e43dc8e622d998e6d7d1a", async() => {
                BeginContext(2358, 12, true);
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
            BeginContext(2374, 12, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SinhVien.ViewModels.CreateSinhVienViewModels> Html { get; private set; }
    }
}
#pragma warning restore 1591
