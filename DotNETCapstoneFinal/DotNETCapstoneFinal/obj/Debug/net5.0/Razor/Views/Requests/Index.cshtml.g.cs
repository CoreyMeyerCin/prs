#pragma checksum "C:\prs\DotNETCapstoneFinal\DotNETCapstoneFinal\Views\Requests\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b638b2dc37a0d8c198a054ba924d5f807763a4a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Requests_Index), @"mvc.1.0.view", @"/Views/Requests/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b638b2dc37a0d8c198a054ba924d5f807763a4a", @"/Views/Requests/Index.cshtml")]
    public class Views_Requests_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DotNETCapstoneFinal.Models.Request>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\prs\DotNETCapstoneFinal\DotNETCapstoneFinal\Views\Requests\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\prs\DotNETCapstoneFinal\DotNETCapstoneFinal\Views\Requests\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\prs\DotNETCapstoneFinal\DotNETCapstoneFinal\Views\Requests\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Justification));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\prs\DotNETCapstoneFinal\DotNETCapstoneFinal\Views\Requests\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DeliveryMode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\prs\DotNETCapstoneFinal\DotNETCapstoneFinal\Views\Requests\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\prs\DotNETCapstoneFinal\DotNETCapstoneFinal\Views\Requests\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\prs\DotNETCapstoneFinal\DotNETCapstoneFinal\Views\Requests\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.User));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 37 "C:\prs\DotNETCapstoneFinal\DotNETCapstoneFinal\Views\Requests\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\prs\DotNETCapstoneFinal\DotNETCapstoneFinal\Views\Requests\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\prs\DotNETCapstoneFinal\DotNETCapstoneFinal\Views\Requests\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Justification));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\prs\DotNETCapstoneFinal\DotNETCapstoneFinal\Views\Requests\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DeliveryMode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\prs\DotNETCapstoneFinal\DotNETCapstoneFinal\Views\Requests\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\prs\DotNETCapstoneFinal\DotNETCapstoneFinal\Views\Requests\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "C:\prs\DotNETCapstoneFinal\DotNETCapstoneFinal\Views\Requests\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.User.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1594, "\"", 1617, 1);
#nullable restore
#line 58 "C:\prs\DotNETCapstoneFinal\DotNETCapstoneFinal\Views\Requests\Index.cshtml"
WriteAttributeValue("", 1609, item.Id, 1609, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1670, "\"", 1693, 1);
#nullable restore
#line 59 "C:\prs\DotNETCapstoneFinal\DotNETCapstoneFinal\Views\Requests\Index.cshtml"
WriteAttributeValue("", 1685, item.Id, 1685, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1748, "\"", 1771, 1);
#nullable restore
#line 60 "C:\prs\DotNETCapstoneFinal\DotNETCapstoneFinal\Views\Requests\Index.cshtml"
WriteAttributeValue("", 1763, item.Id, 1763, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 63 "C:\prs\DotNETCapstoneFinal\DotNETCapstoneFinal\Views\Requests\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DotNETCapstoneFinal.Models.Request>> Html { get; private set; }
    }
}
#pragma warning restore 1591
