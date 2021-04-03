#pragma checksum "D:\C_Sharp\blazor-planner\PlannerApp\PlannerApp.Client\Shared\UserStatus.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0772e487f813cd74188a8bc9bb6c3d284678b05f"
// <auto-generated/>
#pragma warning disable 1591
namespace PlannerApp.Client.Shared
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
    public partial class UserStatus : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n    ");
                __builder2.OpenElement(3, "span");
                __builder2.AddContent(4, "Welcome ");
                __builder2.AddContent(5, 
#nullable restore
#line 5 "D:\C_Sharp\blazor-planner\PlannerApp\PlannerApp.Client\Shared\UserStatus.razor"
                   context.User.FindFirst("FirstName").Value

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddContent(6, "   |   ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(7);
                __builder2.AddAttribute(8, "Text", "Logout");
                __builder2.AddAttribute(9, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "D:\C_Sharp\blazor-planner\PlannerApp\PlannerApp.Client\Shared\UserStatus.razor"
                                                                                                                       Logout

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(10, "Class", "mr-2");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "D:\C_Sharp\blazor-planner\PlannerApp\PlannerApp.Client\Shared\UserStatus.razor"
       

    async Task Logout()
    {
        //Cascading... Question.
        var localStateProvider = (LocalAuthenticationStateProvider)authenticationStateProvider;

        await localStateProvider.LogoutAsync();
        navigationManager.NavigateTo("/auth/login");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider authenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591