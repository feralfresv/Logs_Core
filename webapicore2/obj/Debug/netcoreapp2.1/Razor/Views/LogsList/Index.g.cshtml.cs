#pragma checksum "C:\Users\Curso\source\repos\Academia_Softtek\Logs_Core\webapicore2\Views\LogsList\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f7e0f6b1a082b3326050f87029edaf2bf60b51f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LogsList_Index), @"mvc.1.0.view", @"/Views/LogsList/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/LogsList/Index.cshtml", typeof(AspNetCore.Views_LogsList_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f7e0f6b1a082b3326050f87029edaf2bf60b51f", @"/Views/LogsList/Index.cshtml")]
    public class Views_LogsList_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<webapicore2.Models.Log>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Curso\source\repos\Academia_Softtek\Logs_Core\webapicore2\Views\LogsList\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(87, 164, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(252, 46, false);
#line 16 "C:\Users\Curso\source\repos\Academia_Softtek\Logs_Core\webapicore2\Views\LogsList\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Aplicacion));

#line default
#line hidden
            EndContext();
            BeginContext(298, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(354, 43, false);
#line 19 "C:\Users\Curso\source\repos\Academia_Softtek\Logs_Core\webapicore2\Views\LogsList\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Mensaje));

#line default
#line hidden
            EndContext();
            BeginContext(397, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(453, 41, false);
#line 22 "C:\Users\Curso\source\repos\Academia_Softtek\Logs_Core\webapicore2\Views\LogsList\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Fecha));

#line default
#line hidden
            EndContext();
            BeginContext(494, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 28 "C:\Users\Curso\source\repos\Academia_Softtek\Logs_Core\webapicore2\Views\LogsList\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(612, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(661, 45, false);
#line 31 "C:\Users\Curso\source\repos\Academia_Softtek\Logs_Core\webapicore2\Views\LogsList\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Aplicacion));

#line default
#line hidden
            EndContext();
            BeginContext(706, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(762, 42, false);
#line 34 "C:\Users\Curso\source\repos\Academia_Softtek\Logs_Core\webapicore2\Views\LogsList\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Mensaje));

#line default
#line hidden
            EndContext();
            BeginContext(804, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(860, 40, false);
#line 37 "C:\Users\Curso\source\repos\Academia_Softtek\Logs_Core\webapicore2\Views\LogsList\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Fecha));

#line default
#line hidden
            EndContext();
            BeginContext(900, 75, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 975, "\"", 998, 1);
#line 40 "C:\Users\Curso\source\repos\Academia_Softtek\Logs_Core\webapicore2\Views\LogsList\Index.cshtml"
WriteAttributeValue("", 990, item.Id, 990, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(999, 52, true);
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1051, "\"", 1074, 1);
#line 41 "C:\Users\Curso\source\repos\Academia_Softtek\Logs_Core\webapicore2\Views\LogsList\Index.cshtml"
WriteAttributeValue("", 1066, item.Id, 1066, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1075, 54, true);
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1129, "\"", 1152, 1);
#line 42 "C:\Users\Curso\source\repos\Academia_Softtek\Logs_Core\webapicore2\Views\LogsList\Index.cshtml"
WriteAttributeValue("", 1144, item.Id, 1144, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1153, 47, true);
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 45 "C:\Users\Curso\source\repos\Academia_Softtek\Logs_Core\webapicore2\Views\LogsList\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1203, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<webapicore2.Models.Log>> Html { get; private set; }
    }
}
#pragma warning restore 1591
