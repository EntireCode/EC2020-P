#pragma checksum "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Sales\Pages\Backlog\WeeklyBacklogs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73dcda07e4c835fdd74abaa7f6916ef4ffe74c60"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(EC.Web.Areas.Sales.Pages.Backlog.Areas_Sales_Pages_Backlog_WeeklyBacklogs), @"mvc.1.0.razor-page", @"/Areas/Sales/Pages/Backlog/WeeklyBacklogs.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Sales/Pages/Backlog/WeeklyBacklogs.cshtml", typeof(EC.Web.Areas.Sales.Pages.Backlog.Areas_Sales_Pages_Backlog_WeeklyBacklogs), @"{salesManager?}")]
namespace EC.Web.Areas.Sales.Pages.Backlog
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Sales\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Sales\Pages\_ViewImports.cshtml"
using EC.Web.Areas.Identity;

#line default
#line hidden
#line 3 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Sales\Pages\_ViewImports.cshtml"
using EC.Web.ViewModels;

#line default
#line hidden
#line 4 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Sales\Pages\_ViewImports.cshtml"
using EC.Web.Areas.Sales.Data.ViewModels;

#line default
#line hidden
#line 7 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Sales\Pages\_ViewImports.cshtml"
using EC.Web.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{salesManager?}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73dcda07e4c835fdd74abaa7f6916ef4ffe74c60", @"/Areas/Sales/Pages/Backlog/WeeklyBacklogs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c743142a11d8a77f158834789483fe6f35f6512", @"/Areas/Sales/Pages/_ViewImports.cshtml")]
    public class Areas_Sales_Pages_Backlog_WeeklyBacklogs : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(60, 26, true);
            WriteLiteral("<h2>Weekly Backlogs</h2>\r\n");
            EndContext();
            BeginContext(86, 470, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc7e4413a0ee494c97fac9aa7f5c362f", async() => {
                BeginContext(106, 98, true);
                WriteLiteral("\r\n    <div class=\"row\">\r\n        <div class=\"col-md-4\">\r\n            Sales Manager: \r\n            ");
                EndContext();
                BeginContext(204, 190, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e56fbd2cc40640ef92e08bdf6624c219", async() => {
                    BeginContext(319, 18, true);
                    WriteLiteral("\r\n                ");
                    EndContext();
                    BeginContext(337, 34, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c5746fb7617498b99554169c512ac0e", async() => {
                        BeginContext(354, 8, true);
                        WriteLiteral("Pick one");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(371, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#line 10 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Sales\Pages\Backlog\WeeklyBacklogs.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SalesManager);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 10 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Sales\Pages\Backlog\WeeklyBacklogs.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ((List<SelectListItem>)ViewData["SalesManagers"]);

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
                BeginContext(394, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(408, 73, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0362e85c6fd44ba7a108bcbb6629c0ac", async() => {
                    BeginContext(466, 6, true);
                    WriteLiteral("Search");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(481, 68, true);
                WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-8\"></div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(556, 166, true);
            WriteLiteral("\r\n<hr />\r\n<table id=\"example\" class=\"table table-striped table-hover table-bordered\">\r\n    <thead>\r\n        <tr>\r\n            <th class=\"text-left\">\r\n                ");
            EndContext();
            BeginContext(723, 61, false);
#line 23 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Sales\Pages\Backlog\WeeklyBacklogs.cshtml"
           Write(Html.DisplayNameFor(model => model.Weeklybacklogs[0].OrdDate));

#line default
#line hidden
            EndContext();
            BeginContext(784, 74, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"text-right\">\r\n                ");
            EndContext();
            BeginContext(859, 62, false);
#line 26 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Sales\Pages\Backlog\WeeklyBacklogs.cshtml"
           Write(Html.DisplayNameFor(model => model.Weeklybacklogs[0].SONumber));

#line default
#line hidden
            EndContext();
            BeginContext(921, 73, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"text-left\">\r\n                ");
            EndContext();
            BeginContext(995, 62, false);
#line 29 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Sales\Pages\Backlog\WeeklyBacklogs.cshtml"
           Write(Html.DisplayNameFor(model => model.Weeklybacklogs[0].ShipDate));

#line default
#line hidden
            EndContext();
            BeginContext(1057, 73, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"text-left\">\r\n                ");
            EndContext();
            BeginContext(1131, 59, false);
#line 32 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Sales\Pages\Backlog\WeeklyBacklogs.cshtml"
           Write(Html.DisplayNameFor(model => model.Weeklybacklogs[0].Sales));

#line default
#line hidden
            EndContext();
            BeginContext(1190, 73, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"text-left\">\r\n                ");
            EndContext();
            BeginContext(1264, 65, false);
#line 35 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Sales\Pages\Backlog\WeeklyBacklogs.cshtml"
           Write(Html.DisplayNameFor(model => model.Weeklybacklogs[0].InsideSales));

#line default
#line hidden
            EndContext();
            BeginContext(1329, 73, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"text-left\">\r\n                ");
            EndContext();
            BeginContext(1403, 57, false);
#line 38 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Sales\Pages\Backlog\WeeklyBacklogs.cshtml"
           Write(Html.DisplayNameFor(model => model.Weeklybacklogs[0].Rep));

#line default
#line hidden
            EndContext();
            BeginContext(1460, 74, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"text-right\">\r\n                ");
            EndContext();
            BeginContext(1535, 61, false);
#line 41 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Sales\Pages\Backlog\WeeklyBacklogs.cshtml"
           Write(Html.DisplayNameFor(model => model.Weeklybacklogs[0].RepComm));

#line default
#line hidden
            EndContext();
            BeginContext(1596, 73, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"text-left\">\r\n                ");
            EndContext();
            BeginContext(1670, 62, false);
#line 44 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Sales\Pages\Backlog\WeeklyBacklogs.cshtml"
           Write(Html.DisplayNameFor(model => model.Weeklybacklogs[0].Customer));

#line default
#line hidden
            EndContext();
            BeginContext(1732, 73, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"text-left\">\r\n                ");
            EndContext();
            BeginContext(1806, 66, false);
#line 47 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Sales\Pages\Backlog\WeeklyBacklogs.cshtml"
           Write(Html.DisplayNameFor(model => model.Weeklybacklogs[0].CustPONumber));

#line default
#line hidden
            EndContext();
            BeginContext(1872, 74, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"text-right\">\r\n                ");
            EndContext();
            BeginContext(1947, 56, false);
#line 50 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Sales\Pages\Backlog\WeeklyBacklogs.cshtml"
           Write(Html.DisplayNameFor(model => model.Weeklybacklogs[0].Ln));

#line default
#line hidden
            EndContext();
            BeginContext(2003, 73, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"text-left\">\r\n                ");
            EndContext();
            BeginContext(2077, 65, false);
#line 53 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Sales\Pages\Backlog\WeeklyBacklogs.cshtml"
           Write(Html.DisplayNameFor(model => model.Weeklybacklogs[0].ModelNumber));

#line default
#line hidden
            EndContext();
            BeginContext(2142, 74, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"text-right\">\r\n                ");
            EndContext();
            BeginContext(2217, 61, false);
#line 56 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Sales\Pages\Backlog\WeeklyBacklogs.cshtml"
           Write(Html.DisplayNameFor(model => model.Weeklybacklogs[0].OpenQty));

#line default
#line hidden
            EndContext();
            BeginContext(2278, 74, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"text-right\">\r\n                ");
            EndContext();
            BeginContext(2353, 59, false);
#line 59 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Sales\Pages\Backlog\WeeklyBacklogs.cshtml"
           Write(Html.DisplayNameFor(model => model.Weeklybacklogs[0].Price));

#line default
#line hidden
            EndContext();
            BeginContext(2412, 74, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"text-right\">\r\n                ");
            EndContext();
            BeginContext(2487, 61, false);
#line 62 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Sales\Pages\Backlog\WeeklyBacklogs.cshtml"
           Write(Html.DisplayNameFor(model => model.Weeklybacklogs[0].OpenAmt));

#line default
#line hidden
            EndContext();
            BeginContext(2548, 73, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"text-left\">\r\n                ");
            EndContext();
            BeginContext(2622, 59, false);
#line 65 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Sales\Pages\Backlog\WeeklyBacklogs.cshtml"
           Write(Html.DisplayNameFor(model => model.Weeklybacklogs[0].Notes));

#line default
#line hidden
            EndContext();
            BeginContext(2681, 63, true);
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 70 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Sales\Pages\Backlog\WeeklyBacklogs.cshtml"
         if (Model.Weeklybacklogs != null)
        {
            

#line default
#line hidden
#line 72 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Sales\Pages\Backlog\WeeklyBacklogs.cshtml"
             foreach (var item in Model.Weeklybacklogs)
            {

#line default
#line hidden
            BeginContext(2871, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2944, 42, false);
#line 76 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Sales\Pages\Backlog\WeeklyBacklogs.cshtml"
                   Write(Html.DisplayFor(modelItem => item.OrdDate));

#line default
#line hidden
            EndContext();
            BeginContext(2986, 97, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"text-left\">\r\n                        ");
            EndContext();
            BeginContext(3084, 43, false);
#line 79 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Sales\Pages\Backlog\WeeklyBacklogs.cshtml"
                   Write(Html.DisplayFor(modelItem => item.SONumber));

#line default
#line hidden
            EndContext();
            BeginContext(3127, 97, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"text-left\">\r\n                        ");
            EndContext();
            BeginContext(3225, 43, false);
#line 82 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Sales\Pages\Backlog\WeeklyBacklogs.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ShipDate));

#line default
#line hidden
            EndContext();
            BeginContext(3268, 97, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"text-left\">\r\n                        ");
            EndContext();
            BeginContext(3366, 40, false);
#line 85 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Sales\Pages\Backlog\WeeklyBacklogs.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Sales));

#line default
#line hidden
            EndContext();
            BeginContext(3406, 97, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"text-left\">\r\n                        ");
            EndContext();
            BeginContext(3504, 46, false);
#line 88 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Sales\Pages\Backlog\WeeklyBacklogs.cshtml"
                   Write(Html.DisplayFor(modelItem => item.InsideSales));

#line default
#line hidden
            EndContext();
            BeginContext(3550, 97, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"text-left\">\r\n                        ");
            EndContext();
            BeginContext(3648, 38, false);
#line 91 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Sales\Pages\Backlog\WeeklyBacklogs.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Rep));

#line default
#line hidden
            EndContext();
            BeginContext(3686, 98, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"text-right\">\r\n                        ");
            EndContext();
            BeginContext(3785, 42, false);
#line 94 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Sales\Pages\Backlog\WeeklyBacklogs.cshtml"
                   Write(Html.DisplayFor(modelItem => item.RepComm));

#line default
#line hidden
            EndContext();
            BeginContext(3827, 97, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"text-left\">\r\n                        ");
            EndContext();
            BeginContext(3925, 43, false);
#line 97 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Sales\Pages\Backlog\WeeklyBacklogs.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Customer));

#line default
#line hidden
            EndContext();
            BeginContext(3968, 97, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"text-left\">\r\n                        ");
            EndContext();
            BeginContext(4066, 47, false);
#line 100 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Sales\Pages\Backlog\WeeklyBacklogs.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CustPONumber));

#line default
#line hidden
            EndContext();
            BeginContext(4113, 98, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"text-right\">\r\n                        ");
            EndContext();
            BeginContext(4212, 37, false);
#line 103 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Sales\Pages\Backlog\WeeklyBacklogs.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Ln));

#line default
#line hidden
            EndContext();
            BeginContext(4249, 97, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"text-left\">\r\n                        ");
            EndContext();
            BeginContext(4347, 46, false);
#line 106 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Sales\Pages\Backlog\WeeklyBacklogs.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ModelNumber));

#line default
#line hidden
            EndContext();
            BeginContext(4393, 98, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"text-right\">\r\n                        ");
            EndContext();
            BeginContext(4492, 42, false);
#line 109 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Sales\Pages\Backlog\WeeklyBacklogs.cshtml"
                   Write(Html.DisplayFor(modelItem => item.OpenQty));

#line default
#line hidden
            EndContext();
            BeginContext(4534, 98, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"text-right\">\r\n                        ");
            EndContext();
            BeginContext(4633, 40, false);
#line 112 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Sales\Pages\Backlog\WeeklyBacklogs.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(4673, 98, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"text-right\">\r\n                        ");
            EndContext();
            BeginContext(4772, 42, false);
#line 115 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Sales\Pages\Backlog\WeeklyBacklogs.cshtml"
                   Write(Html.DisplayFor(modelItem => item.OpenAmt));

#line default
#line hidden
            EndContext();
            BeginContext(4814, 97, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"text-left\">\r\n                        ");
            EndContext();
            BeginContext(4912, 40, false);
#line 118 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Sales\Pages\Backlog\WeeklyBacklogs.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Notes));

#line default
#line hidden
            EndContext();
            BeginContext(4952, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 121 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Sales\Pages\Backlog\WeeklyBacklogs.cshtml"
            }

#line default
#line hidden
#line 121 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Sales\Pages\Backlog\WeeklyBacklogs.cshtml"
             
        }

#line default
#line hidden
            BeginContext(5030, 26, true);
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(5074, 24, true);
                WriteLiteral("\r\n    <script>\r\n        ");
                EndContext();
                BeginContext(5099, 62, false);
#line 128 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Sales\Pages\Backlog\WeeklyBacklogs.cshtml"
   Write(Html.Raw(Model.PrepareScript("example", "Weekly Backlog", 15)));

#line default
#line hidden
                EndContext();
                BeginContext(5161, 18, true);
                WriteLiteral(";\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WeeklyBacklogsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WeeklyBacklogsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WeeklyBacklogsModel>)PageContext?.ViewData;
        public WeeklyBacklogsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
