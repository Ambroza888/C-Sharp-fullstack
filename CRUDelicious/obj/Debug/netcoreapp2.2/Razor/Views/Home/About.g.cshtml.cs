#pragma checksum "D:\Coding_Dojo_C#\fullSTACK\CRUDelicious\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffa76ca646fd7de183019cf812e361653fb9dd08"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
#line 1 "D:\Coding_Dojo_C#\fullSTACK\CRUDelicious\Views\_ViewImports.cshtml"
using CRUDelicious;

#line default
#line hidden
#line 2 "D:\Coding_Dojo_C#\fullSTACK\CRUDelicious\Views\Home\About.cshtml"
using CRUDelicious.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffa76ca646fd7de183019cf812e361653fb9dd08", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"815eae4269ab1eac71e8261ccfa9294c33285639", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dish>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 25, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n<h1>");
            EndContext();
            BeginContext(67, 10, false);
#line 5 "D:\Coding_Dojo_C#\fullSTACK\CRUDelicious\Views\Home\About.cshtml"
Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(77, 40, true);
            WriteLiteral("</h1>\r\n</div>\r\n<div class=\"row\">\r\n<p>by ");
            EndContext();
            BeginContext(118, 10, false);
#line 8 "D:\Coding_Dojo_C#\fullSTACK\CRUDelicious\Views\Home\About.cshtml"
 Write(Model.Chef);

#line default
#line hidden
            EndContext();
            BeginContext(128, 38, true);
            WriteLiteral("</p>\r\n</div>\r\n<div class=\"row\">\r\n  <p>");
            EndContext();
            BeginContext(167, 17, false);
#line 11 "D:\Coding_Dojo_C#\fullSTACK\CRUDelicious\Views\Home\About.cshtml"
Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(184, 48, true);
            WriteLiteral("</p>\r\n</div>\r\n<div class=\"row\">\r\n  <p>Calories: ");
            EndContext();
            BeginContext(233, 14, false);
#line 14 "D:\Coding_Dojo_C#\fullSTACK\CRUDelicious\Views\Home\About.cshtml"
          Write(Model.Calories);

#line default
#line hidden
            EndContext();
            BeginContext(247, 49, true);
            WriteLiteral("</p>\r\n</div>\r\n<div class=\"row\">\r\n  <p>Tastiness: ");
            EndContext();
            BeginContext(297, 15, false);
#line 17 "D:\Coding_Dojo_C#\fullSTACK\CRUDelicious\Views\Home\About.cshtml"
           Write(Model.Tastiness);

#line default
#line hidden
            EndContext();
            BeginContext(312, 74, true);
            WriteLiteral("</p>\r\n</div>\r\n<div class=\"row\">\r\n  <div class=\"col-1 p-0\">\r\n    <button><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 386, "\"", 414, 2);
            WriteAttributeValue("", 393, "/Delete/", 393, 8, true);
#line 21 "D:\Coding_Dojo_C#\fullSTACK\CRUDelicious\Views\Home\About.cshtml"
WriteAttributeValue("", 401, Model.DishId, 401, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(415, 67, true);
            WriteLiteral(">Delete</a></button>\r\n  </div>\r\n  <div class=\"col\">\r\n    <button><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 482, "\"", 508, 2);
            WriteAttributeValue("", 489, "/Edit/", 489, 6, true);
#line 24 "D:\Coding_Dojo_C#\fullSTACK\CRUDelicious\Views\Home\About.cshtml"
WriteAttributeValue("", 495, Model.DishId, 495, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(509, 36, true);
            WriteLiteral(">Edit</a></button>\r\n  </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dish> Html { get; private set; }
    }
}
#pragma warning restore 1591