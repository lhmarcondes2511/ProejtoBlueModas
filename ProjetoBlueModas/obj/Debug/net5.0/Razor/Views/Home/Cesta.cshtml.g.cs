#pragma checksum "C:\Users\lksmarcondes_2\source\repos\ProjetoBlueModas\ProjetoBlueModas\Views\Home\Cesta.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78ea9d7b084b9f204c69ef47cfe20fdd6a987506"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Cesta), @"mvc.1.0.view", @"/Views/Home/Cesta.cshtml")]
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
#nullable restore
#line 1 "C:\Users\lksmarcondes_2\source\repos\ProjetoBlueModas\ProjetoBlueModas\Views\_ViewImports.cshtml"
using ProjetoBlueModas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lksmarcondes_2\source\repos\ProjetoBlueModas\ProjetoBlueModas\Views\_ViewImports.cshtml"
using ProjetoBlueModas.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78ea9d7b084b9f204c69ef47cfe20fdd6a987506", @"/Views/Home/Cesta.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73308b915ffb160ae9f92d1de16035f3f2679580", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Cesta : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\lksmarcondes_2\source\repos\ProjetoBlueModas\ProjetoBlueModas\Views\Home\Cesta.cshtml"
  
    ViewData["Title"] = "Cesta";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n");
            WriteLiteral("    ");
            WriteLiteral(@"@import url('https://fonts.googleapis.com/css2?family=Quicksand:wght@300&display=swap');

    .lh-title {
        font-family: 'Quicksand', sans-serif;
    }

    .lh-hr {
        width: 80%;
    }

    .lh-finalCompra {
        margin-top: 20px;
    }

    .lh-qtd {
        color: cornflowerblue;
    }

    .lh-qtd:hover {
        text-decoration: none;
        color: cornflowerblue;
    }
</style>

<div class=""container"">
    <div class=""lh-title text-center"">
        <h2>Carrinho de Compras</h2>
    </div>
    <hr class=""lh-hr"" />
    <div>
        <table class=""table table-striped"">
            <thead>
                <tr>
                    <th>Código</th>
                    <th>Nome do Produto</th>
                    <th>Quantidade</th>
                    <th>Preço Unitário</th>
                    <th class=""text-right"">Total Produto</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>1000</td>
 ");
            WriteLiteral(@"                   <td>Chapéu</td>
                    <td>
                        <a href=""#"" class=""lh-qtd""><i class=""fal fa-minus-circle""></i></a>
                        2
                        <a href=""#"" class=""lh-qtd""><i class=""fal fa-plus-circle""></i></a>
                        &nbsp;
                        <a href=""#"" class=""text-danger""><i class=""fal fa-trash-alt""></i></a>
                    </td>
                    <td>45,00</td>
                    <td class=""text-right"">90,00</td>
                </tr>
                <tr>
                    <td>1001</td>
                    <td>Mochila</td>
                    <td>
                        <a href=""#"" class=""lh-qtd""><i class=""fal fa-minus-circle""></i></a>
                        1
                        <a href=""#"" class=""lh-qtd""><i class=""fal fa-plus-circle""></i></a>
                        &nbsp;
                        <a href=""#"" class=""text-danger""><i class=""fal fa-trash-alt""></i></a>
                    </td>
 ");
            WriteLiteral(@"                   <td>75,00</td>
                    <td class=""text-right"">75,00</td>
                </tr>
                <tr>
                    <td>1002</td>
                    <td>Jaqueta</td>
                    <td>
                        <a href=""#"" class=""lh-qtd""><i class=""fal fa-minus-circle""></i></a>
                        3
                        <a href=""#"" class=""lh-qtd""><i class=""fal fa-plus-circle""></i></a>
                        &nbsp;
                        <a href=""#"" class=""text-danger""><i class=""fal fa-trash-alt""></i></a>
                    </td>
                    <td>50,00</td>
                    <td class=""text-right"">150,00</td>
                </tr>
            </tbody>
        </table>
    </div>
    <div class=""row"">
        <div class=""offset-lg-10 col-lg-2"">
            <h5 class=""text-dark lh-precoTotal"">
                <b>
                    Total R$ <i>315,00</i>
                </b>
            </h5>
        </div>
    </div>
    <div");
            WriteLiteral(" class=\"row lh-finalCompra\">\r\n        <div class=\"offset-lg-10\">\r\n            <button class=\"btn btn-lg btn-success col-lg-12\">\r\n                <h6>FINALIZAR COMPRA</h6>\r\n            </button>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
