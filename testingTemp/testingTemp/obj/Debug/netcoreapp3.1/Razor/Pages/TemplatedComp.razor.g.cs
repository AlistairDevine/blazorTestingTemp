#pragma checksum "C:\Users\Dvine\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\TemplatedComp.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8e58d3cf9152f0070f1a3f10e746daf0737ff3f"
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
#line 3 "C:\Users\Dvine\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\TemplatedComp.razor"
using EndToEnd.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Dvine\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\TemplatedComp.razor"
using EndToEndDB.Data.EndToEnd;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/tempcomp")]
    public partial class TemplatedComp : OwningComponentBase<BookDataService>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Book table</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(1);
            __builder.AddAttribute(2, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n        ");
                __builder2.OpenElement(4, "h4");
                __builder2.AddContent(5, "Hello, ");
                __builder2.AddContent(6, 
#nullable restore
#line 14 "C:\Users\Dvine\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\TemplatedComp.razor"
                    context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(7, ".");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(8, "\r\n        <br>\r\n        ");
                __builder2.OpenElement(9, "p");
                __builder2.AddMarkupContent(10, "\r\n            \r\n            ");
                __builder2.OpenElement(11, "button");
                __builder2.AddAttribute(12, "class", "btn btn-primary");
                __builder2.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\Dvine\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\TemplatedComp.razor"
                                                      AddNewBook

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(14, "\r\n                Add New Book\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(15, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n\r\n");
#nullable restore
#line 23 "C:\Users\Dvine\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\TemplatedComp.razor"
         if (booksData == null)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(17, "            \r\n            ");
                __builder2.AddMarkupContent(18, "<p><em>Error Message...</em></p>\r\n");
#nullable restore
#line 27 "C:\Users\Dvine\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\TemplatedComp.razor"
        }
        else
        {
            

#line default
#line hidden
#nullable disable
                __builder2.AddContent(19, "            ");
                __Blazor.testingTemp.Pages.TemplatedComp.TypeInference.CreateTableTemplate_0(__builder2, 20, 21, 
#nullable restore
#line 57 "C:\Users\Dvine\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\TemplatedComp.razor"
                                  booksData

#line default
#line hidden
#nullable disable
                , 22, (__builder3) => {
                    __builder3.AddMarkupContent(23, "\r\n                    ");
                    __builder3.AddMarkupContent(24, "<th>Book:</th>\r\n                    ");
                    __builder3.AddMarkupContent(25, "<th>Description</th>\r\n                    ");
                    __builder3.AddMarkupContent(26, "<th>Price</th>\r\n                    ");
                    __builder3.AddMarkupContent(27, "<th>Author</th>\r\n                ");
                }
                , 28, (book) => (__builder3) => {
                    __builder3.AddMarkupContent(29, "\r\n                    ");
                    __builder3.OpenElement(30, "td");
                    __builder3.AddContent(31, 
#nullable restore
#line 65 "C:\Users\Dvine\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\TemplatedComp.razor"
                         book.BookTitle

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(32, "\r\n                    ");
                    __builder3.OpenElement(33, "td");
                    __builder3.AddContent(34, 
#nullable restore
#line 66 "C:\Users\Dvine\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\TemplatedComp.razor"
                         book.BookDescription

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(35, "\r\n                    ");
                    __builder3.OpenElement(36, "td");
                    __builder3.AddContent(37, 
#nullable restore
#line 67 "C:\Users\Dvine\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\TemplatedComp.razor"
                         book.BookPrice

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(38, "\r\n                    ");
                    __builder3.OpenElement(39, "td");
                    __builder3.AddContent(40, 
#nullable restore
#line 68 "C:\Users\Dvine\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\TemplatedComp.razor"
                         book.BookAuthor

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(41, "\r\n                ");
                }
                );
                __builder2.AddMarkupContent(42, "\r\n");
#nullable restore
#line 71 "C:\Users\Dvine\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\TemplatedComp.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(43, "\r\n");
#nullable restore
#line 73 "C:\Users\Dvine\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\TemplatedComp.razor"
         if (ShowPopup)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(44, "            \r\n            ");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "modal");
                __builder2.AddAttribute(47, "tabindex", "-1");
                __builder2.AddAttribute(48, "style", "display:block");
                __builder2.AddAttribute(49, "role", "dialog");
                __builder2.AddMarkupContent(50, "\r\n                ");
                __builder2.OpenElement(51, "div");
                __builder2.AddAttribute(52, "class", "modal-dialog");
                __builder2.AddMarkupContent(53, "\r\n                    ");
                __builder2.OpenElement(54, "div");
                __builder2.AddAttribute(55, "class", "modal-content");
                __builder2.AddMarkupContent(56, "\r\n                        ");
                __builder2.OpenElement(57, "div");
                __builder2.AddAttribute(58, "class", "modal-header");
                __builder2.AddMarkupContent(59, "\r\n                            ");
                __builder2.AddMarkupContent(60, "<h3 class=\"modal-title\">Edit Book</h3>\r\n                            \r\n                            ");
                __builder2.OpenElement(61, "button");
                __builder2.AddAttribute(62, "type", "button");
                __builder2.AddAttribute(63, "class", "close");
                __builder2.AddAttribute(64, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 82 "C:\Users\Dvine\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\TemplatedComp.razor"
                                                                          ClosePopup

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(65, "\r\n                                ");
                __builder2.AddMarkupContent(66, "<span aria-hidden=\"true\">X</span>\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n                        ");
                __builder2.OpenElement(69, "div");
                __builder2.AddAttribute(70, "class", "modal-body");
                __builder2.AddMarkupContent(71, "\r\n                            ");
                __builder2.OpenElement(72, "input");
                __builder2.AddAttribute(73, "class", "form-control");
                __builder2.AddAttribute(74, "type", "text");
                __builder2.AddAttribute(75, "placeholder", "BookTitle");
                __builder2.AddAttribute(76, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 87 "C:\Users\Dvine\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\TemplatedComp.razor"
                                                                                                   objBookData.BookTitle

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(77, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objBookData.BookTitle = __value, objBookData.BookTitle));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n                            ");
                __builder2.OpenElement(79, "input");
                __builder2.AddAttribute(80, "class", "form-control");
                __builder2.AddAttribute(81, "type", "text");
                __builder2.AddAttribute(82, "placeholder", "BookDescription");
                __builder2.AddAttribute(83, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 88 "C:\Users\Dvine\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\TemplatedComp.razor"
                                                                                                         objBookData.BookDescription

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(84, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objBookData.BookDescription = __value, objBookData.BookDescription));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\r\n                            ");
                __builder2.OpenElement(86, "input");
                __builder2.AddAttribute(87, "class", "form-control");
                __builder2.AddAttribute(88, "type", "text");
                __builder2.AddAttribute(89, "placeholder", "BookPrice");
                __builder2.AddAttribute(90, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 89 "C:\Users\Dvine\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\TemplatedComp.razor"
                                                                                                   objBookData.BookPrice

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(91, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objBookData.BookPrice = __value, objBookData.BookPrice));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(92, "\r\n                            ");
                __builder2.OpenElement(93, "input");
                __builder2.AddAttribute(94, "class", "form-control");
                __builder2.AddAttribute(95, "type", "text");
                __builder2.AddAttribute(96, "placeholder", "BookAuthor");
                __builder2.AddAttribute(97, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 90 "C:\Users\Dvine\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\TemplatedComp.razor"
                                                                                                    objBookData.BookAuthor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(98, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objBookData.BookAuthor = __value, objBookData.BookAuthor));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(99, "\r\n                            <br>\r\n                            \r\n                            ");
                __builder2.OpenElement(100, "buton");
                __builder2.AddAttribute(101, "class", "btn btn-primary");
                __builder2.AddAttribute(102, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 93 "C:\Users\Dvine\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\TemplatedComp.razor"
                                                                     SaveBook

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(103, "\r\n                                Save\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(104, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(105, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(106, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(107, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(108, "\r\n");
#nullable restore
#line 100 "C:\Users\Dvine\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\TemplatedComp.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(109, "    ");
            }
            ));
            __builder.AddAttribute(110, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(111, "\r\n\r\n        ");
                __builder2.AddMarkupContent(112, "<p><em>Sign In for more information</em></p>\r\n\r\n        \r\n\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 112 "C:\Users\Dvine\Documents\GitHub\blazorTestingTemp\testingTemp\testingTemp\Pages\TemplatedComp.razor"
       

    //Authentication is available as a CascadingParameter
    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }

    List<BookData> booksData;

    BookData objBookData = new BookData();

    bool ShowPopup = false;

    protected override async Task OnInitializedAsync()
    {
        //Get the current user
        var user = (await authenticationStateTask).User;
        //Get the book data for the current user
        //We access BookDataService using @Service
        booksData = await Service.GetBookAsync(user.Identity.Name);
    }

    void ClosePopup()
    {
        //Close the popup
        ShowPopup = false;
    }

    void AddNewBook()
    {
        //Make new book
        objBookData = new BookData();
        //Set Id to 0 so we know it is a new record
        objBookData.BookId = 0;
        //Open the popup
        ShowPopup = true;
    }

    async Task SaveBook()
    {
        //Close popup
        ShowPopup = false;
        //Get the current user
        var user = (await authenticationStateTask).User;
        //A new book will have the Id set to 0
        if (objBookData.BookId == 0)
        {
            //Create new book
            BookData objNewBookData = new BookData();
            objNewBookData.BookTitle = objBookData.BookTitle;
            objNewBookData.BookDescription = objBookData.BookDescription;
            objNewBookData.BookPrice = Convert.ToInt32(objBookData.BookPrice);
            objNewBookData.BookAuthor = objBookData.BookAuthor;
            objNewBookData.UserName = user.Identity.Name;

            //Save the result
            var result = Service.CreateBookAsync(objNewBookData);
        }
        else
        {
            //This is an update
        }
        //Get the books for the current user
        booksData = await Service.GetBookAsync(user.Identity.Name);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider Auth { get; set; }
    }
}
namespace __Blazor.testingTemp.Pages.TemplatedComp
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateTableTemplate_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IReadOnlyList<TItem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg2)
        {
        __builder.OpenComponent<global::testingTemp.Shared.TableTemplate<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "TableHeader", __arg1);
        __builder.AddAttribute(__seq2, "RowTemplate", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
