#pragma checksum "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\Demo\DemoTestAttachment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5050851bba6bee97c0e751c13e328e1b19c8874"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(EC.Web.Areas.RMA.Pages.Demo.Areas_RMA_Pages_Demo_DemoTestAttachment), @"mvc.1.0.razor-page", @"/Areas/RMA/Pages/Demo/DemoTestAttachment.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/RMA/Pages/Demo/DemoTestAttachment.cshtml", typeof(EC.Web.Areas.RMA.Pages.Demo.Areas_RMA_Pages_Demo_DemoTestAttachment), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5050851bba6bee97c0e751c13e328e1b19c8874", @"/Areas/RMA/Pages/Demo/DemoTestAttachment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1dd3590eb3145065795dd53dfb0854044e0ffe88", @"/Areas/RMA/Pages/_ViewImports.cshtml")]
    public class Areas_RMA_Pages_Demo_DemoTestAttachment : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("newOrderDetail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/RMA/demoTestAttachment.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(46, 348, true);
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
#line 16 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\Demo\DemoTestAttachment.cshtml"
             if (Model.Orders.Count() != 0)
            {
                foreach (var order in Model.Orders)
                {

#line default
#line hidden
            BeginContext(526, 307, true);
            WriteLiteral(@"                    <div class=""row"">
                        <div class=""col-md-12"">
                            <table class=""table table-striped table-responsive"">
                                <tbody>
                                    <tr>
                                        <td>Customer: ");
            EndContext();
            BeginContext(834, 14, false);
#line 25 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\Demo\DemoTestAttachment.cshtml"
                                                 Write(order.Customer);

#line default
#line hidden
            EndContext();
            BeginContext(848, 63, true);
            WriteLiteral("</td>\r\n                                        <td>Order Date: ");
            EndContext();
            BeginContext(912, 15, false);
#line 26 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\Demo\DemoTestAttachment.cshtml"
                                                   Write(order.OrderDate);

#line default
#line hidden
            EndContext();
            BeginContext(927, 778, true);
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
#line 39 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\Demo\DemoTestAttachment.cshtml"
                                                      
                                                        var totalBill = 0;
                                                    

#line default
#line hidden
            BeginContext(1892, 52, true);
            WriteLiteral("                                                    ");
            EndContext();
#line 42 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\Demo\DemoTestAttachment.cshtml"
                                                     foreach (var detail in order.Details)
                                                    {

#line default
#line hidden
            BeginContext(2039, 126, true);
            WriteLiteral("                                                        <tr>\r\n                                                            <td>");
            EndContext();
            BeginContext(2166, 13, false);
#line 45 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\Demo\DemoTestAttachment.cshtml"
                                                           Write(detail.ItemNo);

#line default
#line hidden
            EndContext();
            BeginContext(2179, 71, true);
            WriteLiteral("</td>\r\n                                                            <td>");
            EndContext();
            BeginContext(2251, 13, false);
#line 46 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\Demo\DemoTestAttachment.cshtml"
                                                           Write(detail.PartNo);

#line default
#line hidden
            EndContext();
            BeginContext(2264, 71, true);
            WriteLiteral("</td>\r\n                                                            <td>");
            EndContext();
            BeginContext(2336, 16, false);
#line 47 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\Demo\DemoTestAttachment.cshtml"
                                                           Write(detail.UnitPrice);

#line default
#line hidden
            EndContext();
            BeginContext(2352, 71, true);
            WriteLiteral("</td>\r\n                                                            <td>");
            EndContext();
            BeginContext(2424, 15, false);
#line 48 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\Demo\DemoTestAttachment.cshtml"
                                                           Write(detail.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(2439, 71, true);
            WriteLiteral("</td>\r\n                                                            <td>");
            EndContext();
            BeginContext(2511, 13, false);
#line 49 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\Demo\DemoTestAttachment.cshtml"
                                                           Write(detail.Amount);

#line default
#line hidden
            EndContext();
            BeginContext(2524, 70, true);
            WriteLiteral("</td>\r\n                                                        </tr>\r\n");
            EndContext();
#line 51 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\Demo\DemoTestAttachment.cshtml"
                                                        totalBill += detail.Amount;
                                                    }

#line default
#line hidden
            BeginContext(2734, 239, true);
            WriteLiteral("                                                </tbody>\r\n                                            </table>\r\n                                            <span class=\"pull-right\" style=\"margin-right:100px;\"><strong>Total Bill: </strong> ");
            EndContext();
            BeginContext(2974, 9, false);
#line 55 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\Demo\DemoTestAttachment.cshtml"
                                                                                                                          Write(totalBill);

#line default
#line hidden
            EndContext();
            BeginContext(2983, 239, true);
            WriteLiteral("</span>\r\n                                        </td>\r\n                                    </tr>\r\n                                </tbody>\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 62 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\Demo\DemoTestAttachment.cshtml"
                }
            }
            else
            {

#line default
#line hidden
            BeginContext(3289, 103, true);
            WriteLiteral("                <div>\r\n                    <h3 style=\"color:red;\">Empty!</h3>\r\n                </div>\r\n");
            EndContext();
#line 69 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\Demo\DemoTestAttachment.cshtml"
            }

#line default
#line hidden
            BeginContext(3407, 378, true);
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
            BeginContext(3785, 4938, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88128c1778f04a8fa6eeac417c4cf73c", async() => {
                BeginContext(3811, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(3830, 23, false);
#line 81 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\RMA\Pages\Demo\DemoTestAttachment.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(3853, 44, true);
                WriteLiteral("\r\n                <div class=\"modal-body\">\r\n");
                EndContext();
                BeginContext(3939, 586, true);
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
                BeginContext(4564, 2625, true);
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
");
                EndContext();
                BeginContext(7232, 1484, true);
                WriteLiteral(@"                    <div>
                        <input type=""file"" id=""fUpload"" name=""files"" multiple class=""form-control"" hidden />
                        <div id=""output"" style=""min-height: 200px; white-space: pre; border: 1px solid black;""
                             ondragenter=""event.stopPropagation(); event.preventDefault();""
                             ondragover=""event.stopPropagation(); event.preventDefault();""
                             ondrop=""event.stopPropagation(); event.preventDefault(); onDrop(event);"">
                            DROP FILES HERE FROM FINDER OR EXPLORER
                        </div>
                        <table id=""attachmentsTable"" class=""table"">
                            <thead>
                                <tr>
                                    <th style=""width:40%"">Id</th>
                                    <th style=""width:40%"">File Name</th>
                                    <th style=""width:20%"">Size</th>
                               ");
                WriteLiteral(@" </tr>
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
            BeginContext(8723, 38, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(8779, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(8785, 54, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93652f852f724af5b5759a7016e3cd7e", async() => {
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
                BeginContext(8839, 6, true);
                WriteLiteral("    \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DemoTestAttachmentModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DemoTestAttachmentModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DemoTestAttachmentModel>)PageContext?.ViewData;
        public DemoTestAttachmentModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
