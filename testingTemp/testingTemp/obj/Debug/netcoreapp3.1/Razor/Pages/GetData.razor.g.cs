#pragma checksum "C:\Users\alist\OneDrive\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\GetData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bbbf804349542cc16064ed80f3d1e6f7393a89c8"
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
#line 7 "C:\Users\alist\OneDrive\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\GetData.razor"
using ChartJs.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\alist\OneDrive\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\GetData.razor"
using ChartJs.Blazor.ChartJS.PieChart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\alist\OneDrive\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\GetData.razor"
using ChartJs.Blazor.ChartJS.Common.Properties;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\alist\OneDrive\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\GetData.razor"
using ChartJs.Blazor.Util;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/getdata")]
    public partial class GetData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>GetData</h3>\r\n\r\n");
            __builder.AddMarkupContent(1, "\r\n    ");
            __builder.OpenComponent<ChartJs.Blazor.Charts.ChartJsPieChart>(2);
            __builder.AddAttribute(3, "Config", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ChartJs.Blazor.ChartJS.PieChart.PieConfig>(
#nullable restore
#line 12 "C:\Users\alist\OneDrive\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\GetData.razor"
                                                 _config

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 12 "C:\Users\alist\OneDrive\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\GetData.razor"
                                                                 600

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "Height", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 12 "C:\Users\alist\OneDrive\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\GetData.razor"
                                                                              300

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(6, (__value) => {
#nullable restore
#line 12 "C:\Users\alist\OneDrive\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\GetData.razor"
                           _pieChartJs = (ChartJs.Blazor.Charts.ChartJsPieChart)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\Users\alist\OneDrive\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\GetData.razor"
           

        private PieConfig _config;
        private ChartJsPieChart _pieChartJs;

        protected override void OnInitialized()
        {
            _config = new PieConfig
            {
                Options = new PieOptions
                {
                    Title = new OptionsTitle
                    {
                        Display = true,
                        Text = "Sample chart from Blazor"
                    },
                    Responsive = true,
                    Animation = new ArcAnimation
                    {
                        AnimateRotate = true,
                        AnimateScale = true
                    }
                }
            };

            _config.Data.Labels.AddRange(new[] { "A", "B", "C", "D" });

            var pieSet = new PieDataset
            {
                BackgroundColor = new[] { ColorUtil.RandomColorString(), ColorUtil.RandomColorString(), ColorUtil.RandomColorString(), ColorUtil.RandomColorString() },
                BorderWidth = 0,
                HoverBackgroundColor = ColorUtil.RandomColorString(),
                HoverBorderColor = ColorUtil.RandomColorString(),
                HoverBorderWidth = 1,
                BorderColor = "#ffffff",
            };

            pieSet.Data.AddRange(new double[] { 4, 5, 6, 7 });
            _config.Data.Datasets.Add(pieSet);
        }

    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
