#pragma checksum "C:\Users\Aymen\source\repos\BlazorSPA1\BlazorSPA1\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83416b89133d0d0adf5bc2ceb6b93f74916da6de"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorSPA1.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Aymen\source\repos\BlazorSPA1\BlazorSPA1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Aymen\source\repos\BlazorSPA1\BlazorSPA1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Aymen\source\repos\BlazorSPA1\BlazorSPA1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Aymen\source\repos\BlazorSPA1\BlazorSPA1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Aymen\source\repos\BlazorSPA1\BlazorSPA1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Aymen\source\repos\BlazorSPA1\BlazorSPA1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Aymen\source\repos\BlazorSPA1\BlazorSPA1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Aymen\source\repos\BlazorSPA1\BlazorSPA1\_Imports.razor"
using BlazorSPA1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Aymen\source\repos\BlazorSPA1\BlazorSPA1\_Imports.razor"
using BlazorSPA1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Aymen\source\repos\BlazorSPA1\BlazorSPA1\_Imports.razor"
using BlazorSPA1.Data;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\Aymen\source\repos\BlazorSPA1\BlazorSPA1\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
