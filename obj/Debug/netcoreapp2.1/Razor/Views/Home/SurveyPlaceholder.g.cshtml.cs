#pragma checksum "C:\Users\plitwin\Source\repos\ACEStudy\Views\Home\SurveyPlaceholder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb2c8f1db031b5022a52bf51ae80e6cbe976e243"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SurveyPlaceholder), @"mvc.1.0.view", @"/Views/Home/SurveyPlaceholder.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/SurveyPlaceholder.cshtml", typeof(AspNetCore.Views_Home_SurveyPlaceholder))]
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
#line 1 "C:\Users\plitwin\Source\repos\ACEStudy\Views\_ViewImports.cshtml"
using ACEStudy;

#line default
#line hidden
#line 2 "C:\Users\plitwin\Source\repos\ACEStudy\Views\_ViewImports.cshtml"
using ACEStudy.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb2c8f1db031b5022a52bf51ae80e6cbe976e243", @"/Views/Home/SurveyPlaceholder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ed283b9b3e40f2548be15d5e766406fb68a754a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SurveyPlaceholder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\plitwin\Source\repos\ACEStudy\Views\Home\SurveyPlaceholder.cshtml"
  
    ViewBag.Title = "Survey Placeholder";

#line default
#line hidden
            BeginContext(50, 132, true);
            WriteLiteral("<div class=\"col-md-6\">\r\n    <b>The study is not open yet. Thank you for interest. It will be open later in February.</b>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(200, 148, true);
                WriteLiteral("\r\n    <script>\r\n        $(window).on(\"load\", function () {\r\n            $(\"body\").css(\"background-color\",\"white\");\r\n        });\r\n    </script>    \r\n");
                EndContext();
            }
            );
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
