#pragma checksum "C:\Users\Aymen\source\repos\BlazorSPA1\BlazorSPA1\Pages\DeleteEmployee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c21d3f093e29d468afe0f28890b9affdaadbf9db"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/deleteemployee/{id}")]
    public partial class DeleteEmployee : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Confirm Delete</h2>\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Are you sure you want to delete this Employee with Id :");
            __builder.OpenElement(3, "b");
            __builder.AddContent(4, " ");
            __builder.AddContent(5, 
#nullable restore
#line 6 "C:\Users\Aymen\source\repos\BlazorSPA1\BlazorSPA1\Pages\DeleteEmployee.razor"
                                                               id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n<br>\r\n");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-md-4");
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "table");
            __builder.AddAttribute(11, "class", "table");
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.OpenElement(13, "tr");
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.AddMarkupContent(15, "<td>Name</td>\r\n            ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 12 "C:\Users\Aymen\source\repos\BlazorSPA1\BlazorSPA1\Pages\DeleteEmployee.razor"
                 employee.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.OpenElement(20, "tr");
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.AddMarkupContent(22, "<td>Department</td>\r\n            ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 16 "C:\Users\Aymen\source\repos\BlazorSPA1\BlazorSPA1\Pages\DeleteEmployee.razor"
                 employee.Department

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.OpenElement(27, "tr");
            __builder.AddMarkupContent(28, "\r\n            ");
            __builder.AddMarkupContent(29, "<td>Designation</td>\r\n            ");
            __builder.OpenElement(30, "td");
            __builder.AddContent(31, 
#nullable restore
#line 20 "C:\Users\Aymen\source\repos\BlazorSPA1\BlazorSPA1\Pages\DeleteEmployee.razor"
                 employee.Designation

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n        ");
            __builder.OpenElement(34, "tr");
            __builder.AddMarkupContent(35, "\r\n            ");
            __builder.AddMarkupContent(36, "<td>Company</td>\r\n            ");
            __builder.OpenElement(37, "td");
            __builder.AddContent(38, 
#nullable restore
#line 24 "C:\Users\Aymen\source\repos\BlazorSPA1\BlazorSPA1\Pages\DeleteEmployee.razor"
                 employee.CompanyID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n        ");
            __builder.OpenElement(41, "tr");
            __builder.AddMarkupContent(42, "\r\n            ");
            __builder.AddMarkupContent(43, "<td>City</td>\r\n            ");
            __builder.OpenElement(44, "td");
            __builder.AddContent(45, 
#nullable restore
#line 28 "C:\Users\Aymen\source\repos\BlazorSPA1\BlazorSPA1\Pages\DeleteEmployee.razor"
                 employee.City

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n    ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "form-group");
            __builder.AddMarkupContent(51, "\r\n        ");
            __builder.OpenElement(52, "input");
            __builder.AddAttribute(53, "type", "button");
            __builder.AddAttribute(54, "value", "Delete");
            __builder.AddAttribute(55, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\Aymen\source\repos\BlazorSPA1\BlazorSPA1\Pages\DeleteEmployee.razor"
                                                       Delete

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(56, "class", "btn btn-primary");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n        ");
            __builder.OpenElement(58, "input");
            __builder.AddAttribute(59, "type", "button");
            __builder.AddAttribute(60, "value", "Cancel");
            __builder.AddAttribute(61, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\Aymen\source\repos\BlazorSPA1\BlazorSPA1\Pages\DeleteEmployee.razor"
                                                       Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(62, "class", "btn");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Users\Aymen\source\repos\BlazorSPA1\BlazorSPA1\Pages\DeleteEmployee.razor"
       

    [Parameter]
    public string id { get; set; }
    Employee employee = new Employee();

    protected override async Task OnInitializedAsync()
    {
        employee = await EmployeeService.SingleEmployee(id);
    }

    protected async Task Delete()
    {
        await EmployeeService.DeleteEmployee(id);
        NavigationManager.NavigateTo("listemployees");
    }

    void Cancel()
    {
        NavigationManager.NavigateTo("listemployees");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IEmployeeService EmployeeService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
