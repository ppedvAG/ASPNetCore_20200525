#pragma checksum "C:\Meine Kurse\ASPNetCore_20200525\AspNetCore_Schulung\AspNetCore_MVC\Views\DynamicView\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0935c97f45761445cc2a9216af7c3d04c2352594"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DynamicView_Index), @"mvc.1.0.view", @"/Views/DynamicView/Index.cshtml")]
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
#line 1 "C:\Meine Kurse\ASPNetCore_20200525\AspNetCore_Schulung\AspNetCore_MVC\Views\_ViewImports.cshtml"
using AspNetCore_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Meine Kurse\ASPNetCore_20200525\AspNetCore_Schulung\AspNetCore_MVC\Views\DynamicView\Index.cshtml"
using AspNetCore_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0935c97f45761445cc2a9216af7c3d04c2352594", @"/Views/DynamicView/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82a0962e4b70bba6118845b54d580015c7130d2e", @"/Views/_ViewImports.cshtml")]
    public class Views_DynamicView_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Meine Kurse\ASPNetCore_20200525\AspNetCore_Schulung\AspNetCore_MVC\Views\DynamicView\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<h1>DynamicViewSample</h1>\r\n\r\n<table>\r\n    <tr>\r\n        <th>Title</th>\r\n        <th>Content</th>\r\n    </tr>\r\n");
#nullable restore
#line 16 "C:\Meine Kurse\ASPNetCore_20200525\AspNetCore_Schulung\AspNetCore_MVC\Views\DynamicView\Index.cshtml"
     foreach (Blog currentBlog in Model.Blogs)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 19 "C:\Meine Kurse\ASPNetCore_20200525\AspNetCore_Schulung\AspNetCore_MVC\Views\DynamicView\Index.cshtml"
           Write(currentBlog.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 20 "C:\Meine Kurse\ASPNetCore_20200525\AspNetCore_Schulung\AspNetCore_MVC\Views\DynamicView\Index.cshtml"
           Write(currentBlog.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 22 "C:\Meine Kurse\ASPNetCore_20200525\AspNetCore_Schulung\AspNetCore_MVC\Views\DynamicView\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n<h2>Comments List</h2>\r\n\r\n<table>\r\n    <tr>\r\n        <th>Id</th>\r\n        <th>Name</th>\r\n    </tr>\r\n");
#nullable restore
#line 32 "C:\Meine Kurse\ASPNetCore_20200525\AspNetCore_Schulung\AspNetCore_MVC\Views\DynamicView\Index.cshtml"
     foreach (Comment currentComment in Model.Comments)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 35 "C:\Meine Kurse\ASPNetCore_20200525\AspNetCore_Schulung\AspNetCore_MVC\Views\DynamicView\Index.cshtml"
           Write(currentComment.CreatedBy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 36 "C:\Meine Kurse\ASPNetCore_20200525\AspNetCore_Schulung\AspNetCore_MVC\Views\DynamicView\Index.cshtml"
           Write(Html.Raw(currentComment.Text));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 38 "C:\Meine Kurse\ASPNetCore_20200525\AspNetCore_Schulung\AspNetCore_MVC\Views\DynamicView\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
