#pragma checksum "C:\Users\Paulo\source\repos\NutriPaulo\NutriPaulo\Views\Pessoas\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7191772a8e965625e22b8b6d5c8fa0261fe8d95"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pessoas_Edit), @"mvc.1.0.view", @"/Views/Pessoas/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7191772a8e965625e22b8b6d5c8fa0261fe8d95", @"/Views/Pessoas/Edit.cshtml")]
    public class Views_Pessoas_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NutriPaulo.Models.Pessoas>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Paulo\source\repos\NutriPaulo\NutriPaulo\Views\Pessoas\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Edit</h1>

<h4>Pessoas</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""PessoasId"" />
            <div class=""form-group"">
                <label asp-for=""Nome"" class=""control-label""></label>
                <input asp-for=""Nome"" class=""form-control"" />
                <span asp-validation-for=""Nome"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""SobreNome"" class=""control-label""></label>
                <input asp-for=""SobreNome"" class=""form-control"" />
                <span asp-validation-for=""SobreNome"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""CPF"" class=""control-label""></label>
                <input asp-for=""CPF"" class=""form-control"" />
                <span asp-validation-for=");
            WriteLiteral(@"""CPF"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""RG"" class=""control-label""></label>
                <input asp-for=""RG"" class=""form-control"" />
                <span asp-validation-for=""RG"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Email"" class=""control-label""></label>
                <input asp-for=""Email"" class=""form-control"" />
                <span asp-validation-for=""Email"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-primary"" />
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
#line 53 "C:\Users\Paulo\source\repos\NutriPaulo\NutriPaulo\Views\Pessoas\Edit.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NutriPaulo.Models.Pessoas> Html { get; private set; }
    }
}
#pragma warning restore 1591
