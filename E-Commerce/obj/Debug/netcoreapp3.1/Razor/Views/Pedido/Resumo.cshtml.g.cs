#pragma checksum "D:\Documentos\GitHub\E-Commerce\E-Commerce\Views\Pedido\Resumo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "104485600bbbb5f2b7c4df11a8e4eadc8b5b01c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido_Resumo), @"mvc.1.0.view", @"/Views/Pedido/Resumo.cshtml")]
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
#line 1 "D:\Documentos\GitHub\E-Commerce\E-Commerce\Views\_ViewImports.cshtml"
using E_Commerce;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Documentos\GitHub\E-Commerce\E-Commerce\Views\_ViewImports.cshtml"
using E_Commerce.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"104485600bbbb5f2b7c4df11a8e4eadc8b5b01c3", @"/Views/Pedido/Resumo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f015392c42bf201d3f4fa8f785de821ea8cb926", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedido_Resumo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Documentos\GitHub\E-Commerce\E-Commerce\Views\Pedido\Resumo.cshtml"
  
    ViewData["Title"] = "Resumo";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h3>Resumo do Pedido</h3>

<div class=""panel panel-default"">
    <div class=""panel-body"">
        <div class=""row"">
            <div class=""col-md-12"">
                <h3>Nº do Pedido: 123</h3>
            </div>
        </div>
        <hr />
        <div class=""row"">
            <div class=""col-md-3"">
                <h3>Seus Dados</h3>
                <div>Harry Porto</div>
                <div>(11) 1234-5678</div>
            </div>
            <div class=""col-md-3"">
                luara.da.silva@gmail.com
            </div>
            <div class=""col-md-6"">
                <h3>Endereço de Entrega</h3>
                <div>Rua dos Alfeneiros, no. 4 (embaixo da escada) - Little Whinging - Surrey - Reino Unido</div>
            </div>
        </div>
        <hr />
        <div class=""row"">
            <div class=""col-md-10"">
                <h3>Item</h3>
            </div>
            <div class=""col-md-2"">
                <h3>Quantidade</h3>
            </div>
        </");
            WriteLiteral(@"div>
        <div class=""row"">
            <div class=""col-md-10"">
                <div>Arduino Pr&#xE1;tico</div>
            </div>
            <div class=""col-md-2"">
                <div class=""pull-right"">2</div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-10"">
                <div>PostgreSQL</div>
            </div>
            <div class=""col-md-2"">
                <div class=""pull-right"">3</div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-10"">
                <div>Scala</div>
            </div>
            <div class=""col-md-2"">
                <div class=""pull-right"">1</div>
            </div>
        </div>
    </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
