#pragma checksum "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\RMARequests\RMARequestsIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8861883a65508d706cff62ca12754eb548c43de3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(EC.Web.Areas.RMA.Pages.RMARequests.Areas_RMA_Pages_RMARequests_RMARequestsIndex), @"mvc.1.0.razor-page", @"/Areas/RMA/Pages/RMARequests/RMARequestsIndex.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/RMA/Pages/RMARequests/RMARequestsIndex.cshtml", typeof(EC.Web.Areas.RMA.Pages.RMARequests.Areas_RMA_Pages_RMARequests_RMARequestsIndex), null)]
namespace EC.Web.Areas.RMA.Pages.RMARequests
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\_ViewImports.cshtml"
using EC.Web.Areas.Identity;

#line default
#line hidden
#line 3 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\_ViewImports.cshtml"
using EC.Web.ViewModels;

#line default
#line hidden
#line 5 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\_ViewImports.cshtml"
using EC.Web.Data;

#line default
#line hidden
#line 6 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\_ViewImports.cshtml"
using EC.Web.Areas.RMA.Data;

#line default
#line hidden
#line 7 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\_ViewImports.cshtml"
using EC.Web.ViewModels.Base;

#line default
#line hidden
#line 8 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\_ViewImports.cshtml"
using EC.Web.ViewModels.Demo;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8861883a65508d706cff62ca12754eb548c43de3", @"/Areas/RMA/Pages/RMARequests/RMARequestsIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1dd3590eb3145065795dd53dfb0854044e0ffe88", @"/Areas/RMA/Pages/_ViewImports.cshtml")]
    public class Areas_RMA_Pages_RMARequests_RMARequestsIndex : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "RMARequestCreate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./RMARequestEdit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./RMARequestDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./RMARequestDelete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\RMARequests\RMARequestsIndex.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(78, 39, true);
            WriteLiteral("<h2>RMA Requests List</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(117, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f57ec7cc6b7448099a77ffc83e46483b", async() => {
                BeginContext(148, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(162, 202, true);
            WriteLiteral("\r\n</p>\r\n\r\n<table id=\"sortable\" class=\"table table-hover table-bordered table-striped nowrap\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n\r\n            </th>\r\n            <th hidden>\r\n                ");
            EndContext();
            BeginContext(365, 53, false);
#line 19 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\RMARequests\RMARequestsIndex.cshtml"
           Write(Html.DisplayNameFor(model => model.RMARequests[0].Id));

#line default
#line hidden
            EndContext();
            BeginContext(418, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(474, 60, false);
#line 22 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\RMARequests\RMARequestsIndex.cshtml"
           Write(Html.DisplayNameFor(model => model.RMARequests[0].RMANumber));

#line default
#line hidden
            EndContext();
            BeginContext(534, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(590, 63, false);
#line 25 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\RMARequests\RMARequestsIndex.cshtml"
           Write(Html.DisplayNameFor(model => model.RMARequests[0].RMAIssueDate));

#line default
#line hidden
            EndContext();
            BeginContext(653, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(709, 57, false);
#line 28 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\RMARequests\RMARequestsIndex.cshtml"
           Write(Html.DisplayNameFor(model => model.RMARequests[0].Status));

#line default
#line hidden
            EndContext();
            BeginContext(766, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(822, 64, false);
#line 31 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\RMARequests\RMARequestsIndex.cshtml"
           Write(Html.DisplayNameFor(model => model.RMARequests[0].SubmittedDate));

#line default
#line hidden
            EndContext();
            BeginContext(886, 188, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Submitted By\r\n            </th>\r\n            <th>\r\n                Customer Id\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1075, 63, false);
#line 40 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\RMARequests\RMARequestsIndex.cshtml"
           Write(Html.DisplayNameFor(model => model.RMARequests[0].CustomerName));

#line default
#line hidden
            EndContext();
            BeginContext(1138, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1194, 66, false);
#line 43 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\RMARequests\RMARequestsIndex.cshtml"
           Write(Html.DisplayNameFor(model => model.RMARequests[0].CustomerContact));

#line default
#line hidden
            EndContext();
            BeginContext(1260, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1316, 71, false);
#line 46 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\RMARequests\RMARequestsIndex.cshtml"
           Write(Html.DisplayNameFor(model => model.RMARequests[0].CustomerContactEmail));

#line default
#line hidden
            EndContext();
            BeginContext(1387, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1443, 64, false);
#line 49 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\RMARequests\RMARequestsIndex.cshtml"
           Write(Html.DisplayNameFor(model => model.RMARequests[0].InvoiceNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1507, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1563, 68, false);
#line 52 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\RMARequests\RMARequestsIndex.cshtml"
           Write(Html.DisplayNameFor(model => model.RMARequests[0].PartSerialNumbers));

#line default
#line hidden
            EndContext();
            BeginContext(1631, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1687, 67, false);
#line 55 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\RMARequests\RMARequestsIndex.cshtml"
           Write(Html.DisplayNameFor(model => model.RMARequests[0].DefectPhenomenon));

#line default
#line hidden
            EndContext();
            BeginContext(1754, 122, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Sales Person\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1877, 57, false);
#line 61 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\RMARequests\RMARequestsIndex.cshtml"
           Write(Html.DisplayNameFor(model => model.RMARequests[0].Remark));

#line default
#line hidden
            EndContext();
            BeginContext(1934, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1990, 60, false);
#line 64 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\RMARequests\RMARequestsIndex.cshtml"
           Write(Html.DisplayNameFor(model => model.RMARequests[0].RMAReport));

#line default
#line hidden
            EndContext();
            BeginContext(2050, 172, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Number of Cases\r\n            </th>\r\n            <th>\r\n\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 75 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\RMARequests\RMARequestsIndex.cshtml"
         foreach (var item in Model.RMARequests)
        {

#line default
#line hidden
            BeginContext(2283, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2331, 147, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6206ea342042482e84484d5c0c9ca013", async() => {
                BeginContext(2417, 57, true);
                WriteLiteral("<i class=\"icon-pencil icons font-sm d-block mt-sm-2\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 79 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\RMARequests\RMARequestsIndex.cshtml"
                                                 WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2478, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(2496, 153, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17787d3b83394337ab46c9c70c5c3783", async() => {
                BeginContext(2585, 60, true);
                WriteLiteral("<i class=\"icon-magnifier icons font-sm d-block mt-sm-2\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 80 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\RMARequests\RMARequestsIndex.cshtml"
                                                    WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2649, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(2667, 148, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f541822204464d79951e7acf1e247b10", async() => {
                BeginContext(2755, 56, true);
                WriteLiteral("<i class=\"icon-trash icons font-sm d-block mt-sm-2\"></i>");
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
#line 81 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\RMARequests\RMARequestsIndex.cshtml"
                                                   WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2815, 62, true);
            WriteLiteral("\r\n            </td>\r\n            <td hidden>\r\n                ");
            EndContext();
            BeginContext(2878, 37, false);
#line 84 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\RMARequests\RMARequestsIndex.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(2915, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2971, 44, false);
#line 87 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\RMARequests\RMARequestsIndex.cshtml"
           Write(Html.DisplayFor(modelItem => item.RMANumber));

#line default
#line hidden
            EndContext();
            BeginContext(3015, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3071, 47, false);
#line 90 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\RMARequests\RMARequestsIndex.cshtml"
           Write(Html.DisplayFor(modelItem => item.RMAIssueDate));

#line default
#line hidden
            EndContext();
            BeginContext(3118, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3174, 41, false);
#line 93 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\RMARequests\RMARequestsIndex.cshtml"
           Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(3215, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3271, 48, false);
#line 96 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\RMARequests\RMARequestsIndex.cshtml"
           Write(Html.DisplayFor(modelItem => item.SubmittedDate));

#line default
#line hidden
            EndContext();
            BeginContext(3319, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3375, 56, false);
#line 99 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\RMARequests\RMARequestsIndex.cshtml"
           Write(Html.DisplayFor(modelItem => item.SubmittedByUser.Email));

#line default
#line hidden
            EndContext();
            BeginContext(3431, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3487, 48, false);
#line 102 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\RMARequests\RMARequestsIndex.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustomerERPId));

#line default
#line hidden
            EndContext();
            BeginContext(3535, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3591, 47, false);
#line 105 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\RMARequests\RMARequestsIndex.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustomerName));

#line default
#line hidden
            EndContext();
            BeginContext(3638, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3694, 50, false);
#line 108 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\RMARequests\RMARequestsIndex.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustomerContact));

#line default
#line hidden
            EndContext();
            BeginContext(3744, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3800, 55, false);
#line 111 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\RMARequests\RMARequestsIndex.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustomerContactEmail));

#line default
#line hidden
            EndContext();
            BeginContext(3855, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3911, 48, false);
#line 114 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\RMARequests\RMARequestsIndex.cshtml"
           Write(Html.DisplayFor(modelItem => item.InvoiceNumber));

#line default
#line hidden
            EndContext();
            BeginContext(3959, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4015, 52, false);
#line 117 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\RMARequests\RMARequestsIndex.cshtml"
           Write(Html.DisplayFor(modelItem => item.PartSerialNumbers));

#line default
#line hidden
            EndContext();
            BeginContext(4067, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4123, 51, false);
#line 120 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\RMARequests\RMARequestsIndex.cshtml"
           Write(Html.DisplayFor(modelItem => item.DefectPhenomenon));

#line default
#line hidden
            EndContext();
            BeginContext(4174, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4230, 52, false);
#line 123 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\RMARequests\RMARequestsIndex.cshtml"
           Write(Html.DisplayFor(modelItem => item.SalesPersonUserId));

#line default
#line hidden
            EndContext();
            BeginContext(4282, 57, true);
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4340, 41, false);
#line 127 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\RMARequests\RMARequestsIndex.cshtml"
           Write(Html.DisplayFor(modelItem => item.Remark));

#line default
#line hidden
            EndContext();
            BeginContext(4381, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4437, 44, false);
#line 130 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\RMARequests\RMARequestsIndex.cshtml"
           Write(Html.DisplayFor(modelItem => item.RMAReport));

#line default
#line hidden
            EndContext();
            BeginContext(4481, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4537, 49, false);
#line 133 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\RMARequests\RMARequestsIndex.cshtml"
           Write(Html.DisplayFor(modelItem => item.RMACases.Count));

#line default
#line hidden
            EndContext();
            BeginContext(4586, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4641, 147, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a54d452704341da86c50b1c3ef1d3ae", async() => {
                BeginContext(4727, 57, true);
                WriteLiteral("<i class=\"icon-pencil icons font-sm d-block mt-sm-2\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 136 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\RMARequests\RMARequestsIndex.cshtml"
                                                 WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4788, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(4806, 153, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b467df2dfad4fe897a1afadc989db57", async() => {
                BeginContext(4895, 60, true);
                WriteLiteral("<i class=\"icon-magnifier icons font-sm d-block mt-sm-2\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 137 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\RMARequests\RMARequestsIndex.cshtml"
                                                    WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4959, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(4977, 148, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6643e0fb3244a86af0a1ac40ba30324", async() => {
                BeginContext(5065, 56, true);
                WriteLiteral("<i class=\"icon-trash icons font-sm d-block mt-sm-2\"></i>");
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
#line 138 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\RMARequests\RMARequestsIndex.cshtml"
                                                   WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5125, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 141 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\RMARequests\RMARequestsIndex.cshtml"
        }

#line default
#line hidden
            BeginContext(5172, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(5214, 175, true);
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(function () {\r\n            $(\'#sortable\').DataTable({\r\n                \'scrollX\': true\r\n            });\r\n        });\r\n    </script>\r\n");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RMARequestsIndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RMARequestsIndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RMARequestsIndexModel>)PageContext?.ViewData;
        public RMARequestsIndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591