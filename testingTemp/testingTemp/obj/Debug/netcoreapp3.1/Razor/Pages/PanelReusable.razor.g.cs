#pragma checksum "C:\Users\alist\OneDrive\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\PanelReusable.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ad653bf46999cfea4ea2bd71e782141a0061cb1"
// <auto-generated/>
#pragma warning disable 1591
namespace testingTemp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\alist\OneDrive\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\alist\OneDrive\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\alist\OneDrive\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\alist\OneDrive\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\alist\OneDrive\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\alist\OneDrive\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\alist\OneDrive\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\alist\OneDrive\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\_Imports.razor"
using testingTemp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\alist\OneDrive\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\_Imports.razor"
using testingTemp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\alist\OneDrive\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\_Imports.razor"
using testingTemp.SessionState;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\alist\OneDrive\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\_Imports.razor"
using ChartJs.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\alist\OneDrive\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\alist\OneDrive\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\_Imports.razor"
using BlazorTransitionableRoute;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\alist\OneDrive\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\_Imports.razor"
using Blazorme;

#line default
#line hidden
#nullable disable
    public partial class PanelReusable : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>PanelReusable</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "bg-danger m-2");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "bg-dark text-white text-2x1 p-2 font-weight-bold text-center");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddContent(7, 
#nullable restore
#line 5 "C:\Users\alist\OneDrive\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\PanelReusable.razor"
         Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "p-6");
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.AddContent(13, 
#nullable restore
#line 8 "C:\Users\alist\OneDrive\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\PanelReusable.razor"
         childContent

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "C:\Users\alist\OneDrive\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\PanelReusable.razor"
       
    [Parameter]
    public string Title { get; set; }

    [Parameter]
    public RenderFragment childContent { get; set; }

    [Parameter]
    public string TitleStyle { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
