#pragma checksum "C:\xampp\htdocs\NetCoreFramework\EsercizioEntity160523\Views\Home\Libreria.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76b2740c710c80e752d4a36e1f2e3d29585b6f05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Libreria), @"mvc.1.0.view", @"/Views/Home/Libreria.cshtml")]
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
#line 1 "C:\xampp\htdocs\NetCoreFramework\EsercizioEntity160523\Views\_ViewImports.cshtml"
using EsercizioEntity160523;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\xampp\htdocs\NetCoreFramework\EsercizioEntity160523\Views\_ViewImports.cshtml"
using EsercizioEntity160523.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76b2740c710c80e752d4a36e1f2e3d29585b6f05", @"/Views/Home/Libreria.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc2241310be39f3e809569671f2ca249c0089727", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Libreria : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LibreriaModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("﻿");
#nullable restore
#line 1 "C:\xampp\htdocs\NetCoreFramework\EsercizioEntity160523\Views\Home\Libreria.cshtml"
   
    ViewData["Title"] = "Libreria";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 6 "C:\xampp\htdocs\NetCoreFramework\EsercizioEntity160523\Views\Home\Libreria.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>


<div class=""container"">
    <div class=""row"">
        <div class=""col-12"">
            <h3 class=""display-4"">Insert Autore</h3>
            Name: <input type=""text"" id=""nameAutore"" />
            <button class=""btn btn-primary"" onclick=""insertAutore()"">Insert Autore</button>
            <button class=""btn btn-primary"" onclick=""getAutore()"">Get Autore</button>
            <div id=""resultAutore""></div>
        </div>
    </div>

    <div class=""row"">
        <div class=""col-12"">
            <h3 class=""display-4"">Insert Libro</h3>
            Name: <input type=""text"" id=""nameLibro"" />
            Numero Pagine: <input type=""text"" id=""numeroLibro"" />
            <button class=""btn btn-primary"" onclick=""insertLibro()"">Insert Libro</button>
            <button class=""btn btn-primary"" onclick=""getLibro()"">Get Libro</button>
            <div id=""resultLibro""></div>
        </div>
    </div>

</div>
");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LibreriaModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
