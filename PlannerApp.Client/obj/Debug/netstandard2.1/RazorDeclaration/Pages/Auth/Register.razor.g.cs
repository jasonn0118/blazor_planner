// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 3 "D:\C_Sharp\blazor-planner\PlannerApp\PlannerApp.Client\Pages\Auth\Register.razor"
using PlannerApp.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(AuthLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/auth/register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "D:\C_Sharp\blazor-planner\PlannerApp\PlannerApp.Client\Pages\Auth\Register.razor"
       
    RegisterRequest model = new RegisterRequest();

    bool isBusy = false;
    string message = string.Empty;
    Models.AlertMessageType messageType = Models.AlertMessageType.Success;

    public async Task RegisterUser()
    {

        isBusy = true;
        var result = await authService.RegisterUserAsync(model);

        if (result.IsSuccess)
        {
            message = result.Message;
            messageType = Models.AlertMessageType.Success;
        }
        else
        {
            message = result.Errors.FirstOrDefault() ?? result.Message;
            messageType = Models.AlertMessageType.Error;

        }
        isBusy = false;
    }
    void NavigateToLogin()
    {
        navigationManager.NavigateTo("/auth/login");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationService authService { get; set; }
    }
}
#pragma warning restore 1591
