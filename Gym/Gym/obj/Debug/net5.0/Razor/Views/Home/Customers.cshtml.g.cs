#pragma checksum "D:\Pedro\CURSO ASP NET\6-CRUD GYM\Gym\Gym\Views\Home\Customers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99d97dde846a337efc0760dec799ed3811fad150"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Customers), @"mvc.1.0.view", @"/Views/Home/Customers.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99d97dde846a337efc0760dec799ed3811fad150", @"/Views/Home/Customers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c18382eafd4a59444785fc8159a488cee9542fdd", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Customers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IQueryable<Customer>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<a href=""/Home/RegisterCustomer"" class=""btn btn-primary"">New customer</a>

<h1>Customers List</h1>
<hr />

<table class=""table table-bordered table-striped"">
    <thead class=""bg-dark text-light text-center"">
        <tr>
            <th>NAME</th>
            <th>STATE</th>
            <th>ACTIONS</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 17 "D:\Pedro\CURSO ASP NET\6-CRUD GYM\Gym\Gym\Views\Home\Customers.cshtml"
         foreach(var customer in Model)
         {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 20 "D:\Pedro\CURSO ASP NET\6-CRUD GYM\Gym\Gym\Views\Home\Customers.cshtml"
               Write(customer.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "D:\Pedro\CURSO ASP NET\6-CRUD GYM\Gym\Gym\Views\Home\Customers.cshtml"
               Write(customer.State);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>Nothing Yet</td>\r\n            </tr>\r\n");
#nullable restore
#line 24 "D:\Pedro\CURSO ASP NET\6-CRUD GYM\Gym\Gym\Views\Home\Customers.cshtml"
         }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IQueryable<Customer>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
