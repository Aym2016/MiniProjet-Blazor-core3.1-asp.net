#pragma checksum "C:\Users\Aymen\source\repos\BlazorSPA1\BlazorSPA1\Pages\ListCompanies.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e33f2426519366c0cae59cee883502af6969a40c"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorSPA1.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/listcompanies")]
    public partial class ListCompanies : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Company Details</h2>\r\n");
            __builder.AddMarkupContent(1, "<p>\r\n    <a href=\"/addcompany\">Create New Company</a>\r\n</p>\r\n");
#nullable restore
#line 8 "C:\Users\Aymen\source\repos\BlazorSPA1\BlazorSPA1\Pages\ListCompanies.razor"
 if (companies== null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<p>Loading page...</p>\r\n");
#nullable restore
#line 11 "C:\Users\Aymen\source\repos\BlazorSPA1\BlazorSPA1\Pages\ListCompanies.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddMarkupContent(8, "<thead>\r\n            <tr>\r\n                <th>Name</th>\r\n                \r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(9, "tbody");
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 22 "C:\Users\Aymen\source\repos\BlazorSPA1\BlazorSPA1\Pages\ListCompanies.razor"
             foreach (var company in companies)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                ");
            __builder.OpenElement(12, "tr");
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 25 "C:\Users\Aymen\source\repos\BlazorSPA1\BlazorSPA1\Pages\ListCompanies.razor"
                         company.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    \r\n                    ");
            __builder.OpenElement(17, "td");
            __builder.AddMarkupContent(18, "\r\n                        ");
            __builder.OpenElement(19, "a");
            __builder.AddAttribute(20, "href", "/editcompany/" + (
#nullable restore
#line 28 "C:\Users\Aymen\source\repos\BlazorSPA1\BlazorSPA1\Pages\ListCompanies.razor"
                                               company.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(21, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                        ");
            __builder.OpenElement(23, "a");
            __builder.AddAttribute(24, "href", "/deletecompany/" + (
#nullable restore
#line 29 "C:\Users\Aymen\source\repos\BlazorSPA1\BlazorSPA1\Pages\ListCompanies.razor"
                                                 company.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(25, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
#nullable restore
#line 32 "C:\Users\Aymen\source\repos\BlazorSPA1\BlazorSPA1\Pages\ListCompanies.razor"

            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(29, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n");
#nullable restore
#line 36 "C:\Users\Aymen\source\repos\BlazorSPA1\BlazorSPA1\Pages\ListCompanies.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\Aymen\source\repos\BlazorSPA1\BlazorSPA1\Pages\ListCompanies.razor"
       
    List<Company> companies;

    protected override async Task OnInitializedAsync()
    {
        companies = await CompanyService.GetCompanies();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICompanyService CompanyService { get; set; }
    }
}
#pragma warning restore 1591
