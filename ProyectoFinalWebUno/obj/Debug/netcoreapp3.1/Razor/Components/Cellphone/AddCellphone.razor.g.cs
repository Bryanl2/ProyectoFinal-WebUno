#pragma checksum "C:\Users\usuario\Desktop\ProyectoFinalWebUno\ProyectoFinalWebUno\Components\Cellphone\AddCellphone.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ada199fe1ec234e46ebd744566e113136b705ce"
// <auto-generated/>
#pragma warning disable 1591
namespace ProyectoFinalWebUno.Components.Cellphone
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\usuario\Desktop\ProyectoFinalWebUno\ProyectoFinalWebUno\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\usuario\Desktop\ProyectoFinalWebUno\ProyectoFinalWebUno\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\usuario\Desktop\ProyectoFinalWebUno\ProyectoFinalWebUno\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\usuario\Desktop\ProyectoFinalWebUno\ProyectoFinalWebUno\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\usuario\Desktop\ProyectoFinalWebUno\ProyectoFinalWebUno\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\usuario\Desktop\ProyectoFinalWebUno\ProyectoFinalWebUno\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\usuario\Desktop\ProyectoFinalWebUno\ProyectoFinalWebUno\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\usuario\Desktop\ProyectoFinalWebUno\ProyectoFinalWebUno\_Imports.razor"
using ProyectoFinalWebUno;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\usuario\Desktop\ProyectoFinalWebUno\ProyectoFinalWebUno\_Imports.razor"
using ProyectoFinalWebUno.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\usuario\Desktop\ProyectoFinalWebUno\ProyectoFinalWebUno\_Imports.razor"
using ProyectoFinalWebUno.Components.Cellphone;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\usuario\Desktop\ProyectoFinalWebUno\ProyectoFinalWebUno\Components\Cellphone\AddCellphone.razor"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\usuario\Desktop\ProyectoFinalWebUno\ProyectoFinalWebUno\Components\Cellphone\AddCellphone.razor"
using Bussiness;

#line default
#line hidden
#nullable disable
    public partial class AddCellphone : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"alert alert-success text-center\">AddCellphone</h3>\r\n\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 8 "C:\Users\usuario\Desktop\ProyectoFinalWebUno\ProyectoFinalWebUno\Components\Cellphone\AddCellphone.razor"
                 oCellphone

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "form-group col-8");
                __builder2.AddAttribute(6, "style", "display:block;padding-left:25%;");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "form-group col-12 ");
                __builder2.AddMarkupContent(9, "<label>Id: </label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(10);
                __builder2.AddAttribute(11, "class", "form-control");
                __builder2.AddAttribute(12, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "C:\Users\usuario\Desktop\ProyectoFinalWebUno\ProyectoFinalWebUno\Components\Cellphone\AddCellphone.razor"
                                                         oCellphone.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => oCellphone.Id = __value, oCellphone.Id))));
                __builder2.AddAttribute(14, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => oCellphone.Id));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(15, "\r\n\r\n        ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "form-group col-12 ");
                __builder2.AddMarkupContent(18, "<label>Model: </label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(19);
                __builder2.AddAttribute(20, "class", "form-control");
                __builder2.AddAttribute(21, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\usuario\Desktop\ProyectoFinalWebUno\ProyectoFinalWebUno\Components\Cellphone\AddCellphone.razor"
                                                         oCellphone.Model

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => oCellphone.Model = __value, oCellphone.Model))));
                __builder2.AddAttribute(23, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => oCellphone.Model));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n\r\n        ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "form-group col-12");
                __builder2.AddMarkupContent(27, "<label>Brand: </label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(28);
                __builder2.AddAttribute(29, "class", "form-control");
                __builder2.AddAttribute(30, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "C:\Users\usuario\Desktop\ProyectoFinalWebUno\ProyectoFinalWebUno\Components\Cellphone\AddCellphone.razor"
                                                         oCellphone.Brand

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(31, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => oCellphone.Brand = __value, oCellphone.Brand))));
                __builder2.AddAttribute(32, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => oCellphone.Brand));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n\r\n        ");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "form-group col-12");
                __builder2.AddMarkupContent(36, "<label>Color: </label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(37);
                __builder2.AddAttribute(38, "class", "form-control");
                __builder2.AddAttribute(39, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 32 "C:\Users\usuario\Desktop\ProyectoFinalWebUno\ProyectoFinalWebUno\Components\Cellphone\AddCellphone.razor"
                                                         oCellphone.Color

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(40, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => oCellphone.Color = __value, oCellphone.Color))));
                __builder2.AddAttribute(41, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => oCellphone.Color));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n\r\n        ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "form-group col-12");
                __builder2.AddMarkupContent(45, "<label>Status: </label>\r\n            ");
                __Blazor.ProyectoFinalWebUno.Components.Cellphone.AddCellphone.TypeInference.CreateInputSelect_0(__builder2, 46, 47, "form-control", 48, 
#nullable restore
#line 38 "C:\Users\usuario\Desktop\ProyectoFinalWebUno\ProyectoFinalWebUno\Components\Cellphone\AddCellphone.razor"
                                      oCellphone.Status

#line default
#line hidden
#nullable disable
                , 49, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => oCellphone.Status = __value, oCellphone.Status)), 50, () => oCellphone.Status, 51, (__builder3) => {
                    __builder3.AddMarkupContent(52, "<option value>---Select---</option>\r\n                ");
                    __builder3.OpenElement(53, "option");
                    __builder3.AddAttribute(54, "value", 
#nullable restore
#line 41 "C:\Users\usuario\Desktop\ProyectoFinalWebUno\ProyectoFinalWebUno\Components\Cellphone\AddCellphone.razor"
                                statusActive

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(55, 
#nullable restore
#line 41 "C:\Users\usuario\Desktop\ProyectoFinalWebUno\ProyectoFinalWebUno\Components\Cellphone\AddCellphone.razor"
                                               statusActive

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(56, "\r\n                ");
                    __builder3.OpenElement(57, "option");
                    __builder3.AddAttribute(58, "value", 
#nullable restore
#line 42 "C:\Users\usuario\Desktop\ProyectoFinalWebUno\ProyectoFinalWebUno\Components\Cellphone\AddCellphone.razor"
                                statusInactive

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(59, 
#nullable restore
#line 42 "C:\Users\usuario\Desktop\ProyectoFinalWebUno\ProyectoFinalWebUno\Components\Cellphone\AddCellphone.razor"
                                                 statusInactive

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n\r\n        ");
                __builder2.OpenElement(61, "input");
                __builder2.AddAttribute(62, "type", "button");
                __builder2.AddAttribute(63, "value", "Add Celllphone");
                __builder2.AddAttribute(64, "class", "btn btn-danger btn-block");
                __builder2.AddAttribute(65, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "C:\Users\usuario\Desktop\ProyectoFinalWebUno\ProyectoFinalWebUno\Components\Cellphone\AddCellphone.razor"
                         SaveCellphone

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "C:\Users\usuario\Desktop\ProyectoFinalWebUno\ProyectoFinalWebUno\Components\Cellphone\AddCellphone.razor"
       
    string statusActive = "ACTIVO";
    string statusInactive = "INACTIVO";
    CellphoneEntity oCellphone = new CellphoneEntity();

    private void SaveCellphone()
    {
        B_Cellphone.CreateCellphone(oCellphone);
        NavManager.NavigateTo("/");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
    }
}
namespace __Blazor.ProyectoFinalWebUno.Components.Cellphone.AddCellphone
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
