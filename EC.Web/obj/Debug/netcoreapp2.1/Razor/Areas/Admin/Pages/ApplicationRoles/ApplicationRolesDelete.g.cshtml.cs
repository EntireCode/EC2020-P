#pragma checksum "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationRoles\ApplicationRolesDelete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38200a626fd9d0d874a774e517289aede93d14a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(EC.Web.Areas.Admin.Pages.ApplicationRoles.Areas_Admin_Pages_ApplicationRoles_ApplicationRolesDelete), @"mvc.1.0.razor-page", @"/Areas/Admin/Pages/ApplicationRoles/ApplicationRolesDelete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Admin/Pages/ApplicationRoles/ApplicationRolesDelete.cshtml", typeof(EC.Web.Areas.Admin.Pages.ApplicationRoles.Areas_Admin_Pages_ApplicationRoles_ApplicationRolesDelete), null)]
namespace EC.Web.Areas.Admin.Pages.ApplicationRoles
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\_ViewImports.cshtml"
using EC.Web.Areas.Identity;

#line default
#line hidden
#line 3 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\_ViewImports.cshtml"
using EC.Web.ViewModels;

#line default
#line hidden
#line 5 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\_ViewImports.cshtml"
using EC.Web.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38200a626fd9d0d874a774e517289aede93d14a3", @"/Areas/Admin/Pages/ApplicationRoles/ApplicationRolesDelete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8362ecfa30045c25d108ad16c073e5146b6e706d", @"/Areas/Admin/Pages/_ViewImports.cshtml")]
    public class Areas_Admin_Pages_ApplicationRoles_ApplicationRolesDelete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationRoles\ApplicationRolesDelete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(87, 177, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Application Role</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(265, 63, false);
#line 16 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationRoles\ApplicationRolesDelete.cshtml"
       Write(Html.DisplayNameFor(model => model.ApplicationRole.Description));

#line default
#line hidden
            EndContext();
            BeginContext(328, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(372, 59, false);
#line 19 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationRoles\ApplicationRolesDelete.cshtml"
       Write(Html.DisplayFor(model => model.ApplicationRole.Description));

#line default
#line hidden
            EndContext();
            BeginContext(431, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(475, 67, false);
#line 22 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationRoles\ApplicationRolesDelete.cshtml"
       Write(Html.DisplayNameFor(model => model.ApplicationRole.CreatedDateTime));

#line default
#line hidden
            EndContext();
            BeginContext(542, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(586, 63, false);
#line 25 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationRoles\ApplicationRolesDelete.cshtml"
       Write(Html.DisplayFor(model => model.ApplicationRole.CreatedDateTime));

#line default
#line hidden
            EndContext();
            BeginContext(649, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(693, 56, false);
#line 28 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationRoles\ApplicationRolesDelete.cshtml"
       Write(Html.DisplayNameFor(model => model.ApplicationRole.Name));

#line default
#line hidden
            EndContext();
            BeginContext(749, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(793, 52, false);
#line 31 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationRoles\ApplicationRolesDelete.cshtml"
       Write(Html.DisplayFor(model => model.ApplicationRole.Name));

#line default
#line hidden
            EndContext();
            BeginContext(845, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(889, 66, false);
#line 34 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationRoles\ApplicationRolesDelete.cshtml"
       Write(Html.DisplayNameFor(model => model.ApplicationRole.NormalizedName));

#line default
#line hidden
            EndContext();
            BeginContext(955, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(999, 62, false);
#line 37 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationRoles\ApplicationRolesDelete.cshtml"
       Write(Html.DisplayFor(model => model.ApplicationRole.NormalizedName));

#line default
#line hidden
            EndContext();
            BeginContext(1061, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1105, 68, false);
#line 40 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationRoles\ApplicationRolesDelete.cshtml"
       Write(Html.DisplayNameFor(model => model.ApplicationRole.ConcurrencyStamp));

#line default
#line hidden
            EndContext();
            BeginContext(1173, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1217, 64, false);
#line 43 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationRoles\ApplicationRolesDelete.cshtml"
       Write(Html.DisplayFor(model => model.ApplicationRole.ConcurrencyStamp));

#line default
#line hidden
            EndContext();
            BeginContext(1281, 470, true);
            WriteLiteral(@"
        </dd>
    </dl>
    <div class=""form-group"">
        <label class=""control-label"">Menus Assigned</label>
        <div class=""cpl-md-offset-2 col-md-10"">
            <table class=""table table-hover table-striped table-responsive-sm"">
                <thead>
                    <tr>
                        <th>Menu Full Name</th>
                        <th>Assigned</th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 57 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationRoles\ApplicationRolesDelete.cshtml"
                      
                        foreach (var menu in Model.AssignedRoleMenusDataList)
                        {

#line default
#line hidden
            BeginContext(1881, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(1911, 131, true);
            WriteLiteral("\r\n                            <tr>\r\n                                <td class=\"align-middle\">\r\n                                    ");
            EndContext();
            BeginContext(2043, 17, false);
#line 63 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationRoles\ApplicationRolesDelete.cshtml"
                               Write(menu.MenuFullName);

#line default
#line hidden
            EndContext();
            BeginContext(2060, 79, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n");
            EndContext();
            BeginContext(2613, 148, true);
            WriteLiteral("                                    <label class=\"switch switch-3d switch-text switch-info mb-xl-3\">\r\n                                        <input");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2761, "\"", 2781, 1);
#line 71 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationRoles\ApplicationRolesDelete.cshtml"
WriteAttributeValue("", 2769, menu.MenuId, 2769, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2782, 38, true);
            WriteLiteral(" type=\"checkbox\" class=\"switch-input\" ");
            EndContext();
            BeginContext(2822, 54, false);
#line 71 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationRoles\ApplicationRolesDelete.cshtml"
                                                                                                     Write(Html.Raw(menu.IsAssigned ? "checked=\"checked\"" : ""));

#line default
#line hidden
            EndContext();
            BeginContext(2877, 304, true);
            WriteLiteral(@">
                                        <span class=""switch-label"" data-on=""On"" data-off=""Off""></span>
                                        <span class=""switch-handle""></span>
                                    </label>
                                </td>
                            </tr>
");
            EndContext();
#line 77 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationRoles\ApplicationRolesDelete.cshtml"
                        }
                    

#line default
#line hidden
            BeginContext(3231, 80, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n    ");
            EndContext();
            BeginContext(3311, 231, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2bdbbb4e0c545839c2c6c0ae888a767", async() => {
                BeginContext(3331, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(3341, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cd7cce6c09da402381f131cbc1f1b550", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 84 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationRoles\ApplicationRolesDelete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ApplicationRole.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3393, 98, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-outline-danger btn-sm\" /> |\r\n        ");
                EndContext();
                BeginContext(3491, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a6f6397e3f642b6b60958659c17f510", async() => {
                    BeginContext(3513, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3529, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3542, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ApplicationRolesDeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ApplicationRolesDeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ApplicationRolesDeleteModel>)PageContext?.ViewData;
        public ApplicationRolesDeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
