#pragma checksum "D:\Personal\Git\blazorstuding\AppStartBlazor\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5d16e6da12a040043472b1d54c96ea5144e3353"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "D:\Personal\Git\blazorstuding\AppStartBlazor\Pages\Index.razor"
       

    private AppStartBlazor.Domain.Car carro { get; set; }

    protected override Task OnInitializedAsync()
    {
        carro = new Domain.Car() { Id = 1, Fabricante = "Fiat", Modelo = "Uno", AnoFabricacao = 2002, Preco = 8000 };


        return base.OnInitializedAsync();
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
