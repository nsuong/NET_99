#pragma checksum "C:\Users\Welcome\source\repos\SinhVien\SinhVien\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9afa1fa0bb72a87c89503dffdc2f934c9f899ee1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9afa1fa0bb72a87c89503dffdc2f934c9f899ee1", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d56ff165aa16dded3052ef47d481f9683111c25a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Welcome\source\repos\SinhVien\SinhVien\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 40, true);
            WriteLiteral("\r\n\r\n<div>\r\n    <br /> <br /><br />\r\n    ");
            EndContext();
            BeginContext(86, 93, false);
#line 8 "C:\Users\Welcome\source\repos\SinhVien\SinhVien\Views\Home\Index.cshtml"
Write(Html.ActionLink("Quản lý sinh viên", "Index", "SinhVien", new { @class = "btn btn-default" }));

#line default
#line hidden
            EndContext();
            BeginContext(179, 11, true);
            WriteLiteral(" <br>\r\n    ");
            EndContext();
            BeginContext(191, 90, false);
#line 9 "C:\Users\Welcome\source\repos\SinhVien\SinhVien\Views\Home\Index.cshtml"
Write(Html.ActionLink("Quản lý môn học ", "Index", "MonHoc", new { @class = "btn btn-default" }));

#line default
#line hidden
            EndContext();
            BeginContext(281, 11, true);
            WriteLiteral(" <br>\r\n    ");
            EndContext();
            BeginContext(293, 84, false);
#line 10 "C:\Users\Welcome\source\repos\SinhVien\SinhVien\Views\Home\Index.cshtml"
Write(Html.ActionLink("Quản lý khoa", "Index", "Khoa", new { @class = "btn btn-default" }));

#line default
#line hidden
            EndContext();
            BeginContext(377, 11, true);
            WriteLiteral(" <br>\r\n    ");
            EndContext();
            BeginContext(389, 82, false);
#line 11 "C:\Users\Welcome\source\repos\SinhVien\SinhVien\Views\Home\Index.cshtml"
Write(Html.ActionLink("Xem Điểm", "Index", "KetQua", new { @class = "btn btn-default" }));

#line default
#line hidden
            EndContext();
            BeginContext(471, 17, true);
            WriteLiteral(" <br>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
