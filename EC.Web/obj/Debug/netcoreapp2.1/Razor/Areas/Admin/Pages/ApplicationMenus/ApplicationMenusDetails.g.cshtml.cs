#pragma checksum "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationMenus\ApplicationMenusDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b37ed3cb0d40236aa4bf990030a3ca28975526f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(EC.Web.Areas.Admin.Pages.ApplicationMenus.Areas_Admin_Pages_ApplicationMenus_ApplicationMenusDetails), @"mvc.1.0.razor-page", @"/Areas/Admin/Pages/ApplicationMenus/ApplicationMenusDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Admin/Pages/ApplicationMenus/ApplicationMenusDetails.cshtml", typeof(EC.Web.Areas.Admin.Pages.ApplicationMenus.Areas_Admin_Pages_ApplicationMenus_ApplicationMenusDetails), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b37ed3cb0d40236aa4bf990030a3ca28975526f2", @"/Areas/Admin/Pages/ApplicationMenus/ApplicationMenusDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8362ecfa30045c25d108ad16c073e5146b6e706d", @"/Areas/Admin/Pages/_ViewImports.cshtml")]
    public class Areas_Admin_Pages_ApplicationMenus_ApplicationMenusDetails : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "checkbox", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("switch-input"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./ApplicationMenusEdit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./ApplicationMenusIndex", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationMenus\ApplicationMenusDetails.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(87, 130, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Application Menu</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(218, 56, false);
#line 14 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationMenus\ApplicationMenusDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.ApplicationMenu.Name));

#line default
#line hidden
            EndContext();
            BeginContext(274, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(318, 52, false);
#line 17 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationMenus\ApplicationMenusDetails.cshtml"
       Write(Html.DisplayFor(model => model.ApplicationMenu.Name));

#line default
#line hidden
            EndContext();
            BeginContext(370, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(414, 63, false);
#line 20 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationMenus\ApplicationMenusDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.ApplicationMenu.Description));

#line default
#line hidden
            EndContext();
            BeginContext(477, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(521, 59, false);
#line 23 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationMenus\ApplicationMenusDetails.cshtml"
       Write(Html.DisplayFor(model => model.ApplicationMenu.Description));

#line default
#line hidden
            EndContext();
            BeginContext(580, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(624, 63, false);
#line 26 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationMenus\ApplicationMenusDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.ApplicationMenu.MenuCaption));

#line default
#line hidden
            EndContext();
            BeginContext(687, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(731, 59, false);
#line 29 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationMenus\ApplicationMenusDetails.cshtml"
       Write(Html.DisplayFor(model => model.ApplicationMenu.MenuCaption));

#line default
#line hidden
            EndContext();
            BeginContext(790, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(834, 56, false);
#line 32 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationMenus\ApplicationMenusDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.ApplicationMenu.Icon));

#line default
#line hidden
            EndContext();
            BeginContext(890, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(934, 52, false);
#line 35 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationMenus\ApplicationMenusDetails.cshtml"
       Write(Html.DisplayFor(model => model.ApplicationMenu.Icon));

#line default
#line hidden
            EndContext();
            BeginContext(986, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1030, 60, false);
#line 38 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationMenus\ApplicationMenusDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.ApplicationMenu.AreaName));

#line default
#line hidden
            EndContext();
            BeginContext(1090, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1134, 56, false);
#line 41 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationMenus\ApplicationMenusDetails.cshtml"
       Write(Html.DisplayFor(model => model.ApplicationMenu.AreaName));

#line default
#line hidden
            EndContext();
            BeginContext(1190, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1234, 62, false);
#line 44 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationMenus\ApplicationMenusDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.ApplicationMenu.FolderName));

#line default
#line hidden
            EndContext();
            BeginContext(1296, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1340, 58, false);
#line 47 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationMenus\ApplicationMenusDetails.cshtml"
       Write(Html.DisplayFor(model => model.ApplicationMenu.FolderName));

#line default
#line hidden
            EndContext();
            BeginContext(1398, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1442, 60, false);
#line 50 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationMenus\ApplicationMenusDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.ApplicationMenu.PageName));

#line default
#line hidden
            EndContext();
            BeginContext(1502, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1546, 56, false);
#line 53 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationMenus\ApplicationMenusDetails.cshtml"
       Write(Html.DisplayFor(model => model.ApplicationMenu.PageName));

#line default
#line hidden
            EndContext();
            BeginContext(1602, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1646, 60, false);
#line 56 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationMenus\ApplicationMenusDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.ApplicationMenu.Position));

#line default
#line hidden
            EndContext();
            BeginContext(1706, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1750, 56, false);
#line 59 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationMenus\ApplicationMenusDetails.cshtml"
       Write(Html.DisplayFor(model => model.ApplicationMenu.Position));

#line default
#line hidden
            EndContext();
            BeginContext(1806, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1850, 61, false);
#line 62 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationMenus\ApplicationMenusDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.ApplicationMenu.IsDefault));

#line default
#line hidden
            EndContext();
            BeginContext(1911, 122, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            <label class=\"switch switch-pill switch-text switch-primary\">\r\n                ");
            EndContext();
            BeginContext(2033, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "957e7972148a468e976343d3fd151274", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 66 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationMenus\ApplicationMenusDetails.cshtml"
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
            BeginContext(2113, 198, true);
            WriteLiteral("\r\n                <span class=\"switch-label\" data-on=\"On\" data-off=\"Off\"></span>\r\n                <span class=\"switch-handle\"></span>\r\n            </label>\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2312, 58, false);
#line 72 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationMenus\ApplicationMenusDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.ApplicationMenu.Parent));

#line default
#line hidden
            EndContext();
            BeginContext(2370, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2413, 212, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "711558cab8ee45528c476a88c5856bbf", async() => {
                BeginContext(2550, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(2568, 34, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ff06e56069f4ea0b825bea31f2e8140", async() => {
                    BeginContext(2585, 8, true);
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
                BeginContext(2602, 14, true);
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
#line 75 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationMenus\ApplicationMenusDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ApplicationMenu.ParentId);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 75 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationMenus\ApplicationMenusDetails.cshtml"
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
            BeginContext(2625, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2672, 86, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2830116fdf6d4d63a416dd77298ec5e6", async() => {
                BeginContext(2750, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 82 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationMenus\ApplicationMenusDetails.cshtml"
                                           WriteLiteral(Model.ApplicationMenu.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2758, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2766, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3907ad5771b499ba7dcce217b0c294d", async() => {
                BeginContext(2804, 12, true);
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
            BeginContext(2820, 8, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ApplicationMenusDetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ApplicationMenusDetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ApplicationMenusDetailsModel>)PageContext?.ViewData;
        public ApplicationMenusDetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
