#pragma checksum "C:\Users\Paulo\source\repos\NutriPaulo\NutriPaulo\Views\Exercicios\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "661861be693350669395a4a78a1cc03dfbaf89a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Exercicios_Index), @"mvc.1.0.view", @"/Views/Exercicios/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"661861be693350669395a4a78a1cc03dfbaf89a4", @"/Views/Exercicios/Index.cshtml")]
    public class Views_Exercicios_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NutriPaulo.Models.Exercicios>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Paulo\source\repos\NutriPaulo\NutriPaulo\Views\Exercicios\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 19 "C:\Users\Paulo\source\repos\NutriPaulo\NutriPaulo\Views\Exercicios\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 382, "\"", 415, 1);
#nullable restore
#line 22 "C:\Users\Paulo\source\repos\NutriPaulo\NutriPaulo\Views\Exercicios\Index.cshtml"
WriteAttributeValue("", 397, item.ExerciciosId, 397, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 468, "\"", 501, 1);
#nullable restore
#line 23 "C:\Users\Paulo\source\repos\NutriPaulo\NutriPaulo\Views\Exercicios\Index.cshtml"
WriteAttributeValue("", 483, item.ExerciciosId, 483, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 556, "\"", 589, 1);
#nullable restore
#line 24 "C:\Users\Paulo\source\repos\NutriPaulo\NutriPaulo\Views\Exercicios\Index.cshtml"
WriteAttributeValue("", 571, item.ExerciciosId, 571, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 27 "C:\Users\Paulo\source\repos\NutriPaulo\NutriPaulo\Views\Exercicios\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NutriPaulo.Models.Exercicios>> Html { get; private set; }
    }
}
#pragma warning restore 1591
