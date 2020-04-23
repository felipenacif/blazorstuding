#pragma checksum "D:\Personal\Git\blazorstuding\AppStartBlazor\Pages\Cars.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4f4414eefa7e2163467ef55567e1a3a216541af"
// <auto-generated/>
#pragma warning disable 1591
namespace AppStartBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Personal\Git\blazorstuding\AppStartBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Personal\Git\blazorstuding\AppStartBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Personal\Git\blazorstuding\AppStartBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Personal\Git\blazorstuding\AppStartBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Personal\Git\blazorstuding\AppStartBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Personal\Git\blazorstuding\AppStartBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Personal\Git\blazorstuding\AppStartBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Personal\Git\blazorstuding\AppStartBlazor\_Imports.razor"
using AppStartBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Personal\Git\blazorstuding\AppStartBlazor\_Imports.razor"
using AppStartBlazor.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/cars")]
    public partial class Cars : CarsBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Cars</h3>\r\n");
            __builder.AddMarkupContent(1, "<div class=\"text-right\">\r\n    <a class=\"btn btn-primary\" href=\"/carsedit\"><i class=\"oi oi-pencil\"></i> Adicionar novo</a>\r\n</div>\r\n\r\n");
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.AddMarkupContent(5, @"<thead>
        <tr>
            <th>Id</th>
            <th>Fabricante</th>
            <th>Modelo</th>
            <th>Ano</th>
            <th>Valor</th>
            <th>Editar</th>
            <th>Excluir</th>
        </tr>
    </thead>
    ");
            __builder.OpenElement(6, "tbody");
            __builder.AddMarkupContent(7, "\r\n");
#nullable restore
#line 22 "D:\Personal\Git\blazorstuding\AppStartBlazor\Pages\Cars.razor"
         if (ListaCars == null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(8, "            ");
            __builder.AddMarkupContent(9, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 25 "D:\Personal\Git\blazorstuding\AppStartBlazor\Pages\Cars.razor"
        }
        else
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "D:\Personal\Git\blazorstuding\AppStartBlazor\Pages\Cars.razor"
             foreach (var item in ListaCars)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "                ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 31 "D:\Personal\Git\blazorstuding\AppStartBlazor\Pages\Cars.razor"
                         item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 32 "D:\Personal\Git\blazorstuding\AppStartBlazor\Pages\Cars.razor"
                         item.Fabricante

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 33 "D:\Personal\Git\blazorstuding\AppStartBlazor\Pages\Cars.razor"
                         item.Modelo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 34 "D:\Personal\Git\blazorstuding\AppStartBlazor\Pages\Cars.razor"
                         item.AnoFabricacao

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 35 "D:\Personal\Git\blazorstuding\AppStartBlazor\Pages\Cars.razor"
                         item.Preco

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                    ");
            __builder.OpenElement(28, "td");
            __builder.OpenElement(29, "a");
            __builder.AddAttribute(30, "class", "btn btn-warning");
            __builder.AddAttribute(31, "href", "/carsedit/" + (
#nullable restore
#line 36 "D:\Personal\Git\blazorstuding\AppStartBlazor\Pages\Cars.razor"
                                                                    item.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(32, "<i class=\"oi oi-fork\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                    ");
            __builder.OpenElement(34, "td");
            __builder.OpenElement(35, "a");
            __builder.AddAttribute(36, "class", "btn btn-danger");
            __builder.AddAttribute(37, "href", "/carsedit/" + (
#nullable restore
#line 37 "D:\Personal\Git\blazorstuding\AppStartBlazor\Pages\Cars.razor"
                                                                    item.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(38, "<i class=\"oi oi-trash\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n");
#nullable restore
#line 39 "D:\Personal\Git\blazorstuding\AppStartBlazor\Pages\Cars.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "D:\Personal\Git\blazorstuding\AppStartBlazor\Pages\Cars.razor"
             
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(41, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
