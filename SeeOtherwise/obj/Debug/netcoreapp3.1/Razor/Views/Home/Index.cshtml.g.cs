#pragma checksum "D:\Programowanie\SeeOtherwise\SeeOtherwise\SeeOtherwise\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aefba06b50bb4727d8aa8df2f9102d308ece9bb1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\Programowanie\SeeOtherwise\SeeOtherwise\SeeOtherwise\Views\_ViewImports.cshtml"
using SeeOtherwise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Programowanie\SeeOtherwise\SeeOtherwise\SeeOtherwise\Views\_ViewImports.cshtml"
using SeeOtherwise.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aefba06b50bb4727d8aa8df2f9102d308ece9bb1", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"001ff721ab646d1b5fc8e9cb4145742e5c990ba1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Programowanie\SeeOtherwise\SeeOtherwise\SeeOtherwise\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""jumbotron"">
    <h1>See otherwise</h1>
    <p class=""lead"">

        is an application that allows us to see the world as from another reality. Upload your photos and use any of the available filters and look at them from a different angle.
    </p>

</div>

<div class=""row"">
    <div class=""col-md-4"">
        <h2>First filter</h2>
        <p>
            This is first filter, made by Mariusz Hoang
        </p>
        <h3>");
#nullable restore
#line 21 "D:\Programowanie\SeeOtherwise\SeeOtherwise\SeeOtherwise\Views\Home\Index.cshtml"
       Write(Html.ActionLink("Show Filter1", "Filter1", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    </div>\r\n    <div class=\"col-md-4\">\r\n        <h2>Secound filter</h2>\r\n        <p>\r\n            This is secount filter, made by Marcin Czarnecki\r\n        </p>\r\n        <h3>");
#nullable restore
#line 28 "D:\Programowanie\SeeOtherwise\SeeOtherwise\SeeOtherwise\Views\Home\Index.cshtml"
       Write(Html.ActionLink("Show Filter2", "Filter2", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    </div>\r\n    <div class=\"col-md-4\">\r\n        <h2>Third filter</h2>\r\n        <p>\r\n            This is third filter, made by Marcin Krupnik\r\n        </p>\r\n        <h3>");
#nullable restore
#line 35 "D:\Programowanie\SeeOtherwise\SeeOtherwise\SeeOtherwise\Views\Home\Index.cshtml"
       Write(Html.ActionLink("Show Filter3", "Filter3", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    </div>\r\n</div>\r\n");
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
