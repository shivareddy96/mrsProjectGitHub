#pragma checksum "C:\Users\Matthew\Documents\Fall_2018\MIS_333K\mrsProject\mrsProject\Views\Search\SearchResults.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a4e1873a5ebd72387a45eb63d4cf800b1a0bf6e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search_SearchResults), @"mvc.1.0.view", @"/Views/Search/SearchResults.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Search/SearchResults.cshtml", typeof(AspNetCore.Views_Search_SearchResults))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a4e1873a5ebd72387a45eb63d4cf800b1a0bf6e", @"/Views/Search/SearchResults.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Search_SearchResults : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<mrsProject.Models.Book>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BookDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Users\Matthew\Documents\Fall_2018\MIS_333K\mrsProject\mrsProject\Views\Search\SearchResults.cshtml"
  
    ViewData["Title"] = "SearchResults";

#line default
#line hidden
            BeginContext(97, 28, true);
            WriteLiteral("\r\n<h2>SearchResults</h2>\r\n\r\n");
            EndContext();
            BeginContext(125, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99900b76daff4aeea9cd0981061d7af2", async() => {
                BeginContext(131, 89, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Details</title>\r\n");
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
            BeginContext(227, 22, true);
            WriteLiteral("\r\n<p>\r\n    Displaying ");
            EndContext();
            BeginContext(250, 21, false);
#line 15 "C:\Users\Matthew\Documents\Fall_2018\MIS_333K\mrsProject\mrsProject\Views\Search\SearchResults.cshtml"
          Write(ViewBag.SelectedBooks);

#line default
#line hidden
            EndContext();
            BeginContext(271, 8, true);
            WriteLiteral(" out of ");
            EndContext();
            BeginContext(280, 18, false);
#line 15 "C:\Users\Matthew\Documents\Fall_2018\MIS_333K\mrsProject\mrsProject\Views\Search\SearchResults.cshtml"
                                        Write(ViewBag.TotalBooks);

#line default
#line hidden
            EndContext();
            BeginContext(298, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(391, 41, false);
#line 21 "C:\Users\Matthew\Documents\Fall_2018\MIS_333K\mrsProject\mrsProject\Views\Search\SearchResults.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(432, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(488, 42, false);
#line 24 "C:\Users\Matthew\Documents\Fall_2018\MIS_333K\mrsProject\mrsProject\Views\Search\SearchResults.cshtml"
           Write(Html.DisplayNameFor(model => model.Author));

#line default
#line hidden
            EndContext();
            BeginContext(530, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(586, 48, false);
#line 27 "C:\Users\Matthew\Documents\Fall_2018\MIS_333K\mrsProject\mrsProject\Views\Search\SearchResults.cshtml"
           Write(Html.DisplayNameFor(model => model.BookUniqueID));

#line default
#line hidden
            EndContext();
            BeginContext(634, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(690, 47, false);
#line 30 "C:\Users\Matthew\Documents\Fall_2018\MIS_333K\mrsProject\mrsProject\Views\Search\SearchResults.cshtml"
           Write(Html.DisplayNameFor(model => model.ItemInStock));

#line default
#line hidden
            EndContext();
            BeginContext(737, 57, true);
            WriteLiteral("\r\n            </td>\r\n\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(795, 48, false);
#line 34 "C:\Users\Matthew\Documents\Fall_2018\MIS_333K\mrsProject\mrsProject\Views\Search\SearchResults.cshtml"
           Write(Html.DisplayNameFor(model => model.SimpleRating));

#line default
#line hidden
            EndContext();
            BeginContext(843, 88, true);
            WriteLiteral("\r\n            </th>\r\n                       \r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 40 "C:\Users\Matthew\Documents\Fall_2018\MIS_333K\mrsProject\mrsProject\Views\Search\SearchResults.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(980, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1041, 40, false);
#line 44 "C:\Users\Matthew\Documents\Fall_2018\MIS_333K\mrsProject\mrsProject\Views\Search\SearchResults.cshtml"
               Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
            EndContext();
            BeginContext(1081, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1149, 41, false);
#line 47 "C:\Users\Matthew\Documents\Fall_2018\MIS_333K\mrsProject\mrsProject\Views\Search\SearchResults.cshtml"
               Write(Html.DisplayFor(modelItem => item.Author));

#line default
#line hidden
            EndContext();
            BeginContext(1190, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1258, 47, false);
#line 50 "C:\Users\Matthew\Documents\Fall_2018\MIS_333K\mrsProject\mrsProject\Views\Search\SearchResults.cshtml"
               Write(Html.DisplayFor(modelItem => item.BookUniqueID));

#line default
#line hidden
            EndContext();
            BeginContext(1305, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1373, 46, false);
#line 53 "C:\Users\Matthew\Documents\Fall_2018\MIS_333K\mrsProject\mrsProject\Views\Search\SearchResults.cshtml"
               Write(Html.DisplayFor(modelItem => item.ItemInStock));

#line default
#line hidden
            EndContext();
            BeginContext(1419, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1487, 47, false);
#line 56 "C:\Users\Matthew\Documents\Fall_2018\MIS_333K\mrsProject\mrsProject\Views\Search\SearchResults.cshtml"
               Write(Html.DisplayFor(modelItem => item.SimpleRating));

#line default
#line hidden
            EndContext();
            BeginContext(1534, 84, true);
            WriteLiteral("\r\n                </td>\r\n               \r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1618, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e79236214c184d7f9570c565c239cf2c", async() => {
                BeginContext(1674, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 60 "C:\Users\Matthew\Documents\Fall_2018\MIS_333K\mrsProject\mrsProject\Views\Search\SearchResults.cshtml"
                                                  WriteLiteral(item.BookID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1685, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 63 "C:\Users\Matthew\Documents\Fall_2018\MIS_333K\mrsProject\mrsProject\Views\Search\SearchResults.cshtml"
        }

#line default
#line hidden
            BeginContext(1740, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<mrsProject.Models.Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
