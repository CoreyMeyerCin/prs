#pragma checksum "C:\prs\DotNETCapstoneFinal\DotNETCapstoneFinal\Views\RequestLines\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66f3457bd090935d1ac7186b5a1e6edb068206bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RequestLines_Index), @"mvc.1.0.view", @"/Views/RequestLines/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66f3457bd090935d1ac7186b5a1e6edb068206bc", @"/Views/RequestLines/Index.cshtml")]
    public class Views_RequestLines_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DotNETCapstoneFinal.RequestLine>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\prs\DotNETCapstoneFinal\DotNETCapstoneFinal\Views\RequestLines\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\prs\DotNETCapstoneFinal\DotNETCapstoneFinal\Views\RequestLines\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Request));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\prs\DotNETCapstoneFinal\DotNETCapstoneFinal\Views\RequestLines\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Product));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\prs\DotNETCapstoneFinal\DotNETCapstoneFinal\Views\RequestLines\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 28 "C:\prs\DotNETCapstoneFinal\DotNETCapstoneFinal\Views\RequestLines\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "C:\prs\DotNETCapstoneFinal\DotNETCapstoneFinal\Views\RequestLines\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Request.DeliveryMode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "C:\prs\DotNETCapstoneFinal\DotNETCapstoneFinal\Views\RequestLines\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Product.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\prs\DotNETCapstoneFinal\DotNETCapstoneFinal\Views\RequestLines\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 996, "\"", 1019, 1);
#nullable restore
#line 40 "C:\prs\DotNETCapstoneFinal\DotNETCapstoneFinal\Views\RequestLines\Index.cshtml"
WriteAttributeValue("", 1011, item.Id, 1011, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1072, "\"", 1095, 1);
#nullable restore
#line 41 "C:\prs\DotNETCapstoneFinal\DotNETCapstoneFinal\Views\RequestLines\Index.cshtml"
WriteAttributeValue("", 1087, item.Id, 1087, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1150, "\"", 1173, 1);
#nullable restore
#line 42 "C:\prs\DotNETCapstoneFinal\DotNETCapstoneFinal\Views\RequestLines\Index.cshtml"
WriteAttributeValue("", 1165, item.Id, 1165, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 45 "C:\prs\DotNETCapstoneFinal\DotNETCapstoneFinal\Views\RequestLines\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DotNETCapstoneFinal.RequestLine>> Html { get; private set; }
    }
}
#pragma warning restore 1591
