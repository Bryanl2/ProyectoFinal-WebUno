#pragma checksum "C:\Users\usuario\Desktop\ProyectoFinalWebUno\ProyectoFinalWebUno\Components\Cellphone\UpdateCellphone.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15b0d1181e67265c10392961c6c47c9b4208a268"
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
#line 2 "C:\Users\usuario\Desktop\ProyectoFinalWebUno\ProyectoFinalWebUno\Components\Cellphone\UpdateCellphone.razor"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\usuario\Desktop\ProyectoFinalWebUno\ProyectoFinalWebUno\Components\Cellphone\UpdateCellphone.razor"
using Bussiness;

#line default
#line hidden
#nullable disable
    public partial class UpdateCellphone : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 8 "C:\Users\usuario\Desktop\ProyectoFinalWebUno\ProyectoFinalWebUno\Components\Cellphone\UpdateCellphone.razor"
                 oCellphone

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "form-group");
                __builder2.AddMarkupContent(5, "<label>Name:</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(6);
                __builder2.AddAttribute(7, "class", "form-control");
                __builder2.AddAttribute(8, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "C:\Users\usuario\Desktop\ProyectoFinalWebUno\ProyectoFinalWebUno\Components\Cellphone\UpdateCellphone.razor"
                                                     oCellphone.Model

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => oCellphone.Model = __value, oCellphone.Model))));
                __builder2.AddAttribute(10, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => oCellphone.Model));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(11, "\r\n\r\n    ");
                __builder2.OpenElement(12, "input");
                __builder2.AddAttribute(13, "type", "button");
                __builder2.AddAttribute(14, "class", "btn btn-danger btn-block");
                __builder2.AddAttribute(15, "value", "Update Cellphone");
                __builder2.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\usuario\Desktop\ProyectoFinalWebUno\ProyectoFinalWebUno\Components\Cellphone\UpdateCellphone.razor"
                                                                                             SaveCellphone

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\Users\usuario\Desktop\ProyectoFinalWebUno\ProyectoFinalWebUno\Components\Cellphone\UpdateCellphone.razor"
       
    [Parameter]
    public string idCellphone { get; set; }

    CellphoneEntity oCellphone = new CellphoneEntity();

    private void SaveCellphone()
    {

        B_Cellphone.UpdateCellphone(oCellphone);
        NavManager.NavigateTo("/");
    }

    protected override async Task OnInitializedAsync()
    {
        oCellphone = B_Cellphone.GetCellphoneById(idCellphone);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
    }
}
#pragma warning restore 1591