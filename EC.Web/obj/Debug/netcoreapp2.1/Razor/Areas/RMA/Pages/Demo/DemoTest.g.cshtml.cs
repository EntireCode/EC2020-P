#pragma checksum "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\Demo\DemoTest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b47042a0262883056dca9ea5cb49141d29a6d0c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(EC.Web.Areas.RMA.Pages.Demo.Areas_RMA_Pages_Demo_DemoTest), @"mvc.1.0.razor-page", @"/Areas/RMA/Pages/Demo/DemoTest.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/RMA/Pages/Demo/DemoTest.cshtml", typeof(EC.Web.Areas.RMA.Pages.Demo.Areas_RMA_Pages_Demo_DemoTest), null)]
namespace EC.Web.Areas.RMA.Pages.Demo
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b47042a0262883056dca9ea5cb49141d29a6d0c5", @"/Areas/RMA/Pages/Demo/DemoTest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1dd3590eb3145065795dd53dfb0854044e0ffe88", @"/Areas/RMA/Pages/_ViewImports.cshtml")]
    public class Areas_RMA_Pages_Demo_DemoTest : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("newOrderDetail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/demo.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 348, true);
            WriteLiteral(@"<div>
    <div class=""row"">
        <div class=""col-md-4"">
            <h2>Orders</h2>
        </div>
        <div class=""col-md-8"">
            <button style=""margin-right:10px"" class=""btn btn-primary pull-right"" onclick=""addNewOrder()"">New Order</button>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-12"">
");
            EndContext();
#line 16 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\Demo\DemoTest.cshtml"
             if (Model.Orders.Count() != 0)
            {
                foreach (var order in Model.Orders)
                {

#line default
#line hidden
            BeginContext(516, 307, true);
            WriteLiteral(@"                    <div class=""row"">
                        <div class=""col-md-12"">
                            <table class=""table table-striped table-responsive"">
                                <tbody>
                                    <tr>
                                        <td>Customer: ");
            EndContext();
            BeginContext(824, 14, false);
#line 25 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\Demo\DemoTest.cshtml"
                                                 Write(order.Customer);

#line default
#line hidden
            EndContext();
            BeginContext(838, 63, true);
            WriteLiteral("</td>\r\n                                        <td>Order Date: ");
            EndContext();
            BeginContext(902, 15, false);
#line 26 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\Demo\DemoTest.cshtml"
                                                   Write(order.OrderDate);

#line default
#line hidden
            EndContext();
            BeginContext(917, 778, true);
            WriteLiteral(@"</td>
                                    </tr>
                                    <tr>
                                        <td colspan=""3"">
                                            <table class=""table table-bordered"">
                                                <tbody>
                                                    <tr>
                                                        <th>Item No</th>
                                                        <th>Part No</th>
                                                        <th>Unit Price</th>
                                                        <th>Quantity</th>
                                                        <th>Total</th>
                                                    </tr>
");
            EndContext();
#line 39 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\Demo\DemoTest.cshtml"
                                                      
                                                        var totalBill = 0;
                                                    

#line default
#line hidden
            BeginContext(1882, 52, true);
            WriteLiteral("                                                    ");
            EndContext();
#line 42 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\Demo\DemoTest.cshtml"
                                                     foreach (var detail in order.Details)
                                                    {

#line default
#line hidden
            BeginContext(2029, 126, true);
            WriteLiteral("                                                        <tr>\r\n                                                            <td>");
            EndContext();
            BeginContext(2156, 13, false);
#line 45 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\Demo\DemoTest.cshtml"
                                                           Write(detail.ItemNo);

#line default
#line hidden
            EndContext();
            BeginContext(2169, 71, true);
            WriteLiteral("</td>\r\n                                                            <td>");
            EndContext();
            BeginContext(2241, 13, false);
#line 46 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\Demo\DemoTest.cshtml"
                                                           Write(detail.PartNo);

#line default
#line hidden
            EndContext();
            BeginContext(2254, 71, true);
            WriteLiteral("</td>\r\n                                                            <td>");
            EndContext();
            BeginContext(2326, 16, false);
#line 47 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\Demo\DemoTest.cshtml"
                                                           Write(detail.UnitPrice);

#line default
#line hidden
            EndContext();
            BeginContext(2342, 71, true);
            WriteLiteral("</td>\r\n                                                            <td>");
            EndContext();
            BeginContext(2414, 15, false);
#line 48 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\Demo\DemoTest.cshtml"
                                                           Write(detail.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(2429, 71, true);
            WriteLiteral("</td>\r\n                                                            <td>");
            EndContext();
            BeginContext(2501, 13, false);
#line 49 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\Demo\DemoTest.cshtml"
                                                           Write(detail.Amount);

#line default
#line hidden
            EndContext();
            BeginContext(2514, 70, true);
            WriteLiteral("</td>\r\n                                                        </tr>\r\n");
            EndContext();
#line 51 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\Demo\DemoTest.cshtml"
                                                        totalBill += detail.Amount;
                                                    }

#line default
#line hidden
            BeginContext(2724, 239, true);
            WriteLiteral("                                                </tbody>\r\n                                            </table>\r\n                                            <span class=\"pull-right\" style=\"margin-right:100px;\"><strong>Total Bill: </strong> ");
            EndContext();
            BeginContext(2964, 9, false);
#line 55 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\Demo\DemoTest.cshtml"
                                                                                                                          Write(totalBill);

#line default
#line hidden
            EndContext();
            BeginContext(2973, 239, true);
            WriteLiteral("</span>\r\n                                        </td>\r\n                                    </tr>\r\n                                </tbody>\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 62 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\Demo\DemoTest.cshtml"
                }
            }
            else
            {

#line default
#line hidden
            BeginContext(3279, 103, true);
            WriteLiteral("                <div>\r\n                    <h3 style=\"color:red;\">Empty!</h3>\r\n                </div>\r\n");
            EndContext();
#line 69 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\Demo\DemoTest.cshtml"
            }

#line default
#line hidden
            BeginContext(3397, 378, true);
            WriteLiteral(@"        </div>
    </div>
</div>
<div class=""modal fade"" id=""newOrderModal"">
    <div class=""modal-dialog modal-lg"" style=""width:900px !important;"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <a href=""#"" class=""close"" data-dismiss=""modal"">&times;</a>
                <h4>Add New Item</h4>
            </div>
            ");
            EndContext();
            BeginContext(3775, 3740, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "695dd11483fe4bab977cafcf3bc99fdc", async() => {
                BeginContext(3801, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(3820, 23, false);
#line 81 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\Demo\DemoTest.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(3843, 44, true);
                WriteLiteral("\r\n                <div class=\"modal-body\">\r\n");
                EndContext();
                BeginContext(3929, 586, true);
                WriteLiteral(@"                    <h5 style=""color:#ff6347"">Customer Details</h5>
                    <hr />
                    <div>
                        <input type=""hidden"" id=""customerId"" />
                        <div class=""form-group"">
                            <label class=""col-md-2"">Customer</label>
                            <div class=""col-md-4"">
                                <input type=""text"" id=""customer"" name=""customer"" placeholder=""Customer"" class=""form-control"" />
                            </div>
                        </div>
                    </div>
");
                EndContext();
                BeginContext(4554, 2954, true);
                WriteLiteral(@"                    <h5 style=""margin-top:10px;color:#ff6347"">Order Details</h5>
                    <hr />
                    <div>
                        <input type=""hidden"" id=""orderId"" />
                        <div class=""form-group"">
                            <label class=""col-md-2"">
                                Item No
                            </label>
                            <div class=""col-md-4"">
                                <input type=""text"" id=""itemNo"" name=""itemNo"" placeholder=""Item No"" class=""form-control"" />
                            </div>
                            <label class=""col-md-2"">
                                Part No
                            </label>
                            <div class=""col-md-4"">
                                <input type=""text"" id=""partNo"" name=""partNo"" placeholder=""Part No"" class=""form-control"" />
                            </div>
                        </div>
                        <div class=""form-group"">
   ");
                WriteLiteral(@"                         <label class=""col-md-2"">
                                Unit Price
                            </label>
                            <div class=""col-md-4"">
                                <input type=""text"" id=""unitPrice"" name=""unitPrice"" placeholder=""Unit Price"" class=""form-control"" />
                            </div>
                            <label class=""col-md-2"">
                                Quantity
                            </label>
                            <div class=""col-md-2"">
                                <input type=""text"" id=""quantity"" name=""quantity"" placeholder=""Quantity"" class=""form-control"" />
                            </div>
                            <div class=""col-md-2"">
                                <a id=""addToList"" class=""btn btn-primary"">Add To List</a>
                            </div>
                        </div>
                        <table id=""detailsTable"" class=""table"">
                            <thead>
      ");
                WriteLiteral(@"                          <tr>
                                    <th style=""width:5%"">Item No</th>
                                    <th style=""width:30%"">Part No</th>
                                    <th style=""width:30%"">Unit Price</th>
                                    <th style=""width:5%"">Quantity</th>
                                    <th style=""width:30%"">Amount</th>
                                </tr>
                            </thead>
                            <tbody></tbody>
                        </table>
                    </div>
                    
                </div>
                <div class=""modal-footer"">
                    <button type=""reset"" class=""btn btn-default"" data-dismiss=""modal"">Close</button>
                    <button id=""saveOrder"" type=""submit"" class=""btn btn-danger"">Save Order</button>
                </div>
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7515, 38, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(7571, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(7577, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3733c5cd8a84f9596c64853b782c73e", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7613, 8, true);
                WriteLiteral("\r\n    \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DemoTestModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DemoTestModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DemoTestModel>)PageContext?.ViewData;
        public DemoTestModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591