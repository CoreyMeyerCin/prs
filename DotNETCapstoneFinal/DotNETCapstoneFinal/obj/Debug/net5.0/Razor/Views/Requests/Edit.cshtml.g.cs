#pragma checksum "C:\prs\DotNETCapstoneFinal\DotNETCapstoneFinal\Views\Requests\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bef32fcd72e352f005c71afccc5ebafc26e6e4c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Requests_Edit), @"mvc.1.0.view", @"/Views/Requests/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bef32fcd72e352f005c71afccc5ebafc26e6e4c5", @"/Views/Requests/Edit.cshtml")]
    #nullable restore
    public class Views_Requests_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DotNETCapstoneFinal.Models.Request>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\prs\DotNETCapstoneFinal\DotNETCapstoneFinal\Views\Requests\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Edit</h1>

<h4>Request</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""Id"" />
            <div class=""form-group"">
                <label asp-for=""Description"" class=""control-label""></label>
                <input asp-for=""Description"" class=""form-control"" />
                <span asp-validation-for=""Description"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Justification"" class=""control-label""></label>
                <input asp-for=""Justification"" class=""form-control"" />
                <span asp-validation-for=""Justification"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""DeliveryMode"" class=""control-label""></label>
                <input asp-for=""DeliveryMode"" class=""form-control"" /");
            WriteLiteral(@">
                <span asp-validation-for=""DeliveryMode"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Status"" class=""control-label""></label>
                <input asp-for=""Status"" class=""form-control"" />
                <span asp-validation-for=""Status"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Total"" class=""control-label""></label>
                <input asp-for=""Total"" class=""form-control"" />
                <span asp-validation-for=""Total"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""UserId"" class=""control-label""></label>
                <select asp-for=""UserId"" class=""form-control"" asp-items=""ViewBag.UserId""></select>
                <span asp-validation-for=""UserId"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input t");
            WriteLiteral("ype=\"submit\" value=\"Save\" class=\"btn btn-primary\" />\r\n            </div>\r\n        </form>\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 58 "C:\prs\DotNETCapstoneFinal\DotNETCapstoneFinal\Views\Requests\Edit.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DotNETCapstoneFinal.Models.Request> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
