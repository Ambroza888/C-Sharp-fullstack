#pragma checksum "D:\Coding_Dojo_C#\fullSTACK\TheWall\Views\Home\Success.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b76b430a56ed9a6f1f0d11a70e89a3f84fa7833d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Success), @"mvc.1.0.view", @"/Views/Home/Success.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Success.cshtml", typeof(AspNetCore.Views_Home_Success))]
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
#line 1 "D:\Coding_Dojo_C#\fullSTACK\TheWall\Views\_ViewImports.cshtml"
using TheWall;

#line default
#line hidden
#line 2 "D:\Coding_Dojo_C#\fullSTACK\TheWall\Views\_ViewImports.cshtml"
using TheWall.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b76b430a56ed9a6f1f0d11a70e89a3f84fa7833d", @"/Views/Home/Success.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d202197c3bfd1895a7b2b59f7940dc9c3d32218c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Success : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Comment>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "PartialMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cols", new global::Microsoft.AspNetCore.Html.HtmlString("90"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rows", new global::Microsoft.AspNetCore.Html.HtmlString("2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/PostComment"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(16, 190, true);
            WriteLiteral("<h1 class=\"text-center\">Success</h1>\r\n<div class=\"row\">\r\n<a class =\"col text-center\" style=\"font-size:40px;\" href=\"/clear\">LOG OUT</a>\r\n</div>\r\n\r\n<div class=\"row\">\r\n  <div class=\"col\">\r\n    ");
            EndContext();
            BeginContext(206, 31, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b76b430a56ed9a6f1f0d11a70e89a3f84fa7833d6319", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(237, 12, true);
            WriteLiteral("</partial>\r\n");
            EndContext();
#line 10 "D:\Coding_Dojo_C#\fullSTACK\TheWall\Views\Home\Success.cshtml"
     foreach(Message i in @ViewBag.allmessages)
    {
      if(i.UserId == @ViewBag.user_id)
        {

#line default
#line hidden
            BeginContext(356, 59, true);
            WriteLiteral("        <div class=\"col text-center\">\r\n          <button><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 415, "\"", 444, 3);
            WriteAttributeValue("", 422, "/Delete/{", 422, 9, true);
#line 15 "D:\Coding_Dojo_C#\fullSTACK\TheWall\Views\Home\Success.cshtml"
WriteAttributeValue("", 431, i.MessageId, 431, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 443, "}", 443, 1, true);
            EndWriteAttribute();
            BeginContext(445, 38, true);
            WriteLiteral(">Delete</a></button>\r\n        </div>\r\n");
            EndContext();
#line 17 "D:\Coding_Dojo_C#\fullSTACK\TheWall\Views\Home\Success.cshtml"
        }

#line default
#line hidden
            BeginContext(494, 12, true);
            WriteLiteral("        <h6>");
            EndContext();
            BeginContext(507, 16, false);
#line 18 "D:\Coding_Dojo_C#\fullSTACK\TheWall\Views\Home\Success.cshtml"
       Write(i.User.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(523, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(525, 15, false);
#line 18 "D:\Coding_Dojo_C#\fullSTACK\TheWall\Views\Home\Success.cshtml"
                         Write(i.User.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(540, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(544, 35, false);
#line 18 "D:\Coding_Dojo_C#\fullSTACK\TheWall\Views\Home\Success.cshtml"
                                            Write(i.CreatedAt.ToString("MMM dd yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(579, 19, true);
            WriteLiteral("</h6>\r\n        <h4>");
            EndContext();
            BeginContext(599, 13, false);
#line 19 "D:\Coding_Dojo_C#\fullSTACK\TheWall\Views\Home\Success.cshtml"
       Write(i.MessageText);

#line default
#line hidden
            EndContext();
            BeginContext(612, 7, true);
            WriteLiteral("</h4>\r\n");
            EndContext();
#line 20 "D:\Coding_Dojo_C#\fullSTACK\TheWall\Views\Home\Success.cshtml"
          if(i.Comments != null)
          {
            

#line default
#line hidden
#line 22 "D:\Coding_Dojo_C#\fullSTACK\TheWall\Views\Home\Success.cshtml"
             foreach(Comment j in i.Comments)
            {

#line default
#line hidden
            BeginContext(728, 15, true);
            WriteLiteral("            <p>");
            EndContext();
            BeginContext(744, 16, false);
#line 24 "D:\Coding_Dojo_C#\fullSTACK\TheWall\Views\Home\Success.cshtml"
          Write(j.User.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(760, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(762, 15, false);
#line 24 "D:\Coding_Dojo_C#\fullSTACK\TheWall\Views\Home\Success.cshtml"
                            Write(j.User.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(777, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(779, 35, false);
#line 24 "D:\Coding_Dojo_C#\fullSTACK\TheWall\Views\Home\Success.cshtml"
                                             Write(j.CreatedAt.ToString("MMM dd yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(814, 43, true);
            WriteLiteral("</p> \r\n            <ol>\r\n              <li>");
            EndContext();
            BeginContext(858, 13, false);
#line 26 "D:\Coding_Dojo_C#\fullSTACK\TheWall\Views\Home\Success.cshtml"
             Write(j.CommentText);

#line default
#line hidden
            EndContext();
            BeginContext(871, 26, true);
            WriteLiteral("</li>\r\n            </ol>\r\n");
            EndContext();
#line 28 "D:\Coding_Dojo_C#\fullSTACK\TheWall\Views\Home\Success.cshtml"
            }

#line default
#line hidden
#line 28 "D:\Coding_Dojo_C#\fullSTACK\TheWall\Views\Home\Success.cshtml"
             
          }

#line default
#line hidden
            BeginContext(925, 83, true);
            WriteLiteral("        <div class=\"col ml-5\">\r\n              <p>Post a Comment</p>\r\n              ");
            EndContext();
            BeginContext(1008, 534, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b76b430a56ed9a6f1f0d11a70e89a3f84fa7833d12351", async() => {
                BeginContext(1050, 23, true);
                WriteLiteral("\r\n                  <p>");
                EndContext();
                BeginContext(1073, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b76b430a56ed9a6f1f0d11a70e89a3f84fa7833d12757", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#line 33 "D:\Coding_Dojo_C#\fullSTACK\TheWall\Views\Home\Success.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CommentText);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1139, 24, true);
                WriteLiteral("</p>\r\n                  ");
                EndContext();
                BeginContext(1163, 62, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b76b430a56ed9a6f1f0d11a70e89a3f84fa7833d14534", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
#line 34 "D:\Coding_Dojo_C#\fullSTACK\TheWall\Views\Home\Success.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CommentText);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1225, 20, true);
                WriteLiteral("\r\n                  ");
                EndContext();
                BeginContext(1245, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b76b430a56ed9a6f1f0d11a70e89a3f84fa7833d16342", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#line 35 "D:\Coding_Dojo_C#\fullSTACK\TheWall\Views\Home\Success.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.UserId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 35 "D:\Coding_Dojo_C#\fullSTACK\TheWall\Views\Home\Success.cshtml"
                                                   WriteLiteral(ViewBag.user_id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1308, 20, true);
                WriteLiteral("\r\n                  ");
                EndContext();
                BeginContext(1328, 62, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b76b430a56ed9a6f1f0d11a70e89a3f84fa7833d18808", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#line 36 "D:\Coding_Dojo_C#\fullSTACK\TheWall\Views\Home\Success.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.MessageId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 36 "D:\Coding_Dojo_C#\fullSTACK\TheWall\Views\Home\Success.cshtml"
                                                      WriteLiteral(i.MessageId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1390, 145, true);
                WriteLiteral("\r\n                  <p>\r\n                    <input class=\"bg-success\" type=\"submit\" value= \"Post a Comment\">\r\n                  </p>\r\n          ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1542, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 42 "D:\Coding_Dojo_C#\fullSTACK\TheWall\Views\Home\Success.cshtml"
    }

#line default
#line hidden
            BeginContext(1567, 16, true);
            WriteLiteral("  </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Comment> Html { get; private set; }
    }
}
#pragma warning restore 1591
