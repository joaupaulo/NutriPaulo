#pragma checksum "C:\Users\Paulo\source\repos\NutriPaulo\NutriPaulo\Views\Pessoas\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8f6aedf17cfc317b878078b33cbd2328c8ff2cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pessoas_Create), @"mvc.1.0.view", @"/Views/Pessoas/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8f6aedf17cfc317b878078b33cbd2328c8ff2cd", @"/Views/Pessoas/Create.cshtml")]
    public class Views_Pessoas_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NutriPaulo.Models.Pessoas>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/site.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-append-version", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8f6aedf17cfc317b878078b33cbd2328c8ff2cd5464", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>");
#nullable restore
#line 10 "C:\Users\Paulo\source\repos\NutriPaulo\NutriPaulo\Views\Pessoas\Create.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - NutriPaulo</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b8f6aedf17cfc317b878078b33cbd2328c8ff2cd6107", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b8f6aedf17cfc317b878078b33cbd2328c8ff2cd7285", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8f6aedf17cfc317b878078b33cbd2328c8ff2cd9167", async() => {
                WriteLiteral(@"
    <div class=""conteudo"">

        <div class=""Titulo"">

            <h1 class=""display-5"">Vamos realizar o seu cadastro !</h1>
            <h2>Insira seus dados</h2>
            <p><em> A qualidade da alimentação é tão importante quanto a quantidade..</em></p>
        </div>

        <div class=""form-group  "">
            ");
#nullable restore
#line 25 "C:\Users\Paulo\source\repos\NutriPaulo\NutriPaulo\Views\Pessoas\Create.cshtml"
       Write(Html.LabelFor(model => model.Nome, new { @class = "col-sm-2 col-form-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 26 "C:\Users\Paulo\source\repos\NutriPaulo\NutriPaulo\Views\Pessoas\Create.cshtml"
       Write(Html.TextBoxFor(model => model.Nome, new { @class = "form-control", @placeholder = "Digite seu nome", @style = "width:400px;" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <div class=\"alert-danger\">\r\n                ");
#nullable restore
#line 28 "C:\Users\Paulo\source\repos\NutriPaulo\NutriPaulo\Views\Pessoas\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Nome));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group  \">\r\n            ");
#nullable restore
#line 33 "C:\Users\Paulo\source\repos\NutriPaulo\NutriPaulo\Views\Pessoas\Create.cshtml"
       Write(Html.LabelFor(model => model.SobreNome, new { @class = "col-sm-2 col-form-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 34 "C:\Users\Paulo\source\repos\NutriPaulo\NutriPaulo\Views\Pessoas\Create.cshtml"
       Write(Html.TextBoxFor(model => model.SobreNome, new { @class = "form-control", @placeholder = "Digite seu sobrenome", @style = "width:400px;" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <div class=\"alert-danger\">\r\n                ");
#nullable restore
#line 36 "C:\Users\Paulo\source\repos\NutriPaulo\NutriPaulo\Views\Pessoas\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.SobreNome));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group  \">\r\n            ");
#nullable restore
#line 41 "C:\Users\Paulo\source\repos\NutriPaulo\NutriPaulo\Views\Pessoas\Create.cshtml"
       Write(Html.LabelFor(model => model.Email, new { @class = "col-sm-2 col-form-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 42 "C:\Users\Paulo\source\repos\NutriPaulo\NutriPaulo\Views\Pessoas\Create.cshtml"
       Write(Html.TextBoxFor(model => model.Email, new { @class = "form-control", @placeholder = "Digite seu sobrenome", @style = "width:400px;" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <div class=\"alert-danger\">\r\n                ");
#nullable restore
#line 44 "C:\Users\Paulo\source\repos\NutriPaulo\NutriPaulo\Views\Pessoas\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group  \">\r\n            ");
#nullable restore
#line 49 "C:\Users\Paulo\source\repos\NutriPaulo\NutriPaulo\Views\Pessoas\Create.cshtml"
       Write(Html.LabelFor(model => model.CPF, new { @class = "col-sm-2 col-form-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 50 "C:\Users\Paulo\source\repos\NutriPaulo\NutriPaulo\Views\Pessoas\Create.cshtml"
       Write(Html.TextBoxFor(model => model.CPF, new { @class = "form-control", @placeholder = "Digite seu sobrenome", @style = "width:400px;" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <div class=\"alert-danger\">\r\n                ");
#nullable restore
#line 52 "C:\Users\Paulo\source\repos\NutriPaulo\NutriPaulo\Views\Pessoas\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.CPF));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group  \">\r\n            ");
#nullable restore
#line 57 "C:\Users\Paulo\source\repos\NutriPaulo\NutriPaulo\Views\Pessoas\Create.cshtml"
       Write(Html.LabelFor(model => model.RG, new { @class = "col-sm-2 col-form-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 58 "C:\Users\Paulo\source\repos\NutriPaulo\NutriPaulo\Views\Pessoas\Create.cshtml"
       Write(Html.TextBoxFor(model => model.RG, new { @class = "form-control", @placeholder = "Digite seu sobrenome", @style = "width:400px;" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <div class=\"alert-danger\">\r\n                ");
#nullable restore
#line 60 "C:\Users\Paulo\source\repos\NutriPaulo\NutriPaulo\Views\Pessoas\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.RG));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n\r\n        <div class=\"conteudoInferior\">\r\n            <button class=\"meubtn\"> <a");
                BeginWriteAttribute("href", " href=\'", 2866, "\'", 2906, 1);
#nullable restore
#line 66 "C:\Users\Paulo\source\repos\NutriPaulo\NutriPaulo\Views\Pessoas\Create.cshtml"
WriteAttributeValue("", 2873, Url.Action("Biotipo", "Pessoas"), 2873, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-primary\"> Faça uma avaliação ! </a> </button>\r\n        </div>\r\n\r\n\r\n    </div>\r\n    </div>\r\n\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8f6aedf17cfc317b878078b33cbd2328c8ff2cd15705", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8f6aedf17cfc317b878078b33cbd2328c8ff2cd16805", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8f6aedf17cfc317b878078b33cbd2328c8ff2cd17905", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 93 "C:\Users\Paulo\source\repos\NutriPaulo\NutriPaulo\Views\Pessoas\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
            WriteLiteral(@"

<style>

    * {
        margin: 0;
        padding: 0;
        box-sizing: border-box;
        background-color: #3f51b5;
        font-family: sans-serif;
        font-weight: bold;
        color: #f9fbe7;
    }

    .conteudo {
        display: flex;
        flex-direction: column;
        justify-content: center;
        height: 100vh;
        align-items: center;
    }


    .Titulo {
        margin: 0 auto;
        text-align: center;
    }


    .meubtn {
        padding: 10px 10px;
        border-radius: 10px;
        border: none;
        font-family: sans-serif;
        margin: 0 auto;
    }
    }
</style>


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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NutriPaulo.Models.Pessoas> Html { get; private set; }
    }
}
#pragma warning restore 1591
