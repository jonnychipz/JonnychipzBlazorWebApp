#pragma checksum "D:\Projects\BlazorDemo\JonnychipzBlazorWebApp\client\Pages\Home.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "309f47d2e6919e353d4ea94224ec52ef31b9a50e"
// <auto-generated/>
#pragma warning disable 1591
namespace JonnychipzBlazorWebApp.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Projects\BlazorDemo\JonnychipzBlazorWebApp\client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\BlazorDemo\JonnychipzBlazorWebApp\client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\BlazorDemo\JonnychipzBlazorWebApp\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\BlazorDemo\JonnychipzBlazorWebApp\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\BlazorDemo\JonnychipzBlazorWebApp\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\BlazorDemo\JonnychipzBlazorWebApp\client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projects\BlazorDemo\JonnychipzBlazorWebApp\client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projects\BlazorDemo\JonnychipzBlazorWebApp\client\_Imports.razor"
using JonnychipzBlazorWebApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projects\BlazorDemo\JonnychipzBlazorWebApp\client\_Imports.razor"
using JonnychipzBlazorWebApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Projects\BlazorDemo\JonnychipzBlazorWebApp\client\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\BlazorDemo\JonnychipzBlazorWebApp\client\Pages\Home.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projects\BlazorDemo\JonnychipzBlazorWebApp\client\Pages\Home.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/home")]
    public partial class Home : JonnychipzBlazorWebApp.Pages.HomeComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenHeading>(3);
                __builder2.AddAttribute(4, "Size", "H1");
                __builder2.AddAttribute(5, "Text", "Home");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "col-md-12");
                __builder2.OpenComponent<Radzen.Blazor.RadzenHeading>(9);
                __builder2.AddAttribute(10, "Size", "H3");
                __builder2.AddAttribute(11, "Text", "Welcome to Jonnychipz Containerised Web App");
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Localization.IStringLocalizer<Home> L { get; set; }
    }
}
#pragma warning restore 1591
