#pragma checksum "D:\Personal\Git\blazorstuding\AppStartBlazor\Pages\CarEdit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae19ac669177f661fb199c1b26387850cca65a7e"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/carsedit")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/carsedit/{IdCarro}")]
    public partial class CarEdit : CarEditBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddAttribute(1, "class", "page-title");
            __builder.AddContent(2, "Editando o Carro: ");
            __builder.AddContent(3, 
#nullable restore
#line 5 "D:\Personal\Git\blazorstuding\AppStartBlazor\Pages\CarEdit.razor"
                                          carro.Fabricante

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(4, "/");
            __builder.AddContent(5, 
#nullable restore
#line 5 "D:\Personal\Git\blazorstuding\AppStartBlazor\Pages\CarEdit.razor"
                                                            carro.Modelo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n\r\n");
#nullable restore
#line 7 "D:\Personal\Git\blazorstuding\AppStartBlazor\Pages\CarEdit.razor"
 if (!Saved)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(8);
            __builder.AddAttribute(9, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 9 "D:\Personal\Git\blazorstuding\AppStartBlazor\Pages\CarEdit.razor"
                      carro

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 9 "D:\Personal\Git\blazorstuding\AppStartBlazor\Pages\CarEdit.razor"
                                             SubmitForm

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(12, "\r\n\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(13);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(15);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n\r\n        ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "form-group row");
                __builder2.AddMarkupContent(19, "\r\n            ");
                __builder2.AddMarkupContent(20, "<label for=\"Fabricante\" class=\"col-sm-3\">Fabricante</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(21);
                __builder2.AddAttribute(22, "id", "Fabricante");
                __builder2.AddAttribute(23, "class", "form-control col-sm-8");
                __builder2.AddAttribute(24, "placeholder", "Informe o nome do Fabricante");
                __builder2.AddAttribute(25, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "D:\Personal\Git\blazorstuding\AppStartBlazor\Pages\CarEdit.razor"
                                                    carro.Fabricante

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => carro.Fabricante = __value, carro.Fabricante))));
                __builder2.AddAttribute(27, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => carro.Fabricante));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\r\n            ");
                __Blazor.AppStartBlazor.Pages.CarEdit.TypeInference.CreateValidationMessage_0(__builder2, 29, 30, "offset-sm-3", 31, 
#nullable restore
#line 17 "D:\Personal\Git\blazorstuding\AppStartBlazor\Pages\CarEdit.razor"
                                                          () => carro.Fabricante

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(32, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n        ");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "form-group row");
                __builder2.AddMarkupContent(36, "\r\n            ");
                __builder2.AddMarkupContent(37, "<label for=\"Modelo\" class=\"col-sm-3\">Modelo</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(38);
                __builder2.AddAttribute(39, "id", "Modelo");
                __builder2.AddAttribute(40, "class", "form-control col-sm-8");
                __builder2.AddAttribute(41, "placeholder", "Informe o nome do Modelo");
                __builder2.AddAttribute(42, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "D:\Personal\Git\blazorstuding\AppStartBlazor\Pages\CarEdit.razor"
                                                carro.Modelo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => carro.Modelo = __value, carro.Modelo))));
                __builder2.AddAttribute(44, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => carro.Modelo));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(45, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n        ");
                __builder2.OpenElement(47, "div");
                __builder2.AddAttribute(48, "class", "form-group row");
                __builder2.AddMarkupContent(49, "\r\n            ");
                __builder2.AddMarkupContent(50, "<label for=\"AnoFabricacao\" class=\"col-sm-3\">Ano de Fabricacao</label>\r\n            ");
                __Blazor.AppStartBlazor.Pages.CarEdit.TypeInference.CreateInputNumber_1(__builder2, 51, 52, "AnoFabricacao", 53, "form-control col-sm-3", 54, 
#nullable restore
#line 25 "D:\Personal\Git\blazorstuding\AppStartBlazor\Pages\CarEdit.razor"
                                                         carro.AnoFabricacao

#line default
#line hidden
#nullable disable
                , 55, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => carro.AnoFabricacao = __value, carro.AnoFabricacao)), 56, () => carro.AnoFabricacao);
                __builder2.AddMarkupContent(57, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n        ");
                __builder2.OpenElement(59, "div");
                __builder2.AddAttribute(60, "class", "form-group row");
                __builder2.AddMarkupContent(61, "\r\n            ");
                __builder2.AddMarkupContent(62, "<label for=\"Preco\" class=\"col-sm-3\">Preco</label>\r\n            ");
                __Blazor.AppStartBlazor.Pages.CarEdit.TypeInference.CreateInputNumber_2(__builder2, 63, 64, "Preco", 65, "form-control col-sm-3", 66, 
#nullable restore
#line 29 "D:\Personal\Git\blazorstuding\AppStartBlazor\Pages\CarEdit.razor"
                                                 carro.Preco

#line default
#line hidden
#nullable disable
                , 67, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => carro.Preco = __value, carro.Preco)), 68, () => carro.Preco);
                __builder2.AddMarkupContent(69, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n        ");
                __builder2.OpenElement(71, "div");
                __builder2.AddAttribute(72, "class", "form-group row");
                __builder2.AddMarkupContent(73, "\r\n            ");
                __builder2.AddMarkupContent(74, "<label for=\"Preco\" class=\"col-sm-3\">País de Origem</label>\r\n");
#nullable restore
#line 33 "D:\Personal\Git\blazorstuding\AppStartBlazor\Pages\CarEdit.razor"
             if (paises == null)
            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(75, "            ");
                __builder2.AddMarkupContent(76, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 36 "D:\Personal\Git\blazorstuding\AppStartBlazor\Pages\CarEdit.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(77, "            ");
                __Blazor.AppStartBlazor.Pages.CarEdit.TypeInference.CreateInputSelect_3(__builder2, 78, 79, "PaisOrigem", 80, "form-control col-sm-3", 81, 
#nullable restore
#line 39 "D:\Personal\Git\blazorstuding\AppStartBlazor\Pages\CarEdit.razor"
                                                                                    alpha2Code

#line default
#line hidden
#nullable disable
                , 82, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => alpha2Code = __value, alpha2Code)), 83, () => alpha2Code, 84, (__builder3) => {
                    __builder3.AddMarkupContent(85, "\r\n");
#nullable restore
#line 40 "D:\Personal\Git\blazorstuding\AppStartBlazor\Pages\CarEdit.razor"
                 foreach (var item in paises)
                {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(86, "                    ");
                    __builder3.OpenElement(87, "option");
                    __builder3.AddAttribute(88, "value", 
#nullable restore
#line 42 "D:\Personal\Git\blazorstuding\AppStartBlazor\Pages\CarEdit.razor"
                                    item.alpha2Code

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(89, 
#nullable restore
#line 42 "D:\Personal\Git\blazorstuding\AppStartBlazor\Pages\CarEdit.razor"
                                                      item.name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(90, "\r\n");
#nullable restore
#line 43 "D:\Personal\Git\blazorstuding\AppStartBlazor\Pages\CarEdit.razor"
                }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(91, "            ");
                }
                );
                __builder2.AddMarkupContent(92, "\r\n");
#nullable restore
#line 45 "D:\Personal\Git\blazorstuding\AppStartBlazor\Pages\CarEdit.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(93, "        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(94, "\r\n\r\n        <hr>\r\n\r\n        ");
                __builder2.AddMarkupContent(95, "<div>\r\n            <button type=\"submit\" class=\"btn btn-primary\">Salvar</button>\r\n        </div>\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(96, "\r\n");
#nullable restore
#line 54 "D:\Personal\Git\blazorstuding\AppStartBlazor\Pages\CarEdit.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(97, "    ");
            __builder.OpenElement(98, "div");
            __builder.AddAttribute(99, "class", "alert" + " " + (
#nullable restore
#line 57 "D:\Personal\Git\blazorstuding\AppStartBlazor\Pages\CarEdit.razor"
                       StatusClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(100, "\r\n        ");
            __builder.AddContent(101, 
#nullable restore
#line 58 "D:\Personal\Git\blazorstuding\AppStartBlazor\Pages\CarEdit.razor"
         Message

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(102, " <br>\r\n        ");
            __builder.AddMarkupContent(103, "<a href=\"/cars\">Ver todos os carros cadastrados</a>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n");
#nullable restore
#line 61 "D:\Personal\Git\blazorstuding\AppStartBlazor\Pages\CarEdit.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.AppStartBlazor.Pages.CarEdit
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "For", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
