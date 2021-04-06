#pragma checksum "C:\Users\adria\source\repos\BowlingLeague\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec5787cc68ee7034e5ad761be9d4d4858fdf5397"
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
#line 1 "C:\Users\adria\source\repos\BowlingLeague\Views\_ViewImports.cshtml"
using BowlingLeague;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\adria\source\repos\BowlingLeague\Views\_ViewImports.cshtml"
using BowlingLeague.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\adria\source\repos\BowlingLeague\Views\_ViewImports.cshtml"
using BowlingLeague.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec5787cc68ee7034e5ad761be9d4d4858fdf5397", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47002de435f25c4c92ea6082ca54d82a636e2531", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class", "btn", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-selected", "btn-primary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-group pull-right m-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::BowlingLeague.Infrastructure.PaginationTagHelper __BowlingLeague_Infrastructure_PaginationTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\adria\source\repos\BowlingLeague\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"container\">\r\n        <h1>Bowling League Contact List</h1>\r\n        <h2>");
#nullable restore
#line 8 "C:\Users\adria\source\repos\BowlingLeague\Views\Home\Index.cshtml"
       Write(Model.TeamCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
        <table class=""table table-striped"">
            <thead>
                <tr>
                    <th scope=""col"">First Name</th>
                    <th scope=""col"">Middle Init.</th>
                    <th scope=""col"">Last Name</th>
                    <th scope=""col"">Address</th>
                    <th scope=""col"">City</th>
                    <th scope=""col"">State</th>
                    <th scope=""col"">Zip</th>
                    <th scope=""col"">Phone</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 23 "C:\Users\adria\source\repos\BowlingLeague\Views\Home\Index.cshtml"
                 foreach (var bl in Model.Bowlers)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 26 "C:\Users\adria\source\repos\BowlingLeague\Views\Home\Index.cshtml"
                       Write(bl.BowlerFirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 27 "C:\Users\adria\source\repos\BowlingLeague\Views\Home\Index.cshtml"
                       Write(bl.BowlerMiddleInit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 28 "C:\Users\adria\source\repos\BowlingLeague\Views\Home\Index.cshtml"
                       Write(bl.BowlerLastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 29 "C:\Users\adria\source\repos\BowlingLeague\Views\Home\Index.cshtml"
                       Write(bl.BowlerAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 30 "C:\Users\adria\source\repos\BowlingLeague\Views\Home\Index.cshtml"
                       Write(bl.BowlerCity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 31 "C:\Users\adria\source\repos\BowlingLeague\Views\Home\Index.cshtml"
                       Write(bl.BowlerState);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 32 "C:\Users\adria\source\repos\BowlingLeague\Views\Home\Index.cshtml"
                       Write(bl.BowlerZip);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 33 "C:\Users\adria\source\repos\BowlingLeague\Views\Home\Index.cshtml"
                       Write(bl.BowlerPhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 35 "C:\Users\adria\source\repos\BowlingLeague\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </tbody>\r\n        </table>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec5787cc68ee7034e5ad761be9d4d4858fdf53977941", async() => {
            }
            );
            __BowlingLeague_Infrastructure_PaginationTagHelper = CreateTagHelper<global::BowlingLeague.Infrastructure.PaginationTagHelper>();
            __tagHelperExecutionContext.Add(__BowlingLeague_Infrastructure_PaginationTagHelper);
#nullable restore
#line 39 "C:\Users\adria\source\repos\BowlingLeague\Views\Home\Index.cshtml"
__BowlingLeague_Infrastructure_PaginationTagHelper.PageInfo = Model.PageNumberingInfo;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-info", __BowlingLeague_Infrastructure_PaginationTagHelper.PageInfo, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__BowlingLeague_Infrastructure_PaginationTagHelper.KeyValuePairs == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("page-url-team-category", "BowlingLeague.Infrastructure.PaginationTagHelper", "KeyValuePairs"));
            }
#nullable restore
#line 40 "C:\Users\adria\source\repos\BowlingLeague\Views\Home\Index.cshtml"
__BowlingLeague_Infrastructure_PaginationTagHelper.KeyValuePairs["team-category"] = Model.TeamCategory;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-url-team-category", __BowlingLeague_Infrastructure_PaginationTagHelper.KeyValuePairs["team-category"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 41 "C:\Users\adria\source\repos\BowlingLeague\Views\Home\Index.cshtml"
__BowlingLeague_Infrastructure_PaginationTagHelper.PageClassesEnabled = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-classes-enabled", __BowlingLeague_Infrastructure_PaginationTagHelper.PageClassesEnabled, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __BowlingLeague_Infrastructure_PaginationTagHelper.PageClass = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __BowlingLeague_Infrastructure_PaginationTagHelper.PageClassSelected = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
