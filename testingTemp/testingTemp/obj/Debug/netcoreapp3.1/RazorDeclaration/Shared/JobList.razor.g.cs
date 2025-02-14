#pragma checksum "C:\Users\alist\OneDrive\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Shared\JobList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f6ed4c484f15698121654677cf9977fa0931f16"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace testingTemp.Shared
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
#nullable restore
#line 1 "C:\Users\alist\OneDrive\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Shared\JobList.razor"
using testingTemp.Models;

#line default
#line hidden
#nullable disable
    public partial class JobList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\Users\alist\OneDrive\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Shared\JobList.razor"
       

    [CascadingParameter] JobsContainer Container { get; set; }
    [Parameter] public JobStatuses ListStatus { get; set; }
    [Parameter] public JobStatuses[] AllowedStatuses { get; set; }

    List<JobModel> Jobs = new List<JobModel>();
    string dropClass = "";

    protected override void OnParametersSet()
    {
        Jobs.Clear();
        Jobs.AddRange(Container.Jobs.Where(x => x.Status == ListStatus));
    }

    private void HandleDragEnter()
    {
        if (ListStatus == Container.Payload.Status) return;

        if (AllowedStatuses != null && !AllowedStatuses.Contains(Container.Payload.Status))
        {
            dropClass = "no-drop";
        }
        else
        {
            dropClass = "can-drop";
        }
    }

    private void HandleDragLeave()
    {
        dropClass = "";
    }

    private async Task HandleDrop()
    {
        dropClass = "";

        if (AllowedStatuses != null && !AllowedStatuses.Contains(Container.Payload.Status)) return;

        await Container.UpdateJobAsync(ListStatus);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
