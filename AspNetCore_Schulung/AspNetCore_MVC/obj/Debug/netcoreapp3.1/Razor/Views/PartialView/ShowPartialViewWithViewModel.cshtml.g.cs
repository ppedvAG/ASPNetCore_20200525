#pragma checksum "C:\Meine Kurse\ASPNetCore_20200525\AspNetCore_Schulung\AspNetCore_MVC\Views\PartialView\ShowPartialViewWithViewModel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f946daf54a3ecf2bc56a442ff4e1a2981bcf1ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PartialView_ShowPartialViewWithViewModel), @"mvc.1.0.view", @"/Views/PartialView/ShowPartialViewWithViewModel.cshtml")]
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
#line 2 "C:\Meine Kurse\ASPNetCore_20200525\AspNetCore_Schulung\AspNetCore_MVC\Views\_ViewImports.cshtml"
using AspNetCore_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f946daf54a3ecf2bc56a442ff4e1a2981bcf1ef", @"/Views/PartialView/ShowPartialViewWithViewModel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82a0962e4b70bba6118845b54d580015c7130d2e", @"/Views/_ViewImports.cshtml")]
    public class Views_PartialView_ShowPartialViewWithViewModel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AspNetCore_MVC.ViewModels.BlogCommentViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ShowComments", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Meine Kurse\ASPNetCore_20200525\AspNetCore_Schulung\AspNetCore_MVC\Views\PartialView\ShowPartialViewWithViewModel.cshtml"
  
    ViewData["Title"] = "ShowPartialViewWithViewModel";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <h1>ShowPartialViewWithViewModel</h1>\r\n\r\n<ul>\r\n");
#nullable restore
#line 10 "C:\Meine Kurse\ASPNetCore_20200525\AspNetCore_Schulung\AspNetCore_MVC\Views\PartialView\ShowPartialViewWithViewModel.cshtml"
     foreach (var item in Model.Blogs)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>\r\n            Titel: ");
#nullable restore
#line 13 "C:\Meine Kurse\ASPNetCore_20200525\AspNetCore_Schulung\AspNetCore_MVC\Views\PartialView\ShowPartialViewWithViewModel.cshtml"
              Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n        </li>\r\n");
#nullable restore
#line 15 "C:\Meine Kurse\ASPNetCore_20200525\AspNetCore_Schulung\AspNetCore_MVC\Views\PartialView\ShowPartialViewWithViewModel.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6f946daf54a3ecf2bc56a442ff4e1a2981bcf1ef4846", async() => {
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
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AspNetCore_MVC.ViewModels.BlogCommentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
