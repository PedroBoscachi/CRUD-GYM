#pragma checksum "D:\Pedro\CURSO ASP NET\6-CRUD GYM\Gym\Gym\Views\Home\Employees.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3cd470b72936f966fe19f4b31e3bec7c340eb03a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Employees), @"mvc.1.0.view", @"/Views/Home/Employees.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Pedro\CURSO ASP NET\6-CRUD GYM\Gym\Gym\Views\_ViewImports.cshtml"
using Gym;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Pedro\CURSO ASP NET\6-CRUD GYM\Gym\Gym\Views\_ViewImports.cshtml"
using Gym.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cd470b72936f966fe19f4b31e3bec7c340eb03a", @"/Views/Home/Employees.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c18382eafd4a59444785fc8159a488cee9542fdd", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Employees : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IQueryable<Employee>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h1>Employees List</h1>
<hr />

<table class=""table table-bordered table-striped"">
    <thead class=""bg-dark text-light text-center"">
        <tr>
            <th>NAME</th>
            <th>E-MAIL</th>
            <th>ACTIONS</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 15 "D:\Pedro\CURSO ASP NET\6-CRUD GYM\Gym\Gym\Views\Home\Employees.cshtml"
         foreach(var employee in Model)
         {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 18 "D:\Pedro\CURSO ASP NET\6-CRUD GYM\Gym\Gym\Views\Home\Employees.cshtml"
               Write(employee.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 19 "D:\Pedro\CURSO ASP NET\6-CRUD GYM\Gym\Gym\Views\Home\Employees.cshtml"
               Write(employee.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>Nothing yet</td>\r\n            </tr>\r\n");
#nullable restore
#line 22 "D:\Pedro\CURSO ASP NET\6-CRUD GYM\Gym\Gym\Views\Home\Employees.cshtml"
         }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IQueryable<Employee>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
