#pragma checksum "D:\Documentos\GitHub\E-Commerce\CasaDoCodigo\Views\Pedido\Carrinho.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b41cac24285b74fc21f45ebc7e8d04d963f27ca2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido_Carrinho), @"mvc.1.0.view", @"/Views/Pedido/Carrinho.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pedido/Carrinho.cshtml", typeof(AspNetCore.Views_Pedido_Carrinho))]
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
#line 1 "D:\Documentos\GitHub\E-Commerce\CasaDoCodigo\Views\_ViewImports.cshtml"
using CasaDoCodigo;

#line default
#line hidden
#line 2 "D:\Documentos\GitHub\E-Commerce\CasaDoCodigo\Views\_ViewImports.cshtml"
using CasaDoCodigo.Models;

#line default
#line hidden
#line 3 "D:\Documentos\GitHub\E-Commerce\CasaDoCodigo\Views\_ViewImports.cshtml"
using CasaDoCodigo.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b41cac24285b74fc21f45ebc7e8d04d963f27ca2", @"/Views/Pedido/Carrinho.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5764b985c14b19f76680672d581de467d30433a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedido_Carrinho : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CarrinhoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "carrinho", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/carrinho.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Documentos\GitHub\E-Commerce\CasaDoCodigo\Views\Pedido\Carrinho.cshtml"
   ViewData["Title"] = "Carrinho"; 

