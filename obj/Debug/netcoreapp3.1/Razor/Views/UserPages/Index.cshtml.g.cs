#pragma checksum "D:\Users\JJWes\Documents\GitHub\CSD412_Group5\Views\UserPages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5906e845de3171cc19ab7c221d8a0bb42e48602e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserPages_Index), @"mvc.1.0.view", @"/Views/UserPages/Index.cshtml")]
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
#line 1 "D:\Users\JJWes\Documents\GitHub\CSD412_Group5\Views\_ViewImports.cshtml"
using GroupAssignment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\JJWes\Documents\GitHub\CSD412_Group5\Views\_ViewImports.cshtml"
using GroupAssignment.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5906e845de3171cc19ab7c221d8a0bb42e48602e", @"/Views/UserPages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a00e2efd7cb123062f31e48dca1d6a074f4ab0ba", @"/Views/_ViewImports.cshtml")]
    public class Views_UserPages_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserPagesViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Users\JJWes\Documents\GitHub\CSD412_Group5\Views\UserPages\Index.cshtml"
  
    ViewData["Title"] = "User Pages";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">User Pages</h1>\r\n\r\n</div>\r\n\r\n\r\n<ul>\r\n");
#nullable restore
#line 13 "D:\Users\JJWes\Documents\GitHub\CSD412_Group5\Views\UserPages\Index.cshtml"
     for (int i = 0; i < Model.Pages.Count; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>\r\n            Title: ");
#nullable restore
#line 16 "D:\Users\JJWes\Documents\GitHub\CSD412_Group5\Views\UserPages\Index.cshtml"
              Write(Model.Pages[i].Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <br/>\r\n");
#nullable restore
#line 18 "D:\Users\JJWes\Documents\GitHub\CSD412_Group5\Views\UserPages\Index.cshtml"
             for (int j = 0; j < Model.Pages[i].PageContent.Count; j++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("               <nobr>Content ");
#nullable restore
#line 20 "D:\Users\JJWes\Documents\GitHub\CSD412_Group5\Views\UserPages\Index.cshtml"
                        Write(j.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(":</nobr> ");
#nullable restore
#line 20 "D:\Users\JJWes\Documents\GitHub\CSD412_Group5\Views\UserPages\Index.cshtml"
                                              Write(Model.Pages[i].PageContent[j].ToHtml());

#line default
#line hidden
#nullable disable
            WriteLiteral("               <br/>\r\n");
#nullable restore
#line 22 "D:\Users\JJWes\Documents\GitHub\CSD412_Group5\Views\UserPages\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </li>\r\n");
#nullable restore
#line 24 "D:\Users\JJWes\Documents\GitHub\CSD412_Group5\Views\UserPages\Index.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserPagesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
