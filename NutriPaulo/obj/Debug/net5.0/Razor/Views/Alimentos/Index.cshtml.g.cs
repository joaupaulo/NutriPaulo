#pragma checksum "C:\Users\Paulo\source\repos\NutriPaulo\NutriPaulo\Views\Alimentos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2da2d234d895be548152b79d65bd5af1db345c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Alimentos_Index), @"mvc.1.0.view", @"/Views/Alimentos/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2da2d234d895be548152b79d65bd5af1db345c0", @"/Views/Alimentos/Index.cshtml")]
    public class Views_Alimentos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NutriPaulo.Models.Alimentos>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Paulo\source\repos\NutriPaulo\NutriPaulo\Views\Alimentos\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\Paulo\source\repos\NutriPaulo\NutriPaulo\Views\Alimentos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CafeDaManha));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\Paulo\source\repos\NutriPaulo\NutriPaulo\Views\Alimentos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Almoço));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\Paulo\source\repos\NutriPaulo\NutriPaulo\Views\Alimentos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Lanche));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\Paulo\source\repos\NutriPaulo\NutriPaulo\Views\Alimentos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CafeDaNoite));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 31 "C:\Users\Paulo\source\repos\NutriPaulo\NutriPaulo\Views\Alimentos\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "C:\Users\Paulo\source\repos\NutriPaulo\NutriPaulo\Views\Alimentos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CafeDaManha));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\Paulo\source\repos\NutriPaulo\NutriPaulo\Views\Alimentos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Almoço));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\Paulo\source\repos\NutriPaulo\NutriPaulo\Views\Alimentos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Lanche));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\Paulo\source\repos\NutriPaulo\NutriPaulo\Views\Alimentos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CafeDaNoite));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1181, "\"", 1213, 1);
#nullable restore
#line 46 "C:\Users\Paulo\source\repos\NutriPaulo\NutriPaulo\Views\Alimentos\Index.cshtml"
WriteAttributeValue("", 1196, item.AlimentosId, 1196, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1266, "\"", 1298, 1);
#nullable restore
#line 47 "C:\Users\Paulo\source\repos\NutriPaulo\NutriPaulo\Views\Alimentos\Index.cshtml"
WriteAttributeValue("", 1281, item.AlimentosId, 1281, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1353, "\"", 1385, 1);
#nullable restore
#line 48 "C:\Users\Paulo\source\repos\NutriPaulo\NutriPaulo\Views\Alimentos\Index.cshtml"
WriteAttributeValue("", 1368, item.AlimentosId, 1368, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 51 "C:\Users\Paulo\source\repos\NutriPaulo\NutriPaulo\Views\Alimentos\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NutriPaulo.Models.Alimentos>> Html { get; private set; }
    }
}
#pragma warning restore 1591
