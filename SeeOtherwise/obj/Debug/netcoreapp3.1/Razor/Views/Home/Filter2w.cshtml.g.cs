#pragma checksum "C:\Users\marci\Documents\GitHub\SeeOtherwise\SeeOtherwise\Views\Home\Filter2w.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9153a68d4a5a9f986561694e55d1fc2d1905120e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Filter2w), @"mvc.1.0.view", @"/Views/Home/Filter2w.cshtml")]
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
#line 1 "C:\Users\marci\Documents\GitHub\SeeOtherwise\SeeOtherwise\Views\_ViewImports.cshtml"
using SeeOtherwise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\marci\Documents\GitHub\SeeOtherwise\SeeOtherwise\Views\_ViewImports.cshtml"
using SeeOtherwise.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9153a68d4a5a9f986561694e55d1fc2d1905120e", @"/Views/Home/Filter2w.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"001ff721ab646d1b5fc8e9cb4145742e5c990ba1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Filter2w : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\marci\Documents\GitHub\SeeOtherwise\SeeOtherwise\Views\Home\Filter2w.cshtml"
  
    ViewData["Title"] = "Filter2w";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<p> Twój link : ");
#nullable restore
#line 7 "C:\Users\marci\Documents\GitHub\SeeOtherwise\SeeOtherwise\Views\Home\Filter2w.cshtml"
           Write(ViewBag.Photo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Obrazek:</p>\r\n<div>\r\n<img");
            BeginWriteAttribute("src", " src=\"", 114, "\"", 148, 1);
#nullable restore
#line 10 "C:\Users\marci\Documents\GitHub\SeeOtherwise\SeeOtherwise\Views\Home\Filter2w.cshtml"
WriteAttributeValue("", 120, Url.Content(@ViewBag.Photo), 120, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n</div>\r\n<div>\r\n    <img");
            BeginWriteAttribute("src", " src=\"", 177, "\"", 268, 1);
#nullable restore
#line 13 "C:\Users\marci\Documents\GitHub\SeeOtherwise\SeeOtherwise\Views\Home\Filter2w.cshtml"
WriteAttributeValue("", 183, String.Format("data:image/png;base64,{0}", Convert.ToBase64String(@ViewBag.Bitmapa)), 183, 85, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n</div>\r\n");
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
