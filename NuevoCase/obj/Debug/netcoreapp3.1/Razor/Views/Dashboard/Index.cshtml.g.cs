#pragma checksum "C:\Users\ALI\Desktop\NuevoCase\NuevoCase\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b80fcd62c7e02db5d4a536905ed2c4b98b5349b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Index), @"mvc.1.0.view", @"/Views/Dashboard/Index.cshtml")]
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
#line 1 "C:\Users\ALI\Desktop\NuevoCase\NuevoCase\Views\_ViewImports.cshtml"
using NuevoCase;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ALI\Desktop\NuevoCase\NuevoCase\Views\_ViewImports.cshtml"
using NuevoCase.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b80fcd62c7e02db5d4a536905ed2c4b98b5349b", @"/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e84faa949fc536a0a0cfa0140cd778ca6720c0a7", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\ALI\Desktop\NuevoCase\NuevoCase\Views\Dashboard\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div class=\"container\">\r\n    Hoşgeldin, <h4 class=\"d-inline\">\r\n        ");
#nullable restore
#line 11 "C:\Users\ALI\Desktop\NuevoCase\NuevoCase\Views\Dashboard\Index.cshtml"
   Write(User.Claims.Where(c => c.Type == System.Security.Claims.ClaimTypes.Name).Select(c => c.Value).SingleOrDefault());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h4>\r\n    <div class=\"clearfix\"></div>\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 332, "\"", 373, 1);
#nullable restore
#line 14 "C:\Users\ALI\Desktop\NuevoCase\NuevoCase\Views\Dashboard\Index.cshtml"
WriteAttributeValue("", 339, Url.Action("addtask","dashboard"), 339, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success mt-2\">Yeni görev ekle</a>\r\n</div>\r\n");
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