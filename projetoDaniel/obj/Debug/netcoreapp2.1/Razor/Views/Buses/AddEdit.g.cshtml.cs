#pragma checksum "C:\Users\Daniel\Source\Repos\Projeto1\projetoDaniel\Views\Buses\AddEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06607939157a931128c5d2c08837b7591610c30f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Buses_AddEdit), @"mvc.1.0.view", @"/Views/Buses/AddEdit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Buses/AddEdit.cshtml", typeof(AspNetCore.Views_Buses_AddEdit))]
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
#line 1 "C:\Users\Daniel\Source\Repos\Projeto1\projetoDaniel\Views\_Viewimports.cshtml"
using projetoDaniel.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06607939157a931128c5d2c08837b7591610c30f", @"/Views/Buses/AddEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"604612b571f09e7bc8418dcc91fe686735d1d82e", @"/Views/_Viewimports.cshtml")]
    public class Views_Buses_AddEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Daniel\Source\Repos\Projeto1\projetoDaniel\Views\Buses\AddEdit.cshtml"
  
    ViewBag.Title = "Adicionar Ônibus";


#line default
#line hidden
            BeginContext(50, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(57, 13, false);
#line 6 "C:\Users\Daniel\Source\Repos\Projeto1\projetoDaniel\Views\Buses\AddEdit.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(70, 782, true);
            WriteLiteral(@"</h2>
<form method=""post"">


    <div class=""form-group"">
        <label>Prefixo</label>
        <input type=""text"" asp-for=""Prefixo"" class=""form-control"" autofocus />
    </div>

    <div class=""form-group"">
        <label>Linha</label>
        <input type=""number"" name=""linha"" class=""form-control"" />
    </div>
    <div class=""form-group"">
        <label>Empresa</label>
        <input type=""text"" name=""empresa"" class=""form-control"" />
    </div>
    <div class=""form-group"">
        <label>Quantidade de Lugares</label>
        <input type=""number"" name=""Quantidadelugares"" class=""form-control"" />
    </div>

    <button type=""submit"" class=""btn btn-outline-dark"" >Enviar</button>
    <a href=""/Buses"" class=""btn btn-info"">Cancelar</a>



</form>
");
            EndContext();
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
