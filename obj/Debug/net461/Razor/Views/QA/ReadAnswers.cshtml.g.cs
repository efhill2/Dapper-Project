#pragma checksum "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\ReadAnswers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8f6e0f62a50e07ea5c0425e7415995e6fe67954"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_QA_ReadAnswers), @"mvc.1.0.view", @"/Views/QA/ReadAnswers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/QA/ReadAnswers.cshtml", typeof(AspNetCore.Views_QA_ReadAnswers))]
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
#line 1 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\_ViewImports.cshtml"
using Dapper_Project;

#line default
#line hidden
#line 2 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\_ViewImports.cshtml"
using Dapper_Project.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8f6e0f62a50e07ea5c0425e7415995e6fe67954", @"/Views/QA/ReadAnswers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5e5a985084eba6a87f5f5a7756ec7c1601d37e2", @"/Views/_ViewImports.cshtml")]
    public class Views_QA_ReadAnswers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Thread>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(15, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\ReadAnswers.cshtml"
  
    ViewData["Title"] = "ReadAnswers";

#line default
#line hidden
            BeginContext(64, 31, true);
            WriteLiteral("\r\n<h2>Read Answers</h2>\r\n\r\n<h3>");
            EndContext();
            BeginContext(96, 13, false);
#line 9 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\ReadAnswers.cshtml"
Write(Model.Q.Title);

#line default
#line hidden
            EndContext();
            BeginContext(109, 22, true);
            WriteLiteral("</h3>\r\n<h4>Posted by: ");
            EndContext();
            BeginContext(132, 16, false);
#line 10 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\ReadAnswers.cshtml"
          Write(Model.Q.Username);

#line default
#line hidden
            EndContext();
            BeginContext(148, 21, true);
            WriteLiteral("</h4>\r\n<h6>Category: ");
            EndContext();
            BeginContext(170, 16, false);
#line 11 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\ReadAnswers.cshtml"
         Write(Model.Q.Category);

#line default
#line hidden
            EndContext();
            BeginContext(186, 18, true);
            WriteLiteral("</h6>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(205, 14, false);
#line 14 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\ReadAnswers.cshtml"
Write(Model.Q.Detail);

#line default
#line hidden
            EndContext();
            BeginContext(219, 30, true);
            WriteLiteral("\r\n</p>\r\n\r\nAnswers:\r\n<br />\r\n<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 249, "\"", 286, 2);
            WriteAttributeValue("", 256, "/QA/WriteAnswer?id=", 256, 19, true);
#line 19 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\ReadAnswers.cshtml"
WriteAttributeValue("", 275, Model.Q.ID, 275, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(287, 43, true);
            WriteLiteral("> Add an Answer:  </a>\r\n<br />\r\n<table>\r\n\r\n");
            EndContext();
#line 23 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\ReadAnswers.cshtml"
     foreach (Answers a in Model.A)
    {

#line default
#line hidden
            BeginContext(374, 45, true);
            WriteLiteral("    <tr>\r\n        <td>\r\n            Upvotes: ");
            EndContext();
            BeginContext(420, 9, false);
#line 27 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\ReadAnswers.cshtml"
                Write(a.UpVotes);

#line default
#line hidden
            EndContext();
            BeginContext(429, 45, true);
            WriteLiteral("\r\n        </td>\r\n\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(475, 8, false);
#line 31 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\ReadAnswers.cshtml"
       Write(a.Detail);

#line default
#line hidden
            EndContext();
            BeginContext(483, 58, true);
            WriteLiteral("\r\n\r\n        </td>\r\n\r\n        <td>\r\n            Posted by: ");
            EndContext();
            BeginContext(542, 10, false);
#line 36 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\ReadAnswers.cshtml"
                  Write(a.Username);

#line default
#line hidden
            EndContext();
            BeginContext(552, 56, true);
            WriteLiteral("\r\n        </td>\r\n\r\n        <td>\r\n            Posted at: ");
            EndContext();
            BeginContext(609, 8, false);
#line 40 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\ReadAnswers.cshtml"
                  Write(a.Posted);

#line default
#line hidden
            EndContext();
            BeginContext(617, 17, true);
            WriteLiteral("\r\n        </td>\r\n");
            EndContext();
#line 42 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\ReadAnswers.cshtml"
         if (ViewBag.username == a.Username || ViewBag.username == Model.Q.Username)
        {

#line default
#line hidden
            BeginContext(731, 36, true);
            WriteLiteral("            <td>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 767, "\"", 803, 2);
            WriteAttributeValue("", 774, "/QA/RemoveAnswer?thisID=", 774, 24, true);
#line 45 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\ReadAnswers.cshtml"
WriteAttributeValue("", 798, a.ID, 798, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(804, 32, true);
            WriteLiteral(">Delete</a>\r\n            </td>\r\n");
            EndContext();
#line 47 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\ReadAnswers.cshtml"
        }

#line default
#line hidden
            BeginContext(847, 15, true);
            WriteLiteral("        </tr>\r\n");
            EndContext();
#line 49 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\ReadAnswers.cshtml"

    }

#line default
#line hidden
            BeginContext(871, 14, true);
            WriteLiteral("\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Thread> Html { get; private set; }
    }
}
#pragma warning restore 1591