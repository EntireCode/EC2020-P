#pragma checksum "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationMenus\ApplicationMenusDelete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0274968b19c4145545c14d79a72950935503ca0e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(EC.Web.Areas.Admin.Pages.ApplicationMenus.Areas_Admin_Pages_ApplicationMenus_ApplicationMenusDelete), @"mvc.1.0.razor-page", @"/Areas/Admin/Pages/ApplicationMenus/ApplicationMenusDelete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Admin/Pages/ApplicationMenus/ApplicationMenusDelete.cshtml", typeof(EC.Web.Areas.Admin.Pages.ApplicationMenus.Areas_Admin_Pages_ApplicationMenus_ApplicationMenusDelete), null)]
namespace EC.Web.Areas.Admin.Pages.ApplicationMenus
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0274968b19c4145545c14d79a72950935503ca0e", @"/Areas/Admin/Pages/ApplicationMenus/ApplicationMenusDelete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8362ecfa30045c25d108ad16c073e5146b6e706d", @"/Areas/Admin/Pages/_ViewImports.cshtml")]
    public class Areas_Admin_Pages_ApplicationMenus_ApplicationMenusDelete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "checkbox", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("switch-input"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationMenus\ApplicationMenusDelete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(87, 177, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Application Menu</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(265, 56, false);
#line 16 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationMenus\ApplicationMenusDelete.cshtml"
       Write(Html.DisplayNameFor(model => model.ApplicationMenu.Name));

#line default
#line hidden
            EndContext();
            BeginContext(321, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(365, 52, false);
#line 19 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationMenus\ApplicationMenusDelete.cshtml"
       Write(Html.DisplayFor(model => model.ApplicationMenu.Name));

#line default
#line hidden
            EndContext();
            BeginContext(417, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(461, 63, false);
#line 22 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationMenus\ApplicationMenusDelete.cshtml"
       Write(Html.DisplayNameFor(model => model.ApplicationMenu.Description));

#line default
#line hidden
            EndContext();
            BeginContext(524, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(568, 59, false);
#line 25 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationMenus\ApplicationMenusDelete.cshtml"
       Write(Html.DisplayFor(model => model.ApplicationMenu.Description));

#line default
#line hidden
            EndContext();
            BeginContext(627, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(671, 63, false);
#line 28 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationMenus\ApplicationMenusDelete.cshtml"
       Write(Html.DisplayNameFor(model => model.ApplicationMenu.MenuCaption));

#line default
#line hidden
            EndContext();
            BeginContext(734, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(778, 59, false);
#line 31 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationMenus\ApplicationMenusDelete.cshtml"
       Write(Html.DisplayFor(model => model.ApplicationMenu.MenuCaption));

#line default
#line hidden
            EndContext();
            BeginContext(837, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(881, 56, false);
#line 34 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationMenus\ApplicationMenusDelete.cshtml"
       Write(Html.DisplayNameFor(model => model.ApplicationMenu.Icon));

#line default
#line hidden
            EndContext();
            BeginContext(937, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(981, 52, false);
#line 37 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationMenus\ApplicationMenusDelete.cshtml"
       Write(Html.DisplayFor(model => model.ApplicationMenu.Icon));

#line default
#line hidden
            EndContext();
            BeginContext(1033, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1077, 60, false);
#line 40 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationMenus\ApplicationMenusDelete.cshtml"
       Write(Html.DisplayNameFor(model => model.ApplicationMenu.AreaName));

#line default
#line hidden
            EndContext();
            BeginContext(1137, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1181, 56, false);
#line 43 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationMenus\ApplicationMenusDelete.cshtml"
       Write(Html.DisplayFor(model => model.ApplicationMenu.AreaName));

#line default
#line hidden
            EndContext();
            BeginContext(1237, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1281, 62, false);
#line 46 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationMenus\ApplicationMenusDelete.cshtml"
       Write(Html.DisplayNameFor(model => model.ApplicationMenu.FolderName));

#line default
#line hidden
            EndContext();
            BeginContext(1343, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1387, 58, false);
#line 49 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationMenus\ApplicationMenusDelete.cshtml"
       Write(Html.DisplayFor(model => model.ApplicationMenu.FolderName));

#line default
#line hidden
            EndContext();
            BeginContext(1445, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1489, 60, false);
#line 52 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationMenus\ApplicationMenusDelete.cshtml"
       Write(Html.DisplayNameFor(model => model.ApplicationMenu.PageName));

#line default
#line hidden
            EndContext();
            BeginContext(1549, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1593, 56, false);
#line 55 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationMenus\ApplicationMenusDelete.cshtml"
       Write(Html.DisplayFor(model => model.ApplicationMenu.PageName));

#line default
#line hidden
            EndContext();
            BeginContext(1649, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1693, 60, false);
#line 58 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationMenus\ApplicationMenusDelete.cshtml"
       Write(Html.DisplayNameFor(model => model.ApplicationMenu.Position));

#line default
#line hidden
            EndContext();
            BeginContext(1753, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1797, 56, false);
#line 61 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationMenus\ApplicationMenusDelete.cshtml"
       Write(Html.DisplayFor(model => model.ApplicationMenu.Position));

#line default
#line hidden
            EndContext();
            BeginContext(1853, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1897, 61, false);
#line 64 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationMenus\ApplicationMenusDelete.cshtml"
       Write(Html.DisplayNameFor(model => model.ApplicationMenu.IsDefault));

#line default
#line hidden
            EndContext();
            BeginContext(1958, 122, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            <label class=\"switch switch-pill switch-text switch-primary\">\r\n                ");
            EndContext();
            BeginContext(2080, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d0ea897954ee402fb04d045ed9e35851", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 68 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationMenus\ApplicationMenusDelete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ApplicationMenu.IsDefault);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2160, 198, true);
            WriteLiteral("\r\n                <span class=\"switch-label\" data-on=\"On\" data-off=\"Off\"></span>\r\n                <span class=\"switch-handle\"></span>\r\n            </label>\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2359, 58, false);
#line 74 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationMenus\ApplicationMenusDelete.cshtml"
       Write(Html.DisplayNameFor(model => model.ApplicationMenu.Parent));

#line default
#line hidden
            EndContext();
            BeginContext(2417, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2460, 212, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e55c7cd080674187b65c279a62646e65", async() => {
                BeginContext(2597, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(2615, 34, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c88242864544ab9abcf2ddfd03c6b7e", async() => {
                    BeginContext(2632, 8, true);
                    WriteLiteral("Pick one");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2649, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#line 77 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationMenus\ApplicationMenusDelete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ApplicationMenu.ParentId);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 77 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationMenus\ApplicationMenusDelete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ((List<SelectListItem>)ViewData["AvailableMenus"]);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2672, 34, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n    ");
            EndContext();
            BeginContext(2706, 231, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd4a8cb4fa60442cab66c7579f59c634", async() => {
                BeginContext(2726, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2736, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fd747dbfddcd4fff9dfbe6c8199c65bb", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#line 84 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationMenus\ApplicationMenusDelete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ApplicationMenu.Id);

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
                BeginContext(2788, 98, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-outline-danger btn-sm\" /> |\r\n        ");
                EndContext();
                BeginContext(2886, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08708814cd6642bbb33f1268263d5150", async() => {
                    BeginContext(2908, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2924, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2937, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ApplicationMenusDeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ApplicationMenusDeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ApplicationMenusDeleteModel>)PageContext?.ViewData;
        public ApplicationMenusDeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
