#pragma checksum "C:\Users\lksmarcondes_2\source\repos\ProjetoBlueModas\ProjetoBlueModas\Views\Home\LoginUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f94d9c0c7013aa9fe281fb1308bd80f885f1617"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_LoginUser), @"mvc.1.0.view", @"/Views/Home/LoginUser.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f94d9c0c7013aa9fe281fb1308bd80f885f1617", @"/Views/Home/LoginUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73308b915ffb160ae9f92d1de16035f3f2679580", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_LoginUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\lksmarcondes_2\source\repos\ProjetoBlueModas\ProjetoBlueModas\Views\Home\LoginUser.cshtml"
  
    ViewData["Title"] = "Login User";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n");
            WriteLiteral(" ");
            WriteLiteral(@"@import url('https://fonts.googleapis.com/css2?family=Quicksand:wght@300&display=swap');

    .lh-title {
        font-family: 'Quicksand', sans-serif;
        margin: 20px 0px;
    }

    .lh-access {
        margin-top: 20px;
        font-size: 12pt;
    }
</style>

<div class=""container"">
    <div class=""row d-flex align-content-center justify-content-center"">
        <div class=""lh-title text-center col-lg-12"">
            <h2><i class=""fal fa-user""></i> Administrador</h2>
        </div>
        <div class=""col-lg-4"">
");
#nullable restore
#line 25 "C:\Users\lksmarcondes_2\source\repos\ProjetoBlueModas\ProjetoBlueModas\Views\Home\LoginUser.cshtml"
             using (Html.BeginForm()) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f94d9c0c7013aa9fe281fb1308bd80f885f16175053", async() => {
                WriteLiteral("\r\n                    <div class=\"form-group col-lg-12\">\r\n                        ");
#nullable restore
#line 28 "C:\Users\lksmarcondes_2\source\repos\ProjetoBlueModas\ProjetoBlueModas\Views\Home\LoginUser.cshtml"
                   Write(Html.TextBox("Email", null, new { @class = "form-control", @placeholder = "E-mail" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group col-lg-12\">\r\n                        ");
#nullable restore
#line 31 "C:\Users\lksmarcondes_2\source\repos\ProjetoBlueModas\ProjetoBlueModas\Views\Home\LoginUser.cshtml"
                   Write(Html.Password("Password", null, new { @class = "form-control", @placeholder = "Senha" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"offset-lg-8 col-lg-4\">\r\n                        <button type=\"submit\" class=\"btn btn-outline-primary\">Log In</button>\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 37 "C:\Users\lksmarcondes_2\source\repos\ProjetoBlueModas\ProjetoBlueModas\Views\Home\LoginUser.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"lh-access text-danger text-center col-lg-12\">\r\n            bluemodas@gmail.com | bluemodas123\r\n        </div>\r\n    </div>\r\n</div>");
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
