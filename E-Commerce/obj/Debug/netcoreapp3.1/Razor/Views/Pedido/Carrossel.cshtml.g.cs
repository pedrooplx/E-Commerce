#pragma checksum "D:\Documentos\GitHub\E-Commerce\E-Commerce\Views\Pedido\Carrossel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c24e6a1ace121c2168a26ed16915373b9caa303d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido_Carrossel), @"mvc.1.0.view", @"/Views/Pedido/Carrossel.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c24e6a1ace121c2168a26ed16915373b9caa303d", @"/Views/Pedido/Carrossel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f015392c42bf201d3f4fa8f785de821ea8cb926", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedido_Carrossel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Produto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h3>Catálogo</h3>\n<div id=\"my-carousel\" class=\"carousel slide\" data-ride=\"carousel\">\n    <!-- Wrapper for slides -->\n    <div class=\"carousel-inner\" role=\"listbox\">\n");
#nullable restore
#line 7 "D:\Documentos\GitHub\E-Commerce\E-Commerce\Views\Pedido\Carrossel.cshtml"
           
            const int TamanhoPagina = 4;
            int paginas = (int)Math.Ceiling((double)Model.Count() / TamanhoPagina);
        

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 12 "D:\Documentos\GitHub\E-Commerce\E-Commerce\Views\Pedido\Carrossel.cshtml"
         for (int pagina = 0; pagina < paginas; pagina++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div");
            BeginWriteAttribute("class", " class=\"", 421, "\"", 464, 2);
            WriteAttributeValue("", 429, "item", 429, 4, true);
#nullable restore
#line 14 "D:\Documentos\GitHub\E-Commerce\E-Commerce\Views\Pedido\Carrossel.cshtml"
WriteAttributeValue(" ", 433, pagina == 0 ? "active" : "", 434, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                <div class=\"row\">\n");
#nullable restore
#line 16 "D:\Documentos\GitHub\E-Commerce\E-Commerce\Views\Pedido\Carrossel.cshtml"
                       
                        var Produtos = Model.Skip(pagina * TamanhoPagina).Take(TamanhoPagina);
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\Documentos\GitHub\E-Commerce\E-Commerce\Views\Pedido\Carrossel.cshtml"
                     foreach (var produto in Produtos)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-md-3 col-sm-3 col-lg-3\">\n                            <div class=\"panel panel-default\">\n                                <div class=\"panel-body\">\n                                    <img class=\"img-produto-carrossel\"");
            BeginWriteAttribute("src", " src=\"", 974, "\"", 1024, 3);
            WriteAttributeValue("", 980, "/images/produtos/large_", 980, 23, true);
#nullable restore
#line 24 "D:\Documentos\GitHub\E-Commerce\E-Commerce\Views\Pedido\Carrossel.cshtml"
WriteAttributeValue("", 1003, produto.Codigo, 1003, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1020, ".jpg", 1020, 4, true);
            EndWriteAttribute();
            WriteLiteral(" />\n                                </div>\n                                <div class=\"panel-footer produto-footer\">\n                                    <div class=\"produto-nome\">");
#nullable restore
#line 27 "D:\Documentos\GitHub\E-Commerce\E-Commerce\Views\Pedido\Carrossel.cshtml"
                                                         Write(produto.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                                    <div><h4><strong>R$ ");
#nullable restore
#line 28 "D:\Documentos\GitHub\E-Commerce\E-Commerce\Views\Pedido\Carrossel.cshtml"
                                                   Write(produto.Preco.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong></h4></div>
                                    <div class=""text-center"">
                                        <a href=""/"" class=""btn btn-success"">Adicionar</a>
                                    </div>
                                </div>
                            </div>
                        </div>
");
#nullable restore
#line 35 "D:\Documentos\GitHub\E-Commerce\E-Commerce\Views\Pedido\Carrossel.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\n            </div>\n");
#nullable restore
#line 38 "D:\Documentos\GitHub\E-Commerce\E-Commerce\Views\Pedido\Carrossel.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>

    <!-- Carrossel Controls -->
    <a class=""left carousel-control"" href=""#my-carousel"" role=""button"" data-slide=""prev"">
        <span class=""glyphicon glyphicon-chevron-left"" aria-hidden=""true""></span>
        <span class=""sr-only"">Previous</span>
    </a>
    <a class=""right carousel-control"" href=""#my-carousel"" role=""button"" data-slide=""next"">
        <span class=""glyphicon glyphicon-chevron-right"" aria-hidden=""true""></span>
        <span class=""sr-only"">Next</span>
    </a>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Produto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
