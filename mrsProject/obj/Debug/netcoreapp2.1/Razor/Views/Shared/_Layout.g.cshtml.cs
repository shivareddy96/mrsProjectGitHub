#pragma checksum "C:\Users\Public\Documents\mrsProjectGitHub\mrsProject\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e3ecb6388adc6c917b004d2fd0c2d05bfa0d723"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
#line 1 "C:\Users\Public\Documents\mrsProjectGitHub\mrsProject\Views\Shared\_Layout.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e3ecb6388adc6c917b004d2fd0c2d05bfa0d723", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/twitter-bootstrap/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/twitter-bootstrap/js/bootstrap.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(95, 27, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(122, 249, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a832c8f806ff492094e109cd78581949", async() => {
                BeginContext(128, 119, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>");
                EndContext();
                BeginContext(248, 13, false);
#line 9 "C:\Users\Public\Documents\mrsProjectGitHub\mrsProject\Views\Shared\_Layout.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
                EndContext();
                BeginContext(261, 27, true);
                WriteLiteral(" - Food Truck</title>\r\n    ");
                EndContext();
                BeginContext(288, 74, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8f0400da074e42c6b0181a029c82868d", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(362, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(371, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(373, 2544, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9499eef5234f40479395e6439639c6fa", async() => {
                BeginContext(379, 540, true);
                WriteLiteral(@"
    <div>
        <nav class=""navbar navbar-expand-lg navbar-dark bg-primary"">
            <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#nav-content"" aria-controls=""nav-content"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon""></span>
            </button>
            <div class=""collapse navbar-collapse"" id=""nav-content"">
                <ul class=""navbar-nav mr-auto"">
                    <li class=""nav-item"">
                        ");
                EndContext();
                BeginContext(920, 75, false);
#line 21 "C:\Users\Public\Documents\mrsProjectGitHub\mrsProject\Views\Shared\_Layout.cshtml"
                   Write(Html.ActionLink("Home", "Index", "Home", null, new { @class = "nav-link" }));

#line default
#line hidden
                EndContext();
                BeginContext(995, 96, true);
                WriteLiteral("\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        ");
                EndContext();
                BeginContext(1092, 78, false);
#line 24 "C:\Users\Public\Documents\mrsProjectGitHub\mrsProject\Views\Shared\_Layout.cshtml"
                   Write(Html.ActionLink("Books", "Index", "Search", null, new { @class = "nav-link" }));

#line default
#line hidden
                EndContext();
                BeginContext(1170, 96, true);
                WriteLiteral("\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        ");
                EndContext();
                BeginContext(1267, 82, false);
#line 27 "C:\Users\Public\Documents\mrsProjectGitHub\mrsProject\Views\Shared\_Layout.cshtml"
                   Write(Html.ActionLink("Coupons", "Index", "Discount", null, new { @class = "nav-link" }));

#line default
#line hidden
                EndContext();
                BeginContext(1349, 31, true);
                WriteLiteral("\r\n                    </li>\r\n\r\n");
                EndContext();
#line 30 "C:\Users\Public\Documents\mrsProjectGitHub\mrsProject\Views\Shared\_Layout.cshtml"
                     if (User.Identity.IsAuthenticated)
                    {


#line default
#line hidden
                BeginContext(1462, 75, true);
                WriteLiteral("                        <li class=\"nav-item\">\r\n                            ");
                EndContext();
                BeginContext(1538, 79, false);
#line 34 "C:\Users\Public\Documents\mrsProjectGitHub\mrsProject\Views\Shared\_Layout.cshtml"
                       Write(Html.ActionLink("Orders", "Index", "Orders", null, new { @class = "nav-link" }));

#line default
#line hidden
                EndContext();
                BeginContext(1617, 33, true);
                WriteLiteral("\r\n                        </li>\r\n");
                EndContext();
#line 36 "C:\Users\Public\Documents\mrsProjectGitHub\mrsProject\Views\Shared\_Layout.cshtml"

                        if (User.IsInRole("Manager"))
                        {

#line default
#line hidden
                BeginContext(1734, 83, true);
                WriteLiteral("                            <li class=\"nav-item\">\r\n                                ");
                EndContext();
                BeginContext(1818, 85, false);
#line 40 "C:\Users\Public\Documents\mrsProjectGitHub\mrsProject\Views\Shared\_Layout.cshtml"
                           Write(Html.ActionLink("Suppliers", "Index", "Suppliers", null, new { @class = "nav-link" }));

#line default
#line hidden
                EndContext();
                BeginContext(1903, 120, true);
                WriteLiteral("\r\n                            </li>\r\n                            <li class=\"nav-item\">\r\n                                ");
                EndContext();
                BeginContext(2024, 88, false);
#line 43 "C:\Users\Public\Documents\mrsProjectGitHub\mrsProject\Views\Shared\_Layout.cshtml"
                           Write(Html.ActionLink("Manage Users", "Index", "RoleAdmin", null, new { @class = "nav-link" }));

#line default
#line hidden
                EndContext();
                BeginContext(2112, 37, true);
                WriteLiteral("\r\n                            </li>\r\n");
                EndContext();
#line 45 "C:\Users\Public\Documents\mrsProjectGitHub\mrsProject\Views\Shared\_Layout.cshtml"
                        }

                    }
                    else
                    {

#line default
#line hidden
                BeginContext(2250, 75, true);
                WriteLiteral("                        <li class=\"nav-item\">\r\n                            ");
                EndContext();
                BeginContext(2326, 80, false);
#line 51 "C:\Users\Public\Documents\mrsProjectGitHub\mrsProject\Views\Shared\_Layout.cshtml"
                       Write(Html.ActionLink("Log In", "Index", "Account", null, new { @class = "nav-link" }));

#line default
#line hidden
                EndContext();
                BeginContext(2406, 33, true);
                WriteLiteral("\r\n                        </li>\r\n");
                EndContext();
#line 53 "C:\Users\Public\Documents\mrsProjectGitHub\mrsProject\Views\Shared\_Layout.cshtml"
                    }

#line default
#line hidden
                BeginContext(2462, 55, true);
                WriteLiteral("                </ul>\r\n            </div>\r\n            ");
                EndContext();
                BeginContext(2518, 40, false);
#line 56 "C:\Users\Public\Documents\mrsProjectGitHub\mrsProject\Views\Shared\_Layout.cshtml"
       Write(await Html.PartialAsync("_LoginPartial"));

#line default
#line hidden
                EndContext();
                BeginContext(2558, 82, true);
                WriteLiteral("\r\n        </nav>\r\n    </div>\r\n\r\n    <div class=\"container body-content\">\r\n        ");
                EndContext();
                BeginContext(2641, 12, false);
#line 61 "C:\Users\Public\Documents\mrsProjectGitHub\mrsProject\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(2653, 58, true);
                WriteLiteral("\r\n        <hr />\r\n        <footer>\r\n            <p>&copy; ");
                EndContext();
                BeginContext(2712, 17, false);
#line 64 "C:\Users\Public\Documents\mrsProjectGitHub\mrsProject\Views\Shared\_Layout.cshtml"
                 Write(DateTime.Now.Year);

#line default
#line hidden
                EndContext();
                BeginContext(2729, 64, true);
                WriteLiteral(" - BevoSoft Consultants</p>\r\n        </footer>\r\n    </div>\r\n    ");
                EndContext();
                BeginContext(2793, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0227dd0b316f4ebeb98c85cbdaa98d35", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2839, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2845, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d598b0779564b0ab8381eb2e32d814b", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2908, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2917, 9, true);
            WriteLiteral("\r\n</html>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAuthorizationService AuthorizationService { get; private set; }
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
