#pragma checksum "C:\Users\Welcome\source\repos\SinhVien\SinhVien\Views\KetQua\create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73cae5391217d5906d04858970203b3813a5c2b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_KetQua_create), @"mvc.1.0.view", @"/Views/KetQua/create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/KetQua/create.cshtml", typeof(AspNetCore.Views_KetQua_create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73cae5391217d5906d04858970203b3813a5c2b1", @"/Views/KetQua/create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d56ff165aa16dded3052ef47d481f9683111c25a", @"/Views/_ViewImports.cshtml")]
    public class Views_KetQua_create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SinhVien.ViewModels.createDiem>
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
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Welcome\source\repos\SinhVien\SinhVien\Views\KetQua\create.cshtml"
  
    ViewData["Title"] = "create";

#line default
#line hidden
            BeginContext(83, 101, true);
            WriteLiteral("\r\n<h2>create</h2>\r\n\r\n<h4>KetQua</h4>\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        ");
            EndContext();
            BeginContext(184, 1714, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bdb39f1ab9134e009c6daa69aaf01642", async() => {
                BeginContext(210, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(224, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d35fe347a04d49b785143553e362a611", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 14 "C:\Users\Welcome\source\repos\SinhVien\SinhVien\Views\KetQua\create.cshtml"
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
                BeginContext(290, 56, true);
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                ");
                EndContext();
                BeginContext(347, 83, false);
#line 16 "C:\Users\Welcome\source\repos\SinhVien\SinhVien\Views\KetQua\create.cshtml"
           Write(Html.LabelFor(m => m.ketQua.MaKQ, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
                EndContext();
                BeginContext(430, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(449, 92, false);
#line 17 "C:\Users\Welcome\source\repos\SinhVien\SinhVien\Views\KetQua\create.cshtml"
           Write(Html.EditorFor(m => m.ketQua.MaKQ, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
                EndContext();
                BeginContext(541, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(560, 81, false);
#line 18 "C:\Users\Welcome\source\repos\SinhVien\SinhVien\Views\KetQua\create.cshtml"
           Write(Html.ValidationMessageFor(m => m.ketQua.MaKQ, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(641, 76, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
                EndContext();
                BeginContext(718, 84, false);
#line 21 "C:\Users\Welcome\source\repos\SinhVien\SinhVien\Views\KetQua\create.cshtml"
           Write(Html.LabelFor(m => m.ketQua.MaMon, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
                EndContext();
                BeginContext(802, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(821, 136, false);
#line 22 "C:\Users\Welcome\source\repos\SinhVien\SinhVien\Views\KetQua\create.cshtml"
           Write(Html.DropDownListFor(m => m.ketQua.MaMon, new SelectList(Model.monHoc, "MaMon", "TenMmon"), "chọn môn", new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(957, 76, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
                EndContext();
                BeginContext(1034, 83, false);
#line 25 "C:\Users\Welcome\source\repos\SinhVien\SinhVien\Views\KetQua\create.cshtml"
           Write(Html.LabelFor(m => m.ketQua.Diem, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
                EndContext();
                BeginContext(1117, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(1136, 92, false);
#line 26 "C:\Users\Welcome\source\repos\SinhVien\SinhVien\Views\KetQua\create.cshtml"
           Write(Html.EditorFor(m => m.ketQua.Diem, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
                EndContext();
                BeginContext(1228, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(1247, 81, false);
#line 27 "C:\Users\Welcome\source\repos\SinhVien\SinhVien\Views\KetQua\create.cshtml"
           Write(Html.ValidationMessageFor(m => m.ketQua.Diem, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(1328, 76, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
                EndContext();
                BeginContext(1405, 83, false);
#line 30 "C:\Users\Welcome\source\repos\SinhVien\SinhVien\Views\KetQua\create.cshtml"
           Write(Html.LabelFor(m => m.ketQua.MaSV, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
                EndContext();
                BeginContext(1488, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(1507, 116, false);
#line 31 "C:\Users\Welcome\source\repos\SinhVien\SinhVien\Views\KetQua\create.cshtml"
           Write(Html.EditorFor(m => m.ketQua.MaSV, new { htmlAttributes = new { @class = "form-control", @readonly = "readonly" } }));

#line default
#line hidden
                EndContext();
                BeginContext(1623, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(1642, 81, false);
#line 32 "C:\Users\Welcome\source\repos\SinhVien\SinhVien\Views\KetQua\create.cshtml"
           Write(Html.ValidationMessageFor(m => m.ketQua.MaSV, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(1723, 168, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Create\" class=\"btn btn-default\" />\r\n            </div>\r\n        ");
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
            BeginContext(1898, 35, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1933, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7f40f437ebd48489bd77c44a136b44b", async() => {
                BeginContext(1955, 12, true);
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
            BeginContext(1971, 12, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SinhVien.ViewModels.createDiem> Html { get; private set; }
    }
}
#pragma warning restore 1591
