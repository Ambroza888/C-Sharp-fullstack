#pragma checksum "D:\Coding_Dojo_C#\fullSTACK\c_sharp_proj\Views\Home\Dashbord.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "696a39b30a6fc9309b22925053ca2e664e7e477b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashbord), @"mvc.1.0.view", @"/Views/Home/Dashbord.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Dashbord.cshtml", typeof(AspNetCore.Views_Home_Dashbord))]
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
#line 1 "D:\Coding_Dojo_C#\fullSTACK\c_sharp_proj\Views\_ViewImports.cshtml"
using c_sharp_proj;

#line default
#line hidden
#line 2 "D:\Coding_Dojo_C#\fullSTACK\c_sharp_proj\Views\_ViewImports.cshtml"
using c_sharp_proj.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"696a39b30a6fc9309b22925053ca2e664e7e477b", @"/Views/Home/Dashbord.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48107781bd49e22ca2f4216b1ccbe50d1901f444", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashbord : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 593, true);
            WriteLiteral(@"
  <div class=""row"">
      <h1 class=""col-10"">Dojo Activity Center</h1>
      <a class =""col"" href=""/clear"">LOG OUT</a>
  </div>
  <div class=""row"">
    <div class=""col"">
      <table class=""table"">
        <thead class=""thead-dark"">
          <tr>
            <th scope=""col"">Activity</th>
            <th scope=""col"">Date and Time</th>
            <th scope=""col"">Duration</th>
            <th scope=""col"">Event Coordinator</th>
            <th scope=""col"">No. of Participants</th>
            <th scope=""col"">Actions</th>
          </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 20 "D:\Coding_Dojo_C#\fullSTACK\c_sharp_proj\Views\Home\Dashbord.cshtml"
             foreach(_Activity i in @ViewBag.all_activities)
            {

#line default
#line hidden
            BeginContext(670, 34, true);
            WriteLiteral("          <tr>\r\n            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 704, "\"", 739, 2);
            WriteAttributeValue("", 711, "/INFOActivity/", 711, 14, true);
#line 23 "D:\Coding_Dojo_C#\fullSTACK\c_sharp_proj\Views\Home\Dashbord.cshtml"
WriteAttributeValue("", 725, i._ActivityId, 725, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(740, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(742, 7, false);
#line 23 "D:\Coding_Dojo_C#\fullSTACK\c_sharp_proj\Views\Home\Dashbord.cshtml"
                                                  Write(i.Title);

#line default
#line hidden
            EndContext();
            BeginContext(749, 27, true);
            WriteLiteral("</a></td>\r\n            <td>");
            EndContext();
            BeginContext(777, 24, false);
#line 24 "D:\Coding_Dojo_C#\fullSTACK\c_sharp_proj\Views\Home\Dashbord.cshtml"
           Write(i.Date.ToString("dd/MM"));

#line default
#line hidden
            EndContext();
            BeginContext(801, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(803, 3, true);
            WriteLiteral("@  ");
            EndContext();
            BeginContext(807, 27, false);
#line 24 "D:\Coding_Dojo_C#\fullSTACK\c_sharp_proj\Views\Home\Dashbord.cshtml"
                                         Write(i.Time.ToString("hh:mm tt"));

#line default
#line hidden
            EndContext();
            BeginContext(834, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(858, 10, false);
#line 25 "D:\Coding_Dojo_C#\fullSTACK\c_sharp_proj\Views\Home\Dashbord.cshtml"
           Write(i.Duration);

#line default
#line hidden
            EndContext();
            BeginContext(868, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(870, 5, false);
#line 25 "D:\Coding_Dojo_C#\fullSTACK\c_sharp_proj\Views\Home\Dashbord.cshtml"
                       Write(i.HDW);

#line default
#line hidden
            EndContext();
            BeginContext(875, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(899, 16, false);
#line 26 "D:\Coding_Dojo_C#\fullSTACK\c_sharp_proj\Views\Home\Dashbord.cshtml"
           Write(i.User.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(915, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(939, 20, false);
#line 27 "D:\Coding_Dojo_C#\fullSTACK\c_sharp_proj\Views\Home\Dashbord.cshtml"
           Write(i.Associations.Count);

#line default
#line hidden
            EndContext();
            BeginContext(959, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 28 "D:\Coding_Dojo_C#\fullSTACK\c_sharp_proj\Views\Home\Dashbord.cshtml"
             if(@i.User.UserId == @ViewBag.user_id)
            {

#line default
#line hidden
            BeginContext(1034, 18, true);
            WriteLiteral("            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1052, "\"", 1089, 2);
            WriteAttributeValue("", 1059, "/deleteActivity/", 1059, 16, true);
#line 30 "D:\Coding_Dojo_C#\fullSTACK\c_sharp_proj\Views\Home\Dashbord.cshtml"
WriteAttributeValue("", 1075, i._ActivityId, 1075, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1090, 18, true);
            WriteLiteral(">Delete</a></td>\r\n");
            EndContext();
#line 31 "D:\Coding_Dojo_C#\fullSTACK\c_sharp_proj\Views\Home\Dashbord.cshtml"
            }
            else
            {
              

#line default
#line hidden
#line 34 "D:\Coding_Dojo_C#\fullSTACK\c_sharp_proj\Views\Home\Dashbord.cshtml"
               if(@i.Associations.Any(a => a.UserId == @ViewBag.user_id))
              {

#line default
#line hidden
            BeginContext(1248, 49, true);
            WriteLiteral("                <td><a href=\"#\">Cancel</a></td>\r\n");
            EndContext();
#line 37 "D:\Coding_Dojo_C#\fullSTACK\c_sharp_proj\Views\Home\Dashbord.cshtml"
              }
              else
              {

#line default
#line hidden
            BeginContext(1351, 47, true);
            WriteLiteral("                <td><a href=\"#\">Join</a></td>\r\n");
            EndContext();
#line 41 "D:\Coding_Dojo_C#\fullSTACK\c_sharp_proj\Views\Home\Dashbord.cshtml"
              }

#line default
#line hidden
#line 41 "D:\Coding_Dojo_C#\fullSTACK\c_sharp_proj\Views\Home\Dashbord.cshtml"
               
            }

#line default
#line hidden
            BeginContext(1430, 17, true);
            WriteLiteral("          </tr>\r\n");
            EndContext();
#line 44 "D:\Coding_Dojo_C#\fullSTACK\c_sharp_proj\Views\Home\Dashbord.cshtml"
            }

#line default
#line hidden
            BeginContext(1462, 218, true);
            WriteLiteral("        </tbody>\r\n      </table>\r\n    </div>\r\n  </div>\r\n  <div class=\"row\">\r\n    <div class=\"col text-right\">\r\n    <button><a href=\"/createActivity\" class=\"text-dark\">Add New Activity</a></button>\r\n    </div>\r\n  </div>");
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
