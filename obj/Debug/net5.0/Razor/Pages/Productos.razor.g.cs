#pragma checksum "C:\Users\Admin\Desktop\Pumbas.ClienteBlazor\Pages\Productos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b289cc71d902f5b1affe158f12cacc15f7d886a7"
// <auto-generated/>
#pragma warning disable 1591
namespace Pumbas.ClienteBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Admin\Desktop\Pumbas.ClienteBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Desktop\Pumbas.ClienteBlazor\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Desktop\Pumbas.ClienteBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\Desktop\Pumbas.ClienteBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\Desktop\Pumbas.ClienteBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Admin\Desktop\Pumbas.ClienteBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Admin\Desktop\Pumbas.ClienteBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Admin\Desktop\Pumbas.ClienteBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Admin\Desktop\Pumbas.ClienteBlazor\_Imports.razor"
using Pumbas.ClienteBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Admin\Desktop\Pumbas.ClienteBlazor\_Imports.razor"
using Pumbas.ClienteBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Admin\Desktop\Pumbas.ClienteBlazor\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Desktop\Pumbas.ClienteBlazor\Pages\Productos.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\Desktop\Pumbas.ClienteBlazor\Pages\Productos.razor"
using Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/Producto")]
    public partial class Productos : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::MudBlazor.MudText>(0);
            __builder.AddAttribute(1, "Typo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Typo>(
#nullable restore
#line 7 "C:\Users\Admin\Desktop\Pumbas.ClienteBlazor\Pages\Productos.razor"
               Typo.h3

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(3, "Categorias");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenComponent<global::MudBlazor.MudGrid>(5);
            __builder.AddAttribute(6, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
#nullable restore
#line 10 "C:\Users\Admin\Desktop\Pumbas.ClienteBlazor\Pages\Productos.razor"
     foreach (var item in Pro)
    {
        string Producto = "";

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<global::MudBlazor.MudItem>(7);
                __builder2.AddAttribute(8, "xs", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 13 "C:\Users\Admin\Desktop\Pumbas.ClienteBlazor\Pages\Productos.razor"
                     12

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "sm", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 13 "C:\Users\Admin\Desktop\Pumbas.ClienteBlazor\Pages\Productos.razor"
                             10

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "md", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 13 "C:\Users\Admin\Desktop\Pumbas.ClienteBlazor\Pages\Productos.razor"
                                     6

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "lg", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 13 "C:\Users\Admin\Desktop\Pumbas.ClienteBlazor\Pages\Productos.razor"
                                            4

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<global::MudBlazor.MudCard>(13);
                    __builder3.AddAttribute(14, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<global::MudBlazor.MudCardHeader>(15);
                        __builder4.AddAttribute(16, "Class", "text-center pa-4 shades-text text-white black");
                        __builder4.AddAttribute(17, "CardHeaderContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<global::MudBlazor.MudText>(18);
                            __builder5.AddAttribute(19, "Typo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Typo>(
#nullable restore
#line 17 "C:\Users\Admin\Desktop\Pumbas.ClienteBlazor\Pages\Productos.razor"
                                       Typo.h6

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(20, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
#nullable restore
#line 17 "C:\Users\Admin\Desktop\Pumbas.ClienteBlazor\Pages\Productos.razor"
__builder6.AddContent(21, item.Nombre);

#line default
#line hidden
#nullable disable
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(22, "\r\n                ");
                        __builder4.OpenComponent<global::MudBlazor.MudCardContent>(23);
                        __builder4.AddAttribute(24, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
#nullable restore
#line 22 "C:\Users\Admin\Desktop\Pumbas.ClienteBlazor\Pages\Productos.razor"
                     switch (item.Id)
                    {
                        case 1:
                            Producto = "";
                            break;


                    }

#line default
#line hidden
#nullable disable
                            __builder5.OpenComponent<global::MudBlazor.MudText>(25);
                            __builder5.AddAttribute(26, "Typo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Typo>(
#nullable restore
#line 30 "C:\Users\Admin\Desktop\Pumbas.ClienteBlazor\Pages\Productos.razor"
                                   Typo.body2

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(27, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(28, "Producto  ");
#nullable restore
#line 30 "C:\Users\Admin\Desktop\Pumbas.ClienteBlazor\Pages\Productos.razor"
__builder6.AddContent(29, Producto);

#line default
#line hidden
#nullable disable
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(30, "\r\n              \r\n                ");
                        __builder4.OpenComponent<global::MudBlazor.MudCardActions>(31);
                        __builder4.AddAttribute(32, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<global::MudBlazor.MudButton>(33);
                            __builder5.AddAttribute(34, "Link", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 36 "C:\Users\Admin\Desktop\Pumbas.ClienteBlazor\Pages\Productos.razor"
                                       $"/F/{item.Id}"

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(35, "Variant", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Variant>(
#nullable restore
#line 36 "C:\Users\Admin\Desktop\Pumbas.ClienteBlazor\Pages\Productos.razor"
                                                                  Variant.Outlined

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(36, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 36 "C:\Users\Admin\Desktop\Pumbas.ClienteBlazor\Pages\Productos.razor"
                                                                                           Color.Tertiary

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(37, "Class", "text-center");
                            __builder5.AddAttribute(38, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(39, "Ver ");
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 41 "C:\Users\Admin\Desktop\Pumbas.ClienteBlazor\Pages\Productos.razor"
    }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "C:\Users\Admin\Desktop\Pumbas.ClienteBlazor\Pages\Productos.razor"
       
    IEnumerable<Producto> Pro = new List<Producto>();
    protected override async Task OnInitializedAsync()
    {
        Pro = await ProductoService.GetAll();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductoService ProductoService { get; set; }
    }
}
#pragma warning restore 1591
