#pragma checksum "C:\Users\Paulo\source\repos\NutriPaulo\NutriPaulo\Views\Quantidades\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94338e6d7eebc02bc0d70add88e1ee5e83557028"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Quantidades_Delete), @"mvc.1.0.view", @"/Views/Quantidades/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94338e6d7eebc02bc0d70add88e1ee5e83557028", @"/Views/Quantidades/Delete.cshtml")]
    public class Views_Quantidades_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NutriPaulo.Models.Quantidade>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Paulo\source\repos\NutriPaulo\NutriPaulo\Views\Quantidades\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Delete</h1>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>Quantidade</h4>
    <hr />
    <dl class=""row"">
    </dl>
    
    <form asp-action=""Delete"">
        <input type=""hidden"" asp-for=""QuantidadeId"" />
        <input type=""submit"" value=""Delete"" class=""btn btn-danger"" /> |
        <a asp-action=""Index"">Back to List</a>
    </form>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NutriPaulo.Models.Quantidade> Html { get; private set; }
    }
}
#pragma warning restore 1591
