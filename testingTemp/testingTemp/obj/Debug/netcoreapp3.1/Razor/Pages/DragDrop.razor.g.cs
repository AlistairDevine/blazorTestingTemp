#pragma checksum "C:\Users\alist\OneDrive\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\DragDrop.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd10f9f8cdd9ec63cfe38e35610b32e02e33fd26"
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
            __builder.OpenComponent<testingTemp.Shared.JobsContainer>(0);
            __builder.AddAttribute(1, "Jobs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<testingTemp.Models.JobModel>>(
#nullable restore
#line 6 "C:\Users\alist\OneDrive\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\DragDrop.razor"
                     Jobs

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnStatusUpdated", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<testingTemp.Models.JobModel>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<testingTemp.Models.JobModel>(this, 
#nullable restore
#line 6 "C:\Users\alist\OneDrive\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\DragDrop.razor"
                                            HandleStatusUpdated

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.OpenComponent<testingTemp.Shared.JobList>(5);
                __builder2.AddAttribute(6, "ListStatus", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<testingTemp.Models.JobStatuses>(
#nullable restore
#line 7 "C:\Users\alist\OneDrive\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\DragDrop.razor"
                         JobStatuses.Todo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(7, "AllowedStatuses", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<testingTemp.Models.JobStatuses[]>(
#nullable restore
#line 7 "C:\Users\alist\OneDrive\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\DragDrop.razor"
                                                              new JobStatuses[] { JobStatuses.Started}

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n    ");
                __builder2.OpenComponent<testingTemp.Shared.JobList>(9);
                __builder2.AddAttribute(10, "ListStatus", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<testingTemp.Models.JobStatuses>(
#nullable restore
#line 8 "C:\Users\alist\OneDrive\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\DragDrop.razor"
                         JobStatuses.Started

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "AllowedStatuses", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<testingTemp.Models.JobStatuses[]>(
#nullable restore
#line 8 "C:\Users\alist\OneDrive\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\DragDrop.razor"
                                                                 new JobStatuses[] { JobStatuses.Todo}

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n    ");
                __builder2.OpenComponent<testingTemp.Shared.JobList>(13);
                __builder2.AddAttribute(14, "ListStatus", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<testingTemp.Models.JobStatuses>(
#nullable restore
#line 9 "C:\Users\alist\OneDrive\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\DragDrop.razor"
                         JobStatuses.Completed

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "AllowedStatuses", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<testingTemp.Models.JobStatuses[]>(
#nullable restore
#line 9 "C:\Users\alist\OneDrive\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\DragDrop.razor"
                                                                   new JobStatuses[] { JobStatuses.Started }

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(17, "\r\n\r\n<hr>\r\n");
            __builder.OpenElement(18, "p");
            __builder.AddContent(19, "Last updated job was: ");
            __builder.OpenElement(20, "strong");
            __builder.AddContent(21, 
#nullable restore
#line 13 "C:\Users\alist\OneDrive\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\DragDrop.razor"
                                  lastUpdatedJob

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n<hr>\r\n\r\n");
#nullable restore
#line 16 "C:\Users\alist\OneDrive\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\DragDrop.razor"
 foreach (var task in Jobs)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "    ");
            __builder.OpenElement(24, "p");
            __builder.AddContent(25, 
#nullable restore
#line 18 "C:\Users\alist\OneDrive\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\DragDrop.razor"
        task.Description

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(26, " - ");
            __builder.OpenElement(27, "strong");
            __builder.AddContent(28, 
#nullable restore
#line 18 "C:\Users\alist\OneDrive\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\DragDrop.razor"
                                    task.Status

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
#nullable restore
#line 19 "C:\Users\alist\OneDrive\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\DragDrop.razor"
}

#line default
#line hidden
#nullable disable
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
