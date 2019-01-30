#pragma checksum "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Examples\Pages\SampleOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "969f11797e2497a49975f18adbf4fd060d64a645"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(EC.Web.Areas.Examples.Pages.Areas_Examples_Pages_SampleOrder), @"mvc.1.0.razor-page", @"/Areas/Examples/Pages/SampleOrder.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Examples/Pages/SampleOrder.cshtml", typeof(EC.Web.Areas.Examples.Pages.Areas_Examples_Pages_SampleOrder), null)]
namespace EC.Web.Areas.Examples.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Examples\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Examples\Pages\_ViewImports.cshtml"
using EC.Web.Areas.Identity;

#line default
#line hidden
#line 3 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Examples\Pages\_ViewImports.cshtml"
using EC.Web.ViewModels;

#line default
#line hidden
#line 5 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Examples\Pages\_ViewImports.cshtml"
using EC.Web.Data;

#line default
#line hidden
#line 6 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Examples\Pages\_ViewImports.cshtml"
using EC.Web.Areas.Examples.Data;

#line default
#line hidden
#line 7 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Examples\Pages\_ViewImports.cshtml"
using EC.Web.ViewModels.Base;

#line default
#line hidden
#line 8 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Examples\Pages\_ViewImports.cshtml"
using EC.Web.ViewModels.Demo;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"969f11797e2497a49975f18adbf4fd060d64a645", @"/Areas/Examples/Pages/SampleOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0e828f88306a3d80c5644a019e570ccec3a46fb", @"/Areas/Examples/Pages/_ViewImports.cshtml")]
    public class Areas_Examples_Pages_SampleOrder : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("newOrderDetail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Examples/sampleOrder.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(39, 354, true);
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
#line 17 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Examples\Pages\SampleOrder.cshtml"
             if (Model.Orders.Count() != 0)
            {
                foreach (var order in Model.Orders)
                {

#line default
#line hidden
            BeginContext(525, 330, true);
            WriteLiteral(@"                    <div class=""row"">
                        <div class=""col-md-12"">
                            <table class=""table table-striped table-responsive"" style=""display: table"">
                                <tbody>
                                    <tr>
                                        <td>Customer: ");
            EndContext();
            BeginContext(856, 27, false);
#line 26 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Examples\Pages\SampleOrder.cshtml"
                                                 Write(order.Customer.CustomerName);

#line default
#line hidden
            EndContext();
            BeginContext(883, 63, true);
            WriteLiteral("</td>\r\n                                        <td>Order Date: ");
            EndContext();
            BeginContext(947, 15, false);
#line 27 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Examples\Pages\SampleOrder.cshtml"
                                                   Write(order.OrderDate);

#line default
#line hidden
            EndContext();
            BeginContext(962, 778, true);
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
#line 40 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Examples\Pages\SampleOrder.cshtml"
                                                      
                                                        var totalBill = 0.0M;
                                                    

#line default
#line hidden
            BeginContext(1930, 52, true);
            WriteLiteral("                                                    ");
            EndContext();
#line 43 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Examples\Pages\SampleOrder.cshtml"
                                                     foreach (var detail in order.Items)
                                                    {
                                                        var amount = detail.Product.UnitPrice * detail.Quantity;

#line default
#line hidden
            BeginContext(2189, 126, true);
            WriteLiteral("                                                        <tr>\r\n                                                            <td>");
            EndContext();
            BeginContext(2316, 13, false);
#line 47 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Examples\Pages\SampleOrder.cshtml"
                                                           Write(detail.ItemNo);

#line default
#line hidden
            EndContext();
            BeginContext(2329, 71, true);
            WriteLiteral("</td>\r\n                                                            <td>");
            EndContext();
            BeginContext(2401, 21, false);
#line 48 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Examples\Pages\SampleOrder.cshtml"
                                                           Write(detail.Product.PartNo);

#line default
#line hidden
            EndContext();
            BeginContext(2422, 71, true);
            WriteLiteral("</td>\r\n                                                            <td>");
            EndContext();
            BeginContext(2494, 24, false);
#line 49 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Examples\Pages\SampleOrder.cshtml"
                                                           Write(detail.Product.UnitPrice);

#line default
#line hidden
            EndContext();
            BeginContext(2518, 71, true);
            WriteLiteral("</td>\r\n                                                            <td>");
            EndContext();
            BeginContext(2590, 15, false);
#line 50 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Examples\Pages\SampleOrder.cshtml"
                                                           Write(detail.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(2605, 71, true);
            WriteLiteral("</td>\r\n                                                            <td>");
            EndContext();
            BeginContext(2677, 6, false);
#line 51 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Examples\Pages\SampleOrder.cshtml"
                                                           Write(amount);

#line default
#line hidden
            EndContext();
            BeginContext(2683, 70, true);
            WriteLiteral("</td>\r\n                                                        </tr>\r\n");
            EndContext();
#line 53 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Examples\Pages\SampleOrder.cshtml"
                                                        totalBill += amount;
                                                    }

#line default
#line hidden
            BeginContext(2886, 239, true);
            WriteLiteral("                                                </tbody>\r\n                                            </table>\r\n                                            <span class=\"pull-right\" style=\"margin-right:100px;\"><strong>Total Bill: </strong> ");
            EndContext();
            BeginContext(3126, 9, false);
#line 57 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Examples\Pages\SampleOrder.cshtml"
                                                                                                                          Write(totalBill);

#line default
#line hidden
            EndContext();
            BeginContext(3135, 239, true);
            WriteLiteral("</span>\r\n                                        </td>\r\n                                    </tr>\r\n                                </tbody>\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 64 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Examples\Pages\SampleOrder.cshtml"
                }
            }
            else
            {

#line default
#line hidden
            BeginContext(3441, 103, true);
            WriteLiteral("                <div>\r\n                    <h3 style=\"color:red;\">Empty!</h3>\r\n                </div>\r\n");
            EndContext();
#line 71 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Examples\Pages\SampleOrder.cshtml"
            }

#line default
#line hidden
            BeginContext(3559, 393, true);
            WriteLiteral(@"        </div>
    </div>
</div>
<div class=""modal fade"" id=""newOrderModal"">
    <div id=""modalDialog"" class=""modal-dialog modal-lg"" style=""width:90% !important;"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4>Add New Item</h4>
                <a href=""#"" class=""close"" data-dismiss=""modal"">&times;</a>
            </div>
            ");
            EndContext();
            BeginContext(3952, 5867, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b21a61acec24a1085979efe2926f4b7", async() => {
                BeginContext(3978, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(3997, 23, false);
#line 83 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Examples\Pages\SampleOrder.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(4020, 44, true);
                WriteLiteral("\r\n                <div class=\"modal-body\">\r\n");
                EndContext();
                BeginContext(4106, 648, true);
                WriteLiteral(@"                    <h5 style=""color:#ff6347"">Customer Details</h5>
                    <hr />
                    <div>
                        <input type=""hidden"" id=""customerId"" name=""customerId"" />
                        <div class=""form-group row"">
                            <label class=""col-md-2"">Customer</label>
                            <div class=""col-md-4"">
                                <input type=""text"" id=""customerName"" name=""customerName"" placeholder=""Customer"" class=""form-control"" />                                
                            </div>
                        </div>
                    </div>
");
                EndContext();
                BeginContext(4793, 3483, true);
                WriteLiteral(@"                    <h5 style=""margin-top:10px;color:#ff6347"">Order Details</h5>
                    <hr />
                    <div>
                        <input type=""hidden"" id=""orderId"" />
                        <div class=""form-group row"">
                            <label class=""col-md-2"">
                                Item No
                            </label>
                            <div class=""col-md-2"">
                                <input type=""text"" id=""productId"" name=""productId"" hidden />
                                <input type=""text"" id=""itemNo"" name=""itemNo"" placeholder=""Item No"" class=""form-control"" />
                            </div>
                            <div class=""col-md-8""></div>
                        </div>
                        <div class=""form-group row"">                            
                            <label class=""col-md-2"">
                                Part No
                            </label>
                           ");
                WriteLiteral(@" <div class=""col-md-2"">
                                <input type=""text"" id=""partNo"" name=""partNo"" placeholder=""Part No"" class=""form-control"" />                                
                            </div>
                            <label class=""col-md-3"">
                                Product Description
                            </label>
                            <div class=""col-md-5"">
                                <input type=""text"" id=""productDescription"" name=""ProductDescription"" placeholder=""Product Description"" class=""form-control"" />
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <label class=""col-md-2"">
                                Unit Price
                            </label>
                            <div class=""col-md-4"">
                                <input type=""text"" id=""unitPrice"" name=""unitPrice"" placeholder=""Unit Price"" class=""form-control"" />
       ");
                WriteLiteral(@"                     </div>
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
                                <tr>
                                    <th style=""width:10%"">Item No</th>
                                    <th style=""width:5%"">Product Id</th>
                                    <th style=""width:20%"">Part No</th>
                                    <th style=""width:30%"">Product Descripti");
                WriteLiteral(@"on</th>
                                    <th style=""width:30%"">Unit Price</th>
                                    <th style=""width:5%"">Quantity</th>
                                    <th style=""width:10%"">Amount</th>
                                </tr>
                            </thead>
                            <tbody></tbody>
                        </table>
                    </div>
");
                EndContext();
                BeginContext(8319, 1493, true);
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
                WriteLiteral(@"          </tr>
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
            BeginContext(9819, 38, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(9875, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(9881, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4cc452456ccb4c86b58d15b27d895c96", async() => {
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
                BeginContext(9933, 2, true);
                WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SampleOrderModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SampleOrderModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SampleOrderModel>)PageContext?.ViewData;
        public SampleOrderModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
