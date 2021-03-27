#pragma checksum "D:\C_Sharp\blazor-planner\PlannerApp\PlannerApp.Client\Pages\Auth\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f463d2a6cdd99516c9c64cd76078f6fbbff3d68c"
// <auto-generated/>
#pragma warning disable 1591
namespace PlannerApp.Client.Pages.Auth
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\C_Sharp\blazor-planner\PlannerApp\PlannerApp.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C_Sharp\blazor-planner\PlannerApp\PlannerApp.Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\C_Sharp\blazor-planner\PlannerApp\PlannerApp.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\C_Sharp\blazor-planner\PlannerApp\PlannerApp.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\C_Sharp\blazor-planner\PlannerApp\PlannerApp.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\C_Sharp\blazor-planner\PlannerApp\PlannerApp.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\C_Sharp\blazor-planner\PlannerApp\PlannerApp.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\C_Sharp\blazor-planner\PlannerApp\PlannerApp.Client\_Imports.razor"
using PlannerApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\C_Sharp\blazor-planner\PlannerApp\PlannerApp.Client\_Imports.razor"
using PlannerApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\C_Sharp\blazor-planner\PlannerApp\PlannerApp.Client\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\C_Sharp\blazor-planner\PlannerApp\PlannerApp.Client\_Imports.razor"
using PlannerApp.Shared.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\C_Sharp\blazor-planner\PlannerApp\PlannerApp.Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\C_Sharp\blazor-planner\PlannerApp\PlannerApp.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\C_Sharp\blazor-planner\PlannerApp\PlannerApp.Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\C_Sharp\blazor-planner\PlannerApp\PlannerApp.Client\Pages\Auth\Login.razor"
using PlannerApp.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(AuthLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/auth/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-12");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.AddMarkupContent(6, "<h2>Login to your account</h2>\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(7);
            __builder.AddAttribute(8, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "D:\C_Sharp\blazor-planner\PlannerApp\PlannerApp.Client\Pages\Auth\Login.razor"
                         model

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 11 "D:\C_Sharp\blazor-planner\PlannerApp\PlannerApp.Client\Pages\Auth\Login.razor"
                                               LoginUser

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(11, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenCard>(12);
                __builder2.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(14, "\r\n                ");
                    __builder3.OpenComponent<PlannerApp.Client.Shared.AlertMessage>(15);
                    __builder3.AddAttribute(16, "Message", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "D:\C_Sharp\blazor-planner\PlannerApp\PlannerApp.Client\Pages\Auth\Login.razor"
                                        message

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(17, "MessageType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<PlannerApp.Client.Models.AlertMessageType>(
#nullable restore
#line 13 "D:\C_Sharp\blazor-planner\PlannerApp\PlannerApp.Client\Pages\Auth\Login.razor"
                                                               messageType

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(18, "\r\n                \r\n                ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(19);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(20, "\r\n                ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(21);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(22, "\r\n\r\n                ");
                    __builder3.AddMarkupContent(23, "<label>Email Name</label>\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(24);
                    __builder3.AddAttribute(25, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "D:\C_Sharp\blazor-planner\PlannerApp\PlannerApp.Client\Pages\Auth\Login.razor"
                                            model.Email

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(26, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.Email = __value, model.Email))));
                    __builder3.AddAttribute(27, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.Email));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(28, "\r\n\r\n                ");
                    __builder3.AddMarkupContent(29, "<label>Password</label>\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPassword>(30);
                    __builder3.AddAttribute(31, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "D:\C_Sharp\blazor-planner\PlannerApp\PlannerApp.Client\Pages\Auth\Login.razor"
                                             model.Password

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(32, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.Password = __value, model.Password))));
                    __builder3.AddAttribute(33, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.Password));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(34, "\r\n\r\n                <hr>\r\n\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(35);
                    __builder3.AddAttribute(36, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#nullable restore
#line 26 "D:\C_Sharp\blazor-planner\PlannerApp\PlannerApp.Client\Pages\Auth\Login.razor"
                                          Radzen.ButtonType.Submit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(37, "Text", "Login");
                    __builder3.AddAttribute(38, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 27 "D:\C_Sharp\blazor-planner\PlannerApp\PlannerApp.Client\Pages\Auth\Login.razor"
                                           Radzen.ButtonStyle.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(39, "class", "btn-block mr-2");
                    __builder3.AddAttribute(40, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 28 "D:\C_Sharp\blazor-planner\PlannerApp\PlannerApp.Client\Pages\Auth\Login.razor"
                                        isBusy

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(41, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(42);
                    __builder3.AddAttribute(43, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#nullable restore
#line 29 "D:\C_Sharp\blazor-planner\PlannerApp\PlannerApp.Client\Pages\Auth\Login.razor"
                                          Radzen.ButtonType.Button

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(44, "Text", "Register");
                    __builder3.AddAttribute(45, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 30 "D:\C_Sharp\blazor-planner\PlannerApp\PlannerApp.Client\Pages\Auth\Login.razor"
                                           Radzen.ButtonStyle.Secondary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(46, "class", "btn-block mr-2");
                    __builder3.AddAttribute(47, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 31 "D:\C_Sharp\blazor-planner\PlannerApp\PlannerApp.Client\Pages\Auth\Login.razor"
                                        isBusy

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(48, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "D:\C_Sharp\blazor-planner\PlannerApp\PlannerApp.Client\Pages\Auth\Login.razor"
                                                       NavigateToRegister

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(49, "\r\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(50, "\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(51, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "D:\C_Sharp\blazor-planner\PlannerApp\PlannerApp.Client\Pages\Auth\Login.razor"
       
    LoginRequest model = new LoginRequest();

    bool isBusy = false;
    string message = string.Empty;
    Models.AlertMessageType messageType = Models.AlertMessageType.Success;


    public async Task LoginUser()
    {
        isBusy = true;
        var result = await authService.LoginUserAsync(model);


        if (result.IsSuccess)
        {
            var userInfo = new PlannerApp.Client.Models.LocalUserInfo()
            {
                AccessToken = result.Message,
                Email = result.UserInfo["Email"],
                FirstName = result.UserInfo["FirstName"],
                LastName = result.UserInfo["LastName"],
                Id = result.UserInfo[System.Security.Claims.ClaimTypes.NameIdentifier],
            };
            await storageService.SetItemAsync("User", userInfo);

            //After login we send the user to index(Landing) page.
            navigationManager.NavigateTo("/");

        }
        else
        {
            message = result.Message;
            messageType = Models.AlertMessageType.Error;

        }
        isBusy = false;
    }
    void NavigateToRegister()
    {
        navigationManager.NavigateTo("/auth/register");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService storageService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationService authService { get; set; }
    }
}
#pragma warning restore 1591
