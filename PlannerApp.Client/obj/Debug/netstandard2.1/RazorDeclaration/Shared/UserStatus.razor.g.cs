// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
