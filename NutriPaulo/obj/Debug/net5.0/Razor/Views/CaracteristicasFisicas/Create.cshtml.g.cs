#pragma checksum "C:\Users\Paulo\source\repos\NutriPaulo\NutriPaulo\Views\CaracteristicasFisicas\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "224ba9e4250a77824cf12841de1180cdc2ddb515"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CaracteristicasFisicas_Create), @"mvc.1.0.view", @"/Views/CaracteristicasFisicas/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"224ba9e4250a77824cf12841de1180cdc2ddb515", @"/Views/CaracteristicasFisicas/Create.cshtml")]
    public class Views_CaracteristicasFisicas_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NutriPaulo.Models.CaracteristicasFisicas>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Paulo\source\repos\NutriPaulo\NutriPaulo\Views\CaracteristicasFisicas\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>CaracteristicasFisicas</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""Altura"" class=""control-label""></label>
                <input asp-for=""Altura"" class=""form-control"" />
                <span asp-validation-for=""Altura"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Peso"" class=""control-label""></label>
                <input asp-for=""Peso"" class=""form-control"" />
                <span asp-validation-for=""Peso"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Biotipo"" class=""control-label""></label>
                <input asp-for=""Biotipo"" class=""form-control"" />
                <span asp-validation-for=""Biotipo"" class=""text-danger""></span>
");
            WriteLiteral(@"            </div>
            <div class=""form-group"">
                <label asp-for=""PessoasId"" class=""control-label""></label>
                <select asp-for=""PessoasId"" class =""form-control"" asp-items=""ViewBag.PessoasId""></select>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 46 "C:\Users\Paulo\source\repos\NutriPaulo\NutriPaulo\Views\CaracteristicasFisicas\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NutriPaulo.Models.CaracteristicasFisicas> Html { get; private set; }
    }
}
#pragma warning restore 1591
