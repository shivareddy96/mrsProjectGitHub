#pragma checksum "C:\Users\reddy\Documents\MIS 333K HW\UpdatedProject\mrsProject\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3766fe9a1d5a97862ff2123ee9582773e0a70a04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Error.cshtml", typeof(AspNetCore.Views_Shared_Error))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3766fe9a1d5a97862ff2123ee9582773e0a70a04", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<string>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\reddy\Documents\MIS 333K HW\UpdatedProject\mrsProject\Views\Shared\Error.cshtml"
  
    ViewBag.Title = "Error";

#line default
#line hidden
            BeginContext(65, 54, true);
            WriteLiteral("\r\n<h2>Error</h2>\r\n\r\n<div class=\"alert alert-danger\">\r\n");
            EndContext();
#line 9 "C:\Users\reddy\Documents\MIS 333K HW\UpdatedProject\mrsProject\Views\Shared\Error.cshtml"
     switch (Model.Count())
    {
        case 0:

#line default
#line hidden
            BeginContext(172, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(186, 43, true);
            WriteLiteral(" Something went wrong.  Please try again.\r\n");
            EndContext();
#line 13 "C:\Users\reddy\Documents\MIS 333K HW\UpdatedProject\mrsProject\Views\Shared\Error.cshtml"
            break;
        case 1:
            

#line default
#line hidden
            BeginContext(279, 13, false);
#line 15 "C:\Users\reddy\Documents\MIS 333K HW\UpdatedProject\mrsProject\Views\Shared\Error.cshtml"
       Write(Model.First());

#line default
#line hidden
            EndContext();
#line 15 "C:\Users\reddy\Documents\MIS 333K HW\UpdatedProject\mrsProject\Views\Shared\Error.cshtml"
                          ;
            break;
        default:

#line default
#line hidden
            BeginContext(333, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(347, 59, true);
            WriteLiteral(" The following errors were encountered:\r\n            <ul>\r\n");
            EndContext();
#line 20 "C:\Users\reddy\Documents\MIS 333K HW\UpdatedProject\mrsProject\Views\Shared\Error.cshtml"
                 foreach (string error in Model)
                {

#line default
#line hidden
            BeginContext(475, 24, true);
            WriteLiteral("                    <li>");
            EndContext();
            BeginContext(500, 5, false);
#line 22 "C:\Users\reddy\Documents\MIS 333K HW\UpdatedProject\mrsProject\Views\Shared\Error.cshtml"
                   Write(error);

#line default
#line hidden
            EndContext();
            BeginContext(505, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 23 "C:\Users\reddy\Documents\MIS 333K HW\UpdatedProject\mrsProject\Views\Shared\Error.cshtml"
                }

#line default
#line hidden
            BeginContext(531, 19, true);
            WriteLiteral("            </ul>\r\n");
            EndContext();
#line 25 "C:\Users\reddy\Documents\MIS 333K HW\UpdatedProject\mrsProject\Views\Shared\Error.cshtml"
            break;
    }

#line default
#line hidden
            BeginContext(577, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
            BeginContext(586, 80, false);
#line 28 "C:\Users\reddy\Documents\MIS 333K HW\UpdatedProject\mrsProject\Views\Shared\Error.cshtml"
Write(Html.ActionLink("OK", "Index", "Home", null, new { @class = "btn btn-success" }));

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<string>> Html { get; private set; }
    }
}
#pragma warning restore 1591
