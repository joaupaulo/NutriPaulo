#pragma checksum "C:\Users\Paulo\source\repos\NutriPaulo\NutriPaulo\Views\RelatorioPrincipals\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57600dc5cd2f2803102f174a08a5b685075a182b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RelatorioPrincipals_Home), @"mvc.1.0.view", @"/Views/RelatorioPrincipals/Home.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57600dc5cd2f2803102f174a08a5b685075a182b", @"/Views/RelatorioPrincipals/Home.cshtml")]
    public class Views_RelatorioPrincipals_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<main>



    <div class=""conteudo"">

        <div>
            <h1>Nutricionista</h1>
            <h2>Paulo Santos</h2>
            <h4>
                Especializada em Atendimento Clínico e Terapêutico Nutricional. Foi fundada em Janeiro 2010, com objetivo de oferecer atendimento individualizado ás pessoas que necessitam conhecer e usufruir dos valores nutricionais dos alimentos que são ingeridos diariamente.
            </h4>







        </div>
        <div class=""conteudoInferior"">
            <button class=""meubtn""> <a");
            BeginWriteAttribute("href", " href=\'", 554, "\'", 593, 1);
#nullable restore
#line 22 "C:\Users\Paulo\source\repos\NutriPaulo\NutriPaulo\Views\RelatorioPrincipals\Home.cshtml"
WriteAttributeValue("", 561, Url.Action("Create", "Pessoas"), 561, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-primary""> Faça uma avaliação ! </a> </button>
        </div>
     
   
    </div>

</main>





<style>
    

    * {
        margin: 0;
        padding: 0;
        box-sizing: border-box;
    }

    .conteudo {
        display: flex;
        background-color: #3f51b5;
        height: 100vh;
        align-items: center;
        justify-content: center;
        font-family: sans-serif;
        color: #f9fbe7;
        flex-direction:column;
    }

        .conteudo h1 {
            font-size: 120px;
            text-align: center;
        }

        .conteudo h2 {
            margin: 0 auto;
            text-align: center;
        }

        .conteudo h4 {
            margin-top: 30px;
            width: 700px;
            text-align: center;
            margin-left: 30px;
            font-weight: lighter;
        }

        a{
            text-decoration:none;
        }

    .meubtn {
        padding: 20px 20px;
        border-radius: 10px");
            WriteLiteral(";\r\n        border: none;\r\n        font-family: sans-serif;\r\n       margin: 0 auto;\r\n    }\r\n\r\n    .conteudoInferior{\r\n        margin-top:30px;\r\n        font-family:sans-serif;\r\n        font-weight:bold;\r\n    }\r\n</style>\r\n");
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
