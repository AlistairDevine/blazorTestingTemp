#pragma checksum "C:\Users\Dvine\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0569ab0d67c53bd49a8fb7c1eafe0f894785daae"
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
#line 1 "C:\Users\Dvine\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dvine\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Dvine\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Dvine\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Dvine\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Dvine\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Dvine\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Dvine\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\_Imports.razor"
using testingTemp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Dvine\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\_Imports.razor"
using testingTemp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Dvine\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\_Imports.razor"
using testingTemp.SessionState;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Dvine\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\_Imports.razor"
using ChartJs.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Dvine\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dvine\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\Counter.razor"
using testingTemp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Dvine\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\Counter.razor"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Counter</h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Current count: ");
            __builder.AddContent(3, 
#nullable restore
#line 9 "C:\Users\Dvine\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\Counter.razor"
                   CounterState.GetCurrentCount()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "class", "btn btn-primary");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\Dvine\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\Counter.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "Click me");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n<br>\r\n\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "row");
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "col-md-4");
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(16);
            __builder.AddAttribute(17, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 16 "C:\Users\Dvine\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\Counter.razor"
                          repair

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 16 "C:\Users\Dvine\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\Counter.razor"
                                                  ValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(20, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(21);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\r\n            \r\n\r\n            ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "form-group");
                __builder2.AddMarkupContent(25, "\r\n                ");
                __builder2.AddMarkupContent(26, "<label for=\"name\">Name:</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(27);
                __builder2.AddAttribute(28, "id", "name");
                __builder2.AddAttribute(29, "class", "form-control");
                __builder2.AddAttribute(30, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "C:\Users\Dvine\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\Counter.razor"
                                                  repair.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(31, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => repair.Name = __value, repair.Name))));
                __builder2.AddAttribute(32, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => repair.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(33, "\r\n                ");
                __Blazor.testingTemp.Pages.Counter.TypeInference.CreateValidationMessage_0(__builder2, 34, 35, 
#nullable restore
#line 23 "C:\Users\Dvine\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\Counter.razor"
                                          () => repair.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(36, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n\r\n            ");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "form-group");
                __builder2.AddMarkupContent(40, "\r\n                ");
                __builder2.AddMarkupContent(41, "<label for=\"notes\">Job notes:</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(42);
                __builder2.AddAttribute(43, "id", "notes");
                __builder2.AddAttribute(44, "class", "form-control");
                __builder2.AddAttribute(45, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "C:\Users\Dvine\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\Counter.razor"
                                                       repair.Notes

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(46, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => repair.Notes = __value, repair.Notes))));
                __builder2.AddAttribute(47, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => repair.Notes));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(48, "\r\n                ");
                __Blazor.testingTemp.Pages.Counter.TypeInference.CreateValidationMessage_1(__builder2, 49, 50, 
#nullable restore
#line 29 "C:\Users\Dvine\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\Counter.razor"
                                          () => repair.Notes

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(51, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n\r\n            ");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "form-group");
                __builder2.AddMarkupContent(55, "\r\n                ");
                __builder2.AddMarkupContent(56, "<label for=\"trade\">Type of work:</label>\r\n                ");
                __Blazor.testingTemp.Pages.Counter.TypeInference.CreateInputSelect_2(__builder2, 57, 58, "trade", 59, "text", 60, 
#nullable restore
#line 34 "C:\Users\Dvine\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\Counter.razor"
                                                                 repair.Trade

#line default
#line hidden
#nullable disable
                , 61, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => repair.Trade = __value, repair.Trade)), 62, () => repair.Trade, 63, (__builder3) => {
                    __builder3.AddMarkupContent(64, "\r\n                    ");
                    __builder3.AddMarkupContent(65, "<option value>--Select Trade--</option>\r\n                    ");
                    __builder3.AddMarkupContent(66, "<option value=\"Carpenter\">Carpenter</option>\r\n                    ");
                    __builder3.AddMarkupContent(67, "<option value=\"Electrician\">Electrician</option>\r\n                    ");
                    __builder3.AddMarkupContent(68, "<option value=\"Gas\">Gas</option>\r\n                    ");
                    __builder3.AddMarkupContent(69, "<option value=\"Plumber\">Plumber</option>\r\n                ");
                }
                );
                __builder2.AddMarkupContent(70, "\r\n                ");
                __Blazor.testingTemp.Pages.Counter.TypeInference.CreateValidationMessage_3(__builder2, 71, 72, 
#nullable restore
#line 41 "C:\Users\Dvine\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\Counter.razor"
                                          () => repair.Trade

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(73, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\r\n\r\n            ");
                __builder2.OpenElement(75, "div");
                __builder2.AddAttribute(76, "class", "form-group");
                __builder2.AddMarkupContent(77, "\r\n                ");
                __builder2.AddMarkupContent(78, "<label for=\"hours\">Hours worked:</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(79);
                __builder2.AddAttribute(80, "id", "hours");
                __builder2.AddAttribute(81, "class", "form-control");
                __builder2.AddAttribute(82, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 46 "C:\Users\Dvine\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\Counter.razor"
                                                   repair.Hours

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(83, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => repair.Hours = __value, repair.Hours))));
                __builder2.AddAttribute(84, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => repair.Hours));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(85, "\r\n                ");
                __Blazor.testingTemp.Pages.Counter.TypeInference.CreateValidationMessage_4(__builder2, 86, 87, 
#nullable restore
#line 47 "C:\Users\Dvine\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\Counter.razor"
                                          () => repair.Hours

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(88, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(89, "\r\n\r\n            ");
                __builder2.AddMarkupContent(90, "<button type=\"submit\">Save.</button>\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(91, "\r\n\r\n        ");
            __builder.AddMarkupContent(92, "<div>\r\n            <span id=\"resultJson\"></span>\r\n        </div>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "C:\Users\Dvine\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\Counter.razor"
       
    private int currentCount = 0;

    private void IncrementCount()
    {
        //Session State management calls the GetCurrentCount method for the current count
        int CurrentCount = CounterState.GetCurrentCount();
        //Increment the counter
        CurrentCount++;
        //Set Current count on the Session State object
        CounterState.SetCurrentCount(CurrentCount);
    }

    private RepairForm repair = new RepairForm
    {
        Name = "John",
        Notes = "Sink, shower and toilet are broken.",
        Trade = "Plumber",
        Hours = "2"
    };

    private void ValidSubmit()
    {
        Debug.WriteLine("ValidSubmit");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CounterState CounterState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
namespace __Blazor.testingTemp.Pages.Counter
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "type", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
