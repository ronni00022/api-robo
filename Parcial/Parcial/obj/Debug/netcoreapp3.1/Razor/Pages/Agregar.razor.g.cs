#pragma checksum "D:\Quinto Cuatrimestre\PROG III\Segundo Parcial\Parcial\Parcial\Pages\Agregar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa3ddf277444ee1c269cf007c13f32c9c10809e5"
// <auto-generated/>
#pragma warning disable 1591
namespace Parcial.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Quinto Cuatrimestre\PROG III\Segundo Parcial\Parcial\Parcial\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Quinto Cuatrimestre\PROG III\Segundo Parcial\Parcial\Parcial\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Quinto Cuatrimestre\PROG III\Segundo Parcial\Parcial\Parcial\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Quinto Cuatrimestre\PROG III\Segundo Parcial\Parcial\Parcial\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Quinto Cuatrimestre\PROG III\Segundo Parcial\Parcial\Parcial\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Quinto Cuatrimestre\PROG III\Segundo Parcial\Parcial\Parcial\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Quinto Cuatrimestre\PROG III\Segundo Parcial\Parcial\Parcial\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Quinto Cuatrimestre\PROG III\Segundo Parcial\Parcial\Parcial\_Imports.razor"
using Parcial;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Quinto Cuatrimestre\PROG III\Segundo Parcial\Parcial\Parcial\_Imports.razor"
using Parcial.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Quinto Cuatrimestre\PROG III\Segundo Parcial\Parcial\Parcial\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Quinto Cuatrimestre\PROG III\Segundo Parcial\Parcial\Parcial\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Agregar")]
    public partial class Agregar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card");
            __builder.AddAttribute(2, "style", "width: 70%; margin-left:15%");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "nav");
            __builder.AddAttribute(5, "class", "navbar navbar-light bg-light");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "container-fluid");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.AddMarkupContent(10, "<a class=\"navbar-brand\">Cedula</a>\r\n            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "d-flex");
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "input");
            __builder.AddAttribute(15, "class", "form-control me-2");
            __builder.AddAttribute(16, "type", "search");
            __builder.AddAttribute(17, "placeholder", "");
            __builder.AddAttribute(18, "aria-label", "Search");
            __builder.AddAttribute(19, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "D:\Quinto Cuatrimestre\PROG III\Segundo Parcial\Parcial\Parcial\Pages\Agregar.razor"
                                    cedula

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cedula = __value, cedula));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenElement(22, "button");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "D:\Quinto Cuatrimestre\PROG III\Segundo Parcial\Parcial\Parcial\Pages\Agregar.razor"
                                  getdatos

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "class", "btn btn-outline-success");
            __builder.AddMarkupContent(25, "\r\n                    <i class=\"oi oi-magnifying-glass\" aria-hidden=\"true\"></i>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n    ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "card-body");
            __builder.AddMarkupContent(32, "\r\n        <br>\r\n        ");
            __builder.OpenElement(33, "form");
            __builder.AddMarkupContent(34, "\r\n            ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "form-row");
            __builder.AddMarkupContent(37, "\r\n                ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "col");
            __builder.AddMarkupContent(40, "\r\n                    ");
            __builder.AddMarkupContent(41, "<label for=\"formGroupExampleInput\">Nombre</label>\r\n                    ");
            __builder.OpenElement(42, "input");
            __builder.AddAttribute(43, "value", 
#nullable restore
#line 23 "D:\Quinto Cuatrimestre\PROG III\Segundo Parcial\Parcial\Parcial\Pages\Agregar.razor"
                                   nombre

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(44, "type", "text");
            __builder.AddAttribute(45, "class", "form-control");
            __builder.AddAttribute(46, "placeholder", "Nombre");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "col");
            __builder.AddMarkupContent(51, "\r\n                    ");
            __builder.AddMarkupContent(52, "<label for=\"formGroupExampleInput\">Apellido</label>\r\n                    ");
            __builder.OpenElement(53, "input");
            __builder.AddAttribute(54, "value", 
#nullable restore
#line 27 "D:\Quinto Cuatrimestre\PROG III\Segundo Parcial\Parcial\Parcial\Pages\Agregar.razor"
                                   apellido

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(55, "type", "text");
            __builder.AddAttribute(56, "class", "form-control");
            __builder.AddAttribute(57, "placeholder", "Apellido");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                ");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "col");
            __builder.AddMarkupContent(62, "\r\n                    ");
            __builder.AddMarkupContent(63, "<label for=\"formGroupExampleInput\">Fecha Nacimiento</label>\r\n                    ");
            __builder.OpenElement(64, "input");
            __builder.AddAttribute(65, "class", "form-control");
            __builder.AddAttribute(66, "type", "date");
            __builder.AddAttribute(67, "value", 
#nullable restore
#line 31 "D:\Quinto Cuatrimestre\PROG III\Segundo Parcial\Parcial\Parcial\Pages\Agregar.razor"
                                                                    fecha

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(68, "id", "example-date-input");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n        <br>\r\n        ");
            __builder.OpenElement(73, "form");
            __builder.AddMarkupContent(74, "\r\n            ");
            __builder.OpenElement(75, "div");
            __builder.AddAttribute(76, "class", "form-row");
            __builder.AddMarkupContent(77, "\r\n                ");
            __builder.OpenElement(78, "div");
            __builder.AddAttribute(79, "class", "col");
            __builder.AddMarkupContent(80, "\r\n                    ");
            __builder.AddMarkupContent(81, "<label for=\"formGroupExampleInput\">Latitud</label>\r\n                    ");
            __builder.OpenElement(82, "input");
            __builder.AddAttribute(83, "type", "text");
            __builder.AddAttribute(84, "class", "form-control");
            __builder.AddAttribute(85, "placeholder", "Latitud");
            __builder.AddAttribute(86, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 41 "D:\Quinto Cuatrimestre\PROG III\Segundo Parcial\Parcial\Parcial\Pages\Agregar.razor"
                                         latitud

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(87, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => latitud = __value, latitud));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n                ");
            __builder.OpenElement(90, "div");
            __builder.AddAttribute(91, "class", "col");
            __builder.AddMarkupContent(92, "\r\n                    ");
            __builder.AddMarkupContent(93, "<label for=\"formGroupExampleInput\">Longitud</label>\r\n                    ");
            __builder.OpenElement(94, "input");
            __builder.AddAttribute(95, "type", "text");
            __builder.AddAttribute(96, "class", "form-control");
            __builder.AddAttribute(97, "placeholder", "Longitud");
            __builder.AddAttribute(98, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 45 "D:\Quinto Cuatrimestre\PROG III\Segundo Parcial\Parcial\Parcial\Pages\Agregar.razor"
                                         longitud

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(99, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => longitud = __value, longitud));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n                ");
            __builder.OpenElement(102, "div");
            __builder.AddAttribute(103, "class", "col");
            __builder.AddMarkupContent(104, "\r\n                    ");
            __builder.AddMarkupContent(105, "<label for=\"formGroupExampleInput\">Provincia</label>\r\n                    ");
            __builder.OpenElement(106, "select");
            __builder.AddAttribute(107, "id", "Provincia");
            __builder.AddAttribute(108, "name", "Provincia");
            __builder.AddAttribute(109, "class", "form-control");
            __builder.AddAttribute(110, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 49 "D:\Quinto Cuatrimestre\PROG III\Segundo Parcial\Parcial\Parcial\Pages\Agregar.razor"
                                   provincia

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(111, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => provincia = __value, provincia));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(112, "\r\n                        ");
            __builder.OpenElement(113, "option");
            __builder.AddAttribute(114, "value", true);
            __builder.AddContent(115, "Seleccione...");
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n");
#nullable restore
#line 51 "D:\Quinto Cuatrimestre\PROG III\Segundo Parcial\Parcial\Parcial\Pages\Agregar.razor"
                         if (LS_P != null)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "D:\Quinto Cuatrimestre\PROG III\Segundo Parcial\Parcial\Parcial\Pages\Agregar.razor"
                             foreach (var item in LS_P)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(117, "                                ");
            __builder.OpenElement(118, "option");
            __builder.AddAttribute(119, "value", 
#nullable restore
#line 55 "D:\Quinto Cuatrimestre\PROG III\Segundo Parcial\Parcial\Parcial\Pages\Agregar.razor"
                                                item.NOMBRE

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(120, 
#nullable restore
#line 55 "D:\Quinto Cuatrimestre\PROG III\Segundo Parcial\Parcial\Parcial\Pages\Agregar.razor"
                                                              item.NOMBRE

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n");
#nullable restore
#line 56 "D:\Quinto Cuatrimestre\PROG III\Segundo Parcial\Parcial\Parcial\Pages\Agregar.razor"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "D:\Quinto Cuatrimestre\PROG III\Segundo Parcial\Parcial\Parcial\Pages\Agregar.razor"
                             
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(122, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\r\n            <br>\r\n            ");
            __builder.OpenElement(126, "div");
            __builder.AddAttribute(127, "class", "form-row");
            __builder.AddMarkupContent(128, "\r\n                ");
            __builder.OpenElement(129, "div");
            __builder.AddAttribute(130, "class", "col");
            __builder.AddMarkupContent(131, "\r\n                    ");
            __builder.AddMarkupContent(132, "<label for=\"exampleFormControlTextarea1\">Descripcion del Robo</label>\r\n                    ");
            __builder.OpenElement(133, "textarea");
            __builder.AddAttribute(134, "class", "form-control");
            __builder.AddAttribute(135, "id", "exampleFormControlTextarea1");
            __builder.AddAttribute(136, "rows", "3");
            __builder.AddAttribute(137, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 67 "D:\Quinto Cuatrimestre\PROG III\Segundo Parcial\Parcial\Parcial\Pages\Agregar.razor"
                                      desc_robo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(138, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => desc_robo = __value, desc_robo));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(140, "\r\n                ");
            __builder.OpenElement(141, "div");
            __builder.AddAttribute(142, "class", "col");
            __builder.AddMarkupContent(143, "\r\n                    ");
            __builder.AddMarkupContent(144, "<label for=\"formGroupExampleInput\">Valor</label>\r\n                    ");
            __builder.OpenElement(145, "input");
            __builder.AddAttribute(146, "type", "text");
            __builder.AddAttribute(147, "class", "form-control");
            __builder.AddAttribute(148, "placeholder", "Longitud");
            __builder.AddAttribute(149, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 71 "D:\Quinto Cuatrimestre\PROG III\Segundo Parcial\Parcial\Parcial\Pages\Agregar.razor"
                                         valor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(150, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => valor = __value, valor));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(151, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(152, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(153, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(154, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(155, "\r\n    ");
            __builder.OpenElement(156, "div");
            __builder.AddAttribute(157, "class", "card-footer");
            __builder.AddMarkupContent(158, "\r\n        ");
            __builder.OpenElement(159, "button");
            __builder.AddAttribute(160, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 77 "D:\Quinto Cuatrimestre\PROG III\Segundo Parcial\Parcial\Parcial\Pages\Agregar.razor"
                          NewAgregar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(161, "style", "width:100%");
            __builder.AddAttribute(162, "class", "btn btn-primary");
            __builder.AddAttribute(163, "type", "button");
            __builder.AddContent(164, "Agregar");
            __builder.CloseElement();
            __builder.AddMarkupContent(165, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(166, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 81 "D:\Quinto Cuatrimestre\PROG III\Segundo Parcial\Parcial\Parcial\Pages\Agregar.razor"
       

    string cedula = "";
    string nombre = "";
    string apellido = "";
    string fecha = "";
    string latitud = "";
    string longitud = "";
    string desc_robo = "";
    string valor = "";

    private async Task getdatos()
    {
        var url = $"https://api.adamix.net/apec/cedula/{cedula}";
        var data = await http.GetJsonAsync<CEDULA>(url);
        nombre = data.Nombres;
        apellido = data.Apellido1;
        fecha = Convert.ToDateTime(data.FechaNacimiento).ToString("yyy-MM-dd");
    }

    List<provincia> LS_P = null;
    string provincia = "";
    protected override async Task OnInitializedAsync()
    {
        var url = "https://api-robov1.herokuapp.com/api/Provinvias";
        var datos = await  http.GetJsonAsync<List<provincia>>(url);
        LS_P = datos;
    }

    private async Task NewAgregar()
    {
        try
        {
            var url = $"https://api-robov1.herokuapp.com/api/Registrar_R/{cedula}/{desc_robo}/{valor}/{provincia}/{latitud}/{longitud}";
            var datos = await http.GetJsonAsync<MENSAJE>(url);

            await js.InvokeAsync<object>("msjAlert", "Registrado Correctamente", "success");
        }
        catch (Exception e)
        {
            await js.InvokeAsync<object>("msjAlert", "Error al Registrar", "error");
        }


    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
