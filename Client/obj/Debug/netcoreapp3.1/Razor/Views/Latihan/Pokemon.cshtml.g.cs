#pragma checksum "E:\MATERI METRODATA\API\Client\Views\Latihan\Pokemon.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc2009d7df204bd40600a2d556806b2cc47222c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Latihan_Pokemon), @"mvc.1.0.view", @"/Views/Latihan/Pokemon.cshtml")]
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
#line 1 "E:\MATERI METRODATA\API\Client\Views\_ViewImports.cshtml"
using Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\MATERI METRODATA\API\Client\Views\_ViewImports.cshtml"
using Client.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc2009d7df204bd40600a2d556806b2cc47222c5", @"/Views/Latihan/Pokemon.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3332004e6f18ccbec22253d7e177fe1fd5f40969", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Latihan_Pokemon : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\MATERI METRODATA\API\Client\Views\Latihan\Pokemon.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table id=""tablepoke"" class=""table table-light table-striped table-bordered border-light"" style=""margin-top: 50px;"">
    <thead>
        <tr>
            <th scope=""col"">No</th>
            <th scope=""col"">Name</th>
            <th scope=""col"">Action</th>
        </tr>
    </thead>
    <tbody id=""tableSW"">
        <tr>
            <td></td>
            <td></td>
            <td></td>
        </tr>
    </tbody>
</table>

<!-- Modal -->
<div class=""modal fade"" id=""DetailPokemon"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Pokedex</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>


            <div cla");
            WriteLiteral(@"ss=""modal-body"">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col-md-5"">
                            <img class=""picture"" width=""200"" height=""200"" style="" border: solid; border-radius:100px;"" />
                        </div>
                        <div class=""col-md-7"">
                            <p class=""name""></p>
                            <p id=""type""> </p> 
                            <div class=""row"">
                                <div class=""col-md-6"">
                            <p>Ability</p>
                            <ul class=""abilities"">
                            </ul>
                            </div>
                                <div class=""col-md-6"">
                                <p> Moves </p>
                                    <ul>
                                        <li class=""moves1""></li>
                                        <li class=""moves2""></li>
                            ");
            WriteLiteral(@"            <li class=""moves3""></li>
                                    </ul>
                            </div>
                            </div>
                            <p>Health Point</p>
                            <div class=""progress"">
                                <div class=""hp progress-bar bg-success"" role=""progressbar"" aria-valuenow=""50"" aria-valuemin=""0"" aria-valuemax=""100"">
                                </div>
                            </div>
                            <p>Attack Point</p>
                            <div class=""progress"">
                                <div class=""ap progress-bar bg-danger"" role=""progressbar""  aria-valuenow=""50"" aria-valuemin=""0"" aria-valuemax=""100"">
                                </div>
                            </div>
                            <p>Defense Point</p>
                            <div class=""progress"">
                                <div class=""dp progress-bar"" role=""progressbar""  aria-valuenow=""50"" aria-valuemin=""");
            WriteLiteral(@"0"" aria-valuemax=""100"">
                                </div>
                            </div>
                            <p>Speed Point</p>
                            <div class=""progress"">
                                <div class=""sp progress-bar bg-info"" role=""progressbar""  aria-valuenow=""50"" aria-valuemin=""0"" aria-valuemax=""100"">
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                </div>
            </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591