#pragma checksum "D:\UdemyKurslar\entity-framework-core_9_5Saat\CourseApp\CourseApp\Views\Home\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f64ff5c8ecfded7cc81193a68b7f07d851daa55"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_List), @"mvc.1.0.view", @"/Views/Home/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/List.cshtml", typeof(AspNetCore.Views_Home_List))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f64ff5c8ecfded7cc81193a68b7f07d851daa55", @"/Views/Home/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25fd987d7388ad707b6b8d314dfa2b63ad979348", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CourseApp.Models.Request>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(79, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(127, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 5 "D:\UdemyKurslar\entity-framework-core_9_5Saat\CourseApp\CourseApp\Views\Home\List.cshtml"
  
    ViewData["Title"] = "List";

#line default
#line hidden
            BeginContext(171, 491, true);
            WriteLiteral(@"<div class=""m-5"">
    <div class=""bg-success text-white m-5 p-4"">
        Request List
    </div>
    <div class=""table-responsive"">

        <table class=""table table-bordered table striped p-4"">
            <thead>
                <tr>
                    <th>Id</th>
                    <th>Name</th>
                    <th>Email</th>
                    <th>Phone</th>
                    <th>Message</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 25 "D:\UdemyKurslar\entity-framework-core_9_5Saat\CourseApp\CourseApp\Views\Home\List.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(727, 54, true);
            WriteLiteral("                    <tr>\r\n                        <th>");
            EndContext();
            BeginContext(782, 7, false);
#line 28 "D:\UdemyKurslar\entity-framework-core_9_5Saat\CourseApp\CourseApp\Views\Home\List.cshtml"
                       Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(789, 35, true);
            WriteLiteral("</th>\r\n                        <th>");
            EndContext();
            BeginContext(825, 9, false);
#line 29 "D:\UdemyKurslar\entity-framework-core_9_5Saat\CourseApp\CourseApp\Views\Home\List.cshtml"
                       Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(834, 35, true);
            WriteLiteral("</th>\r\n                        <th>");
            EndContext();
            BeginContext(870, 10, false);
#line 30 "D:\UdemyKurslar\entity-framework-core_9_5Saat\CourseApp\CourseApp\Views\Home\List.cshtml"
                       Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(880, 35, true);
            WriteLiteral("</th>\r\n                        <th>");
            EndContext();
            BeginContext(916, 10, false);
#line 31 "D:\UdemyKurslar\entity-framework-core_9_5Saat\CourseApp\CourseApp\Views\Home\List.cshtml"
                       Write(item.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(926, 35, true);
            WriteLiteral("</th>\r\n                        <th>");
            EndContext();
            BeginContext(962, 12, false);
#line 32 "D:\UdemyKurslar\entity-framework-core_9_5Saat\CourseApp\CourseApp\Views\Home\List.cshtml"
                       Write(item.Message);

#line default
#line hidden
            EndContext();
            BeginContext(974, 34, true);
            WriteLiteral("</th>\r\n                    </tr>\r\n");
            EndContext();
#line 34 "D:\UdemyKurslar\entity-framework-core_9_5Saat\CourseApp\CourseApp\Views\Home\List.cshtml"
                }

#line default
#line hidden
            BeginContext(1027, 64, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CourseApp.Models.Request>> Html { get; private set; }
    }
}
#pragma warning restore 1591
