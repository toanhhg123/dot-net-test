#pragma checksum "D:\BaiTap\LeHuuToan_2001206939_LTW\LeHuuToan_2001206939_LTW\Views\NhanVien\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82fde41310fbe4f91568687c2fbb3b22c9c01530"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NhanVien_Index), @"mvc.1.0.view", @"/Views/NhanVien/Index.cshtml")]
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
#line 1 "D:\BaiTap\LeHuuToan_2001206939_LTW\LeHuuToan_2001206939_LTW\Views\_ViewImports.cshtml"
using LeHuuToan_2001206939_LTW;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\BaiTap\LeHuuToan_2001206939_LTW\LeHuuToan_2001206939_LTW\Views\_ViewImports.cshtml"
using LeHuuToan_2001206939_LTW.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82fde41310fbe4f91568687c2fbb3b22c9c01530", @"/Views/NhanVien/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"981a3e36e2e62987ac3f231252609fb0fa1bb1ab", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_NhanVien_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LeHuuToan_2001206939_LTW.Models.NhanVien>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\BaiTap\LeHuuToan_2001206939_LTW\LeHuuToan_2001206939_LTW\Views\NhanVien\Index.cshtml"
  
    ViewData["Title"] = "Nhan Vien";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<table class=""table"">
    <thead>
        <tr>
            <th scope=""col"">Id</th>
            <th scope=""col"">Name</th>
            <th scope=""col"">Sex</th>
            <th scope=""col"">Image</th>

        </tr>
    </thead>
    <tbody>

        <tr>
            <td>");
#nullable restore
#line 20 "D:\BaiTap\LeHuuToan_2001206939_LTW\LeHuuToan_2001206939_LTW\Views\NhanVien\Index.cshtml"
           Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "D:\BaiTap\LeHuuToan_2001206939_LTW\LeHuuToan_2001206939_LTW\Views\NhanVien\Index.cshtml"
           Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "D:\BaiTap\LeHuuToan_2001206939_LTW\LeHuuToan_2001206939_LTW\Views\NhanVien\Index.cshtml"
           Write(Model.Sex);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><img width=\"100\"");
            BeginWriteAttribute("src", " src=\"", 493, "\"", 509, 1);
#nullable restore
#line 23 "D:\BaiTap\LeHuuToan_2001206939_LTW\LeHuuToan_2001206939_LTW\Views\NhanVien\Index.cshtml"
WriteAttributeValue("", 499, Model.Img, 499, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n\r\n        </tr>\r\n\r\n    </tbody>\r\n</table>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LeHuuToan_2001206939_LTW.Models.NhanVien> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
