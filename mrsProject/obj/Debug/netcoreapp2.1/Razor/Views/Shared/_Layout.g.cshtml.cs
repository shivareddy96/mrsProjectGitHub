#pragma checksum "C:\Users\Matthew\Documents\Fall_2018\MIS_333K\mrsProject\mrsProject\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a06e6e9b0c6215f81ab809dcf6f8d74fcbebdf2"
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
#line 1 "C:\Users\Matthew\Documents\Fall_2018\MIS_333K\mrsProject\mrsProject\Views\Shared\_Layout.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a06e6e9b0c6215f81ab809dcf6f8d74fcbebdf2", @"/Views/Shared/_Layout.cshtml")]
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b33dc1ae0d454571a57b31172640ba4b", async() => {
                BeginContext(128, 119, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>");
                EndContext();
                BeginContext(248, 13, false);
#line 9 "C:\Users\Matthew\Documents\Fall_2018\MIS_333K\mrsProject\mrsProject\Views\Shared\_Layout.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
                EndContext();
                BeginContext(261, 27, true);
                WriteLiteral(" - Food Truck</title>\r\n    ");
                EndContext();
                BeginContext(288, 74, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "48c529bf538648638f20c83868f9be42", async() => {
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
            BeginContext(373, 2365, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01682e60263048dc8510bd09d848c9d4", async() => {
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
#line 21 "C:\Users\Matthew\Documents\Fall_2018\MIS_333K\mrsProject\mrsProject\Views\Shared\_Layout.cshtml"
                   Write(Html.ActionLink("Home", "Index", "Home", null, new { @class = "nav-link" }));

#line default
#line hidden
                EndContext();
                BeginContext(995, 96, true);
                WriteLiteral("\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        ");
                EndContext();
                BeginContext(1092, 78, false);
#line 24 "C:\Users\Matthew\Documents\Fall_2018\MIS_333K\mrsProject\mrsProject\Views\Shared\_Layout.cshtml"
                   Write(Html.ActionLink("Books", "Index", "Search", null, new { @class = "nav-link" }));

#line default
#line hidden
                EndContext();
                BeginContext(1170, 31, true);
                WriteLiteral("\r\n                    </li>\r\n\r\n");
                EndContext();
#line 27 "C:\Users\Matthew\Documents\Fall_2018\MIS_333K\mrsProject\mrsProject\Views\Shared\_Layout.cshtml"
                     if (User.Identity.IsAuthenticated)
                    {


#line default
#line hidden
                BeginContext(1283, 75, true);
                WriteLiteral("                        <li class=\"nav-item\">\r\n                            ");
                EndContext();
                BeginContext(1359, 79, false);
#line 31 "C:\Users\Matthew\Documents\Fall_2018\MIS_333K\mrsProject\mrsProject\Views\Shared\_Layout.cshtml"
                       Write(Html.ActionLink("Orders", "Index", "Orders", null, new { @class = "nav-link" }));

#line default
#line hidden
                EndContext();
                BeginContext(1438, 33, true);
                WriteLiteral("\r\n                        </li>\r\n");
                EndContext();
#line 33 "C:\Users\Matthew\Documents\Fall_2018\MIS_333K\mrsProject\mrsProject\Views\Shared\_Layout.cshtml"

                        if (User.IsInRole("Manager"))
                        {

#line default
#line hidden
                BeginContext(1555, 83, true);
                WriteLiteral("                            <li class=\"nav-item\">\r\n                                ");
                EndContext();
                BeginContext(1639, 85, false);
#line 37 "C:\Users\Matthew\Documents\Fall_2018\MIS_333K\mrsProject\mrsProject\Views\Shared\_Layout.cshtml"
                           Write(Html.ActionLink("Suppliers", "Index", "Suppliers", null, new { @class = "nav-link" }));

#line default
#line hidden
                EndContext();
                BeginContext(1724, 120, true);
                WriteLiteral("\r\n                            </li>\r\n                            <li class=\"nav-item\">\r\n                                ");
                EndContext();
                BeginContext(1845, 88, false);
#line 40 "C:\Users\Matthew\Documents\Fall_2018\MIS_333K\mrsProject\mrsProject\Views\Shared\_Layout.cshtml"
                           Write(Html.ActionLink("Manage Users", "Index", "RoleAdmin", null, new { @class = "nav-link" }));

#line default
#line hidden
                EndContext();
                BeginContext(1933, 37, true);
                WriteLiteral("\r\n                            </li>\r\n");
                EndContext();
#line 42 "C:\Users\Matthew\Documents\Fall_2018\MIS_333K\mrsProject\mrsProject\Views\Shared\_Layout.cshtml"
                        }

                    }
                    else
                    {

#line default
#line hidden
                BeginContext(2071, 75, true);
                WriteLiteral("                        <li class=\"nav-item\">\r\n                            ");
                EndContext();
                BeginContext(2147, 80, false);
#line 48 "C:\Users\Matthew\Documents\Fall_2018\MIS_333K\mrsProject\mrsProject\Views\Shared\_Layout.cshtml"
                       Write(Html.ActionLink("Log In", "Index", "Account", null, new { @class = "nav-link" }));

#line default
#line hidden
                EndContext();
                BeginContext(2227, 33, true);
                WriteLiteral("\r\n                        </li>\r\n");
                EndContext();
#line 50 "C:\Users\Matthew\Documents\Fall_2018\MIS_333K\mrsProject\mrsProject\Views\Shared\_Layout.cshtml"
                    }

#line default
#line hidden
                BeginContext(2283, 55, true);
                WriteLiteral("                </ul>\r\n            </div>\r\n            ");
                EndContext();
                BeginContext(2339, 40, false);
#line 53 "C:\Users\Matthew\Documents\Fall_2018\MIS_333K\mrsProject\mrsProject\Views\Shared\_Layout.cshtml"
       Write(await Html.PartialAsync("_LoginPartial"));

#line default
#line hidden
                EndContext();
                BeginContext(2379, 82, true);
                WriteLiteral("\r\n        </nav>\r\n    </div>\r\n\r\n    <div class=\"container body-content\">\r\n        ");
                EndContext();
                BeginContext(2462, 12, false);
#line 58 "C:\Users\Matthew\Documents\Fall_2018\MIS_333K\mrsProject\mrsProject\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(2474, 58, true);
                WriteLiteral("\r\n        <hr />\r\n        <footer>\r\n            <p>&copy; ");
                EndContext();
                BeginContext(2533, 17, false);
#line 61 "C:\Users\Matthew\Documents\Fall_2018\MIS_333K\mrsProject\mrsProject\Views\Shared\_Layout.cshtml"
                 Write(DateTime.Now.Year);

#line default
#line hidden
                EndContext();
                BeginContext(2550, 64, true);
                WriteLiteral(" - BevoSoft Consultants</p>\r\n        </footer>\r\n    </div>\r\n    ");
                EndContext();
                BeginContext(2614, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74b0fe91ea024514a06e7794a448057e", async() => {
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
                BeginContext(2660, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2666, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a35a1697ee1b4f1fa1dd53357e9ea1fe", async() => {
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
                BeginContext(2729, 2, true);
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
            BeginContext(2738, 9, true);
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
