#pragma checksum "C:\prs\PRSCAPSTONECORRECTFINAL\PRSCAPSTONECORRECTFINAL\Views\Users\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d5ef98831b682cb3aac28b8ee6843a5601651a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Edit), @"mvc.1.0.view", @"/Views/Users/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d5ef98831b682cb3aac28b8ee6843a5601651a6", @"/Views/Users/Edit.cshtml")]
    public class Views_Users_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PRSCAPSTONECORRECTFINAL.Models.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\prs\PRSCAPSTONECORRECTFINAL\PRSCAPSTONECORRECTFINAL\Views\Users\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Edit</h1>

<h4>User</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""Id"" />
            <div class=""form-group"">
                <label asp-for=""Username"" class=""control-label""></label>
                <input asp-for=""Username"" class=""form-control"" />
                <span asp-validation-for=""Username"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Password"" class=""control-label""></label>
                <input asp-for=""Password"" class=""form-control"" />
                <span asp-validation-for=""Password"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Firstname"" class=""control-label""></label>
                <input asp-for=""Firstname"" class=""form-control"" />
                <span asp-vali");
            WriteLiteral(@"dation-for=""Firstname"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Lastname"" class=""control-label""></label>
                <input asp-for=""Lastname"" class=""form-control"" />
                <span asp-validation-for=""Lastname"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Phone"" class=""control-label""></label>
                <input asp-for=""Phone"" class=""form-control"" />
                <span asp-validation-for=""Phone"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Email"" class=""control-label""></label>
                <input asp-for=""Email"" class=""form-control"" />
                <span asp-validation-for=""Email"" class=""text-danger""></span>
            </div>
            <div class=""form-group form-check"">
                <label class=""form-check-label"">
                    <input clas");
            WriteLiteral("s=\"form-check-input\" asp-for=\"isReviewer\" /> ");
#nullable restore
#line 48 "C:\prs\PRSCAPSTONECORRECTFINAL\PRSCAPSTONECORRECTFINAL\Views\Users\Edit.cshtml"
                                                                       Write(Html.DisplayNameFor(model => model.isReviewer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </label>\r\n            </div>\r\n            <div class=\"form-group form-check\">\r\n                <label class=\"form-check-label\">\r\n                    <input class=\"form-check-input\" asp-for=\"isAdmin\" /> ");
#nullable restore
#line 53 "C:\prs\PRSCAPSTONECORRECTFINAL\PRSCAPSTONECORRECTFINAL\Views\Users\Edit.cshtml"
                                                                    Write(Html.DisplayNameFor(model => model.isAdmin));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </label>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 68 "C:\prs\PRSCAPSTONECORRECTFINAL\PRSCAPSTONECORRECTFINAL\Views\Users\Edit.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PRSCAPSTONECORRECTFINAL.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