#line default
#line hidden
            BeginContext(63, 24, true);
            WriteLiteral("\n<h3>Meu Carrinho</h3>\n\n");
            EndContext();
            BeginContext(87, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b41cac24285b74fc21f45ebc7e8d04d963f27ca24777", async() => {
                BeginContext(129, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(137, 2, true);
            WriteLiteral("\n\n");
            EndContext();
            BeginContext(140, 45, false);
#line 9 "D:\Documentos\GitHub\E-Commerce\CasaDoCodigo\Views\Pedido\Carrinho.cshtml"
Write(await Html.PartialAsync("_NavegacaoCarrinho"));

#line default
#line hidden
            EndContext();
            BeginContext(185, 570, true);
            WriteLiteral(@"
<br />
<div class=""panel panel-default"">
    <div class=""panel-heading"">

        <div class=""row"">
            <div class=""col-md-6"">
                Item
            </div>
            <div class=""col-md-2 text-center"">
                Preço Unitário
            </div>
            <div class=""col-md-2 text-center"">
                Quantidade
            </div>
            <div class=""col-md-2"">
                <span class=""pull-right"">
                    Subtotal
                </span>
            </div>
        </div>
    </div>
    <div class=""panel-body"">
");
            EndContext();
#line 32 "D:\Documentos\GitHub\E-Commerce\CasaDoCodigo\Views\Pedido\Carrinho.cshtml"
         foreach (var item in Model.Itens)
        {

#line default
#line hidden
            BeginContext(808, 41, true);
            WriteLiteral("<div class=\"row row-center linha-produto\"");
            EndContext();
            BeginWriteAttribute("item-id", " item-id=\"", 849, "\"", 867, 1);
#line 34 "D:\Documentos\GitHub\E-Commerce\CasaDoCodigo\Views\Pedido\Carrinho.cshtml"
WriteAttributeValue("", 859, item.Id, 859, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(868, 70, true);
            WriteLiteral(">\n    <div class=\"col-md-3\">\n        <img class=\"img-produto-carrinho\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 938, "\"", 993, 3);
            WriteAttributeValue("", 944, "/images/produtos/large_", 944, 23, true);
#line 36 "D:\Documentos\GitHub\E-Commerce\CasaDoCodigo\Views\Pedido\Carrinho.cshtml"
WriteAttributeValue("", 967, item.Produto.Codigo, 967, 22, false);

#line default
#line hidden
            WriteAttributeValue("", 989, ".jpg", 989, 4, true);
            EndWriteAttribute();
            BeginContext(994, 41, true);
            WriteLiteral(" />\n    </div>\n    <div class=\"col-md-3\">");
            EndContext();
            BeginContext(1037, 17, false);
#line 38 "D:\Documentos\GitHub\E-Commerce\CasaDoCodigo\Views\Pedido\Carrinho.cshtml"
                      Write(item.Produto.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1055, 48, true);
            WriteLiteral("</div>\n    <div class=\"col-md-2 text-center\">R$ ");
            EndContext();
            BeginContext(1105, 18, false);
#line 39 "D:\Documentos\GitHub\E-Commerce\CasaDoCodigo\Views\Pedido\Carrinho.cshtml"
                                     Write(item.PrecoUnitario);

#line default
#line hidden
            EndContext();
            BeginContext(1124, 371, true);
            WriteLiteral(@"</div>
    <div class=""col-md-2 text-center"">
        <div class=""input-group"">
            <span class=""input-group-btn"">
                <button class=""btn btn-default""
                        onclick=""carrinho.clickDecremento(this)"">
                    <span class=""glyphicon-minus""></span>
                </button>
            </span>
            <input type=""text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1495, "\"", 1521, 1);
#line 48 "D:\Documentos\GitHub\E-Commerce\CasaDoCodigo\Views\Pedido\Carrinho.cshtml"
WriteAttributeValue("", 1503, item.Quantidade, 1503, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1522, 487, true);
            WriteLiteral(@"
                   class=""form-control text-center""
                   onblur=""carrinho.updateQuantidade(this)"" />
            <span class=""input-group-btn"">
                <button class=""btn btn-default""
                        onclick=""carrinho.clickIncremento(this)"">
                    <span class=""glyphicon-plus""></span>
                </button>
            </span>
        </div>
    </div>
    <div class=""col-md-2"">
        R$ <span class=""pull-right"" subtotal>
            ");
            EndContext();
            BeginContext(2011, 36, false);
#line 61 "D:\Documentos\GitHub\E-Commerce\CasaDoCodigo\Views\Pedido\Carrinho.cshtml"
        Write(item.Quantidade * item.PrecoUnitario);

#line default
#line hidden
            EndContext();
            BeginContext(2048, 34, true);
            WriteLiteral("\n        </span>\n    </div>\n</div>");
            EndContext();
#line 64 "D:\Documentos\GitHub\E-Commerce\CasaDoCodigo\Views\Pedido\Carrinho.cshtml"
      }

#line default
#line hidden
            BeginContext(2084, 168, true);
            WriteLiteral("\n    </div>\n    <div class=\"panel-footer\">\n        <div class=\"row\">\n            <div class=\"col-md-10\">\n                <span numero-itens>\n                    Total: ");
            EndContext();
            BeginContext(2254, 19, false);
#line 71 "D:\Documentos\GitHub\E-Commerce\CasaDoCodigo\Views\Pedido\Carrinho.cshtml"
                       Write(Model.Itens.Count());

#line default
#line hidden
            EndContext();
            BeginContext(2274, 183, true);
            WriteLiteral("\n                    itens\n                </span>\n            </div>\n            <div class=\"col-md-2\">\n                Total: R$ <span class=\"pull-right\" total>\n                    ");
            EndContext();
            BeginContext(2459, 11, false);
#line 77 "D:\Documentos\GitHub\E-Commerce\CasaDoCodigo\Views\Pedido\Carrinho.cshtml"
                Write(Model.Total);

#line default
#line hidden
            EndContext();
            BeginContext(2471, 78, true);
            WriteLiteral("\n                </span>\n            </div>\n        </div>\n    </div>\n</div>\n\n");
            EndContext();
            BeginContext(2550, 45, false);
#line 84 "D:\Documentos\GitHub\E-Commerce\CasaDoCodigo\Views\Pedido\Carrinho.cshtml"
Write(await Html.PartialAsync("_NavegacaoCarrinho"));

#line default
#line hidden
            EndContext();
            BeginContext(2595, 2, true);
            WriteLiteral("\n\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2615, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(2620, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b41cac24285b74fc21f45ebc7e8d04d963f27ca213198", async() => {
                    BeginContext(2651, 6, true);
                    WriteLiteral("\n\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2666, 1, true);
                WriteLiteral("\n");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CarrinhoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
