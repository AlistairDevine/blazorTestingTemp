#pragma checksum "C:\Users\alist\OneDrive\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\DragDrop.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd10f9f8cdd9ec63cfe38e35610b32e02e33fd26"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#nullable restore
#line 1 "C:\Users\alist\OneDrive\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\DragDrop.razor"
using testingTemp.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/dragdrop")]
    public partial class DragDrop : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\Users\alist\OneDrive\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\DragDrop.razor"
       
    List<JobModel> Jobs = new List<JobModel>();
    string lastUpdatedJob = "";

    protected override void OnInitialized()
    {
        Jobs.Add(new JobModel { Id = 1, Description = "Mow the lawn", Status = JobStatuses.Todo, LastUpdated = DateTime.Now });
        Jobs.Add(new JobModel { Id = 2, Description = "Go to the gym", Status = JobStatuses.Todo, LastUpdated = DateTime.Now });
        Jobs.Add(new JobModel { Id = 3, Description = "Call Ollie", Status = JobStatuses.Todo, LastUpdated = DateTime.Now });
        Jobs.Add(new JobModel { Id = 4, Description = "Fix bike tyre", Status = JobStatuses.Todo, LastUpdated = DateTime.Now });
        Jobs.Add(new JobModel { Id = 5, Description = "Finish blog post", Status = JobStatuses.Todo, LastUpdated = DateTime.Now });
    }

    void HandleStatusUpdated(JobModel updatedJob)
    {
        lastUpdatedJob = updatedJob.Description;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591